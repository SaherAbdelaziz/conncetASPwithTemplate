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
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
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
            
            var cartItems = _context.CartItems
                .Where(c => c.ShoppingCartId == Cart.Id && !c.Removed)
                .Include(c => c.Item).ToList();


            // Get check with customer id and state open and get its check items 
            var check = _context.Checks
                .SingleOrDefault(c => c.Cust_ID == UserId && c.MyStatus == "Open");

            var checkItems = _context.ChecksItems
                .Where(chI => chI.Check_ID == check.ID).ToList();
            // code for generate checkstaxadjtip
            var valueTax = order.Delivery;
            var checksTaxAdjTip = new ChecksTaxAdjTip(check.ID, 0, valueTax, "Adjustment", false);
            valueTax = .14 * order.Price;
            var checksTaxAdjTip2 = new ChecksTaxAdjTip(check.ID, 14, valueTax, "Tax", false);
            _context.ChecksTaxAdjTips.Add(checksTaxAdjTip);
            _context.ChecksTaxAdjTips.Add(checksTaxAdjTip2);

            //code for generate checksItemsSettlesSummary
            var netTotal = order.Price + order.Delivery + valueTax;
            var checksItemsSettlesSummary = new ChecksItemsSettlesSummary(check.ID, order.Price, valueTax,
                false, order.Delivery, false,
                0, 0, 0, false,
                netTotal, 0, netTotal, 0, netTotal, 0, false);

            _context.ChecksItemsSettlesSummaries.Add(checksItemsSettlesSummary);
            //var count = 1;

            foreach (var cart in cartItems)
            {
                
                cart.Removed = true;
                _context.CartItems.Remove(cart);
                //count++;
            }

            Order myOrder = new Order()
            {
                CartId = Cart.Id,
                UserId = UserId,
                CheckId = check.ID,
                //Details = tmpOrder,
                DateCreated = DateTime.Now,
                DeliveryTimeIndex = order.DeliveryTimeIndex,
                DeliveryTypeIndex = order.DeliveryTypeIndex,
                Delivery = order.Delivery,
                Price = order.Price,
                TotalPrice = order.Price + order.Delivery,

            };

            _context.Orders.Add(myOrder);

            
            _context.SaveChanges();
            
            check.Order_No = myOrder.Id;
            check.MyStatus = "Preparing";
            _context.Entry(check).State = EntityState.Modified;
            foreach (var checkItem in checkItems)
            {
                checkItem.Fired = true;
                if (checkItem.Status == "Open")
                    checkItem.Status = "Preparing";
            }

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