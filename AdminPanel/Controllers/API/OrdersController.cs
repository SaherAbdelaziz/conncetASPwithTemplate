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
using AdminPanel.Models;
using Microsoft.AspNet.Identity;

namespace AdminPanel.Controllers.API
{
    public class OrdersController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        // GET: api/Orders
        public IQueryable<Order> GetOrders()
        {
            return _context.Orders;
        }

        // GET: api/Orders/5
        [ResponseType(typeof(Order))]
        public IHttpActionResult GetOrder(int id)
        {
            if (id == -1)
            {
                id = _context.Orders.Max(o => o.Id);
                Order order = _context.Orders.SingleOrDefault(o => o.Id == id);
                return Ok(order);

            }
            else
            {
                Order order = _context.Orders.Find(id);
                if (order == null)
                {
                    return NotFound();
                }
                return Ok(order);
            }

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

        [ResponseType(typeof(void))]
        public void PutOrder(Order modelOrder)
        {
            var order = _context.Orders
                .SingleOrDefault(o => o.Id == modelOrder.Id);

            if (order == null)
            {
                return;
            }

            if (modelOrder.OrderState == 1)// accepted
            {
                order.OrderState = modelOrder.OrderState; 
            }

            else if (modelOrder.OrderState == 2)// rejected
            {
                order.OrderState = modelOrder.OrderState; 
            }

            order.OrderState = modelOrder.OrderState; // 1 for accepted 2 for rejected 

            _context.SaveChanges();

        }

        // POST: api/Orders
        [ResponseType(typeof(Order))]
        public IHttpActionResult PostOrder(Order order)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}

            //string tmp = "";
            //var Idd = User.Identity.GetUserId();
            //var cartItems = _context.MyCartItems.Where(c => c.CartId == Idd).Include(c => c.Item).ToList();
            //foreach (var cart in cartItems)
            //{
            //    tmp += cart.Item.Name + " ";
            //}
            //Order myOrder = new Order()
            //{
            //    CartId = User.Identity.GetUserId(),
            //    CustomerName = User.Identity.GetUserName(),
            //    Details = tmp,
            //    DeliveryTimeIndex = order.DeliveryTimeIndex,
            //    Delivery = order.Delivery,
            //    Price = order.Price,
            //    TotalPrice = order.TotalPrice

            //};

            //_context.Orders.Add(myOrder);
            //_context.SaveChanges();

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