﻿using System;
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

            string tmp = "";
            var Idd = User.Identity.GetUserId();
            var cartItems = _context.CartItems.Where(c => c.CartId == Idd).Include(c=> c.Item).ToList();
            foreach (var cart in cartItems)
            {
                tmp += cart.Item.Name + " ";
            }

            var CustomerName = User.Identity.GetUserFirstName();
            var OutLetId = User.Identity.GetUserOutletId();
            var HdAreasId = User.Identity.GetUserAreaId();
            var delivery = _context.HdAreasServices
                .SingleOrDefault(h => h.AreaId == HdAreasId && h.OutLetId==OutLetId).Services;



            Order myOrder = new Order()
            {
                CartId = User.Identity.GetUserId(),
                CustomerName = User.Identity.GetUserFirstName(),
                CustomerPhone = User.Identity.GetUserPhone(),
                OutLetId = User.Identity.GetUserOutletId(),
                HdAreasId = User.Identity.GetUserAreaId(),
                
                Details = tmp,
                DateCreated = DateTime.Now,
                
                Delivery = (double) delivery,
                Price = order.Price,
                TotalPrice = order.Price + (double)delivery,

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