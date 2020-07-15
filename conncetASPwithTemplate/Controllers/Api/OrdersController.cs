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

        // POST: api/Orders
        [ResponseType(typeof(Order))]
        public IHttpActionResult PostOrder(Order order)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            string tmpOrder = "";
            var cartItems = _context.MyCartItems
                .Where(c => c.ShoppingCartId == Cart.Id && !c.Removed)
                .Include(c => c.EldahanItem).ToList();

            foreach (var cart in cartItems)
            {
                //tmpOrder += cart.Quantity + "x" + cart.EldahanItem.Name2 + " \t Price " + cart.EldahanItem.StaticPrice + " LE \n";
                tmpOrder += $"{cart.Quantity}x {cart.EldahanItem.Name2} Price {cart.EldahanItem.StaticPrice} LE @\n";
            }

            string currentUserId = User.Identity.GetUserId();
            ApplicationUser currentUser = _context.Users.FirstOrDefault(x => x.Id == currentUserId);
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