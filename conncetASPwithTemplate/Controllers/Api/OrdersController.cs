using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using conncetASPwithTemplate.Models;
using Microsoft.AspNet.Identity;

namespace conncetASPwithTemplate.Controllers.Api
{
    public class OrdersController : ApiController
    {
        private ApplicationDbContext _context = new ApplicationDbContext();
        public string UserId;
        public Cart Cart { get; set; }

        public OrdersController()
        {
            UserId = User.Identity.GetUserId();
            Cart = _context.Carts
                .SingleOrDefault(c => c.ApplicationUserId == UserId);
        }
        // GET: api/Orders
        public IQueryable<Order> GetOrders()
        {
            return _context.Orders;
           
        }

        // GET: api/Orders/5
        [ResponseType(typeof(Order))]
        public IHttpActionResult GetOrder(int id)
        {
            Order order = _context.Orders.Find(id);
            if (order == null)
            {
                return NotFound();
            }

            return Ok(order);
        }

        // PUT: api/Orders/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOrder(int id, Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != order.Id)
            {
                return BadRequest();
            }

            _context.Entry(order).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        //here we post new order
        // POST: api/Orders
        [ResponseType(typeof(Order))]
        public IHttpActionResult PostOrder(Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            string tmpOrder = "";
            string tmporderItem = "";
            var cartItems = _context.MyCartItems
                .Where(c => c.ShoppingCartId == Cart.Id && !c.Removed)
                .Include(c => c.EldahanItem).ToList();

            
            string currentUserId = User.Identity.GetUserId();
            ApplicationUser currentUser = _context.Users
                .FirstOrDefault(x => x.Id == currentUserId);

            var Name = currentUser.Name;
            var Phone = currentUser.Phone;


            var Street = currentUser.Street;
            var Adress = currentUser.Adress;
            var Adress2 = currentUser.Adress2;
            var Apartment = currentUser.Apartment;
            var Building = currentUser.Building;
            var Floor = currentUser.Floor;
            var SpecialMark = currentUser.SpecialMark;
            var outLetId = currentUser.OutletId;
            var hdAreasId = currentUser.AreaId;
            string tmpAddress =  "Area : " + Adress + " \n  Address : " + Adress2 
                + " \n Building : " + Building + " \n Floor : " + Floor;

            var modelCheck = _context.Checks.OrderByDescending(c => c.ID).FirstOrDefault();
            long checkId; 
            if (modelCheck !=null)
            {
                var modelCheckIdArea = 1 * 100000000000;
                var modelCheckIdOutlet = outLetId * 100000000;
                var modelCheckIdOutletStation = 88000000;
                var modelCheckId = modelCheck.ID % 1000000;
                checkId = modelCheckIdArea + modelCheckIdOutlet + modelCheckId + modelCheckIdOutletStation + 1;
                Check check = new Check(checkId, (int)(modelCheckId + 1),
                    (modelCheckId + 1).ToString(),
                    "web", "Ordered", outLetId);
                _context.Checks.Add(check);

            }
            else
            {
                var modelCheckIdArea = 1 * 100000000000;
                var modelCheckIdOutlet = outLetId * 100000000;
                var modelCheckIdOutletStation = 88000000;
                checkId = modelCheckIdArea + modelCheckIdOutlet + modelCheckIdOutletStation + 1;
                Check check = new Check(checkId, 1,
                    (1).ToString(),
                    "web", "Ordered", outLetId);
                _context.Checks.Add(check);
            }

            // code for generate checkstaxadjtip
            var valueTax = order.Delivery;
            var checksTaxAdjTip = new ChecksTaxAdjTip(checkId, 0, valueTax, "Adjustment", false);
            valueTax = .14 * order.Price;
            var checksTaxAdjTip2 = new ChecksTaxAdjTip(checkId, 14, valueTax, "Tax", false);
            _context.ChecksTaxAdjTips.Add(checksTaxAdjTip);
            _context.ChecksTaxAdjTips.Add(checksTaxAdjTip2);

            //code for generate checksItemsSettlesSummary
            var netTotal = order.Price + order.Delivery + valueTax;
            var checksItemsSettlesSummary = new ChecksItemsSettlesSummary(checkId , order.Price , valueTax ,
                false , order.Delivery , false , 
                0 , 0 , 0 ,false ,
                netTotal , 0 ,netTotal , 0 , netTotal , 0 , false);

            _context.ChecksItemsSettlesSummaries.Add(checksItemsSettlesSummary);
            var count = 1;

            foreach (var cart in cartItems)
            {
                //tmpOrder += cart.Quantity + "x" + cart.EldahanItem.Name2 + " \t Price " + cart.EldahanItem.StaticPrice + " LE \n";
                tmpOrder += $"{cart.Quantity}x {cart.EldahanItem.Name2} Price {cart.EldahanItem.StaticPrice} LE @";

                // new orderItem
                var orderItem = new OrderedItem(cart);
                _context.OrderedItems.Add(orderItem);


                //new checkItem
                var pprice = cart.EldahanItem.StaticPrice;
                var ttotal = pprice * cart.Quantity;

                var checkItem = new ChecksItem(checkId ,cart.EldahanItemId, cart.Quantity,
                    pprice, ttotal, 0 , 0 ,
                    0 , ttotal, count);

                _context.ChecksItems.Add(checkItem);
                tmporderItem +=
                    cart.Removed = true;
                count++;
            }

            Order myOrder = new Order()
            {
                CartId = Cart.Id,
                CustomerName = Name,
                CustomerPhone = Phone,
                CustomerStreet = tmpAddress, // temporary
                CustomerAddress1 = Adress,
                CustomerAddress2= Adress2,
                CustomerApartment = Apartment,
                CustomerBuilding = Building,
                CustomerFloor = Floor,
                CustomerSpecialMark = SpecialMark,
                OutLetId = outLetId,
                HdAreasId = hdAreasId,
                
                Details = tmpOrder,
                DateCreated = DateTime.Now,
                DeliveryTimeIndex = order.DeliveryTimeIndex,
                Delivery = order.Delivery,
                Price = order.Price,
                TotalPrice = order.Price + order.Delivery,

            };

           

            _context.Orders.Add(myOrder);
            _context.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = order.Id }, order);
        }

        // DELETE: api/Orders/5
        [ResponseType(typeof(Order))]
        public IHttpActionResult DeleteOrder(int id)
        {
            Order order = _context.Orders.Find(id);
            if (order == null)
            {
                return NotFound();
            }

            _context.Orders.Remove(order);
            _context.SaveChanges();

            return Ok(order);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OrderExists(int id)
        {
            return _context.Orders.Count(e => e.Id == id) > 0;
        }
    }
}