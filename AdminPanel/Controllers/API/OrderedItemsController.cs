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

namespace AdminPanel.Controllers.API
{
    public class OrderedItemsController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        // GET: api/OrderedItems
        public IQueryable<OrderedItem> GetOrderedItems()
        {
            return _context.OrderedItems;
        }

        // GET: api/OrderedItems/5
        [ResponseType(typeof(OrderedItem))]
        public IHttpActionResult GetOrderedItem(int id)
        {
            OrderedItem orderedItem = _context.OrderedItems.Find(id);
            if (orderedItem == null)
            {
                return NotFound();
            }

            return Ok(orderedItem);
        }

        // PUT: api/OrderedItems/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutOrderedItem(int id, OrderedItem orderedItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != orderedItem.ItemId)
            {
                return BadRequest();
            }

            _context.Entry(orderedItem).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!OrderedItemExists(id))
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

        // POST: api/OrderedItems
        [ResponseType(typeof(OrderedItem))]
        public IHttpActionResult PostOrderedItem(OrderedItem orderedItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.OrderedItems.Add(orderedItem);

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (OrderedItemExists(orderedItem.ItemId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = orderedItem.ItemId }, orderedItem);
        }

        // DELETE: api/OrderedItems/5
        [ResponseType(typeof(OrderedItem))]
        public IHttpActionResult DeleteOrderedItem(int id)
        {
            OrderedItem orderedItem = _context.OrderedItems.Find(id);
            if (orderedItem == null)
            {
                return NotFound();
            }

            _context.OrderedItems.Remove(orderedItem);
            _context.SaveChanges();

            return Ok(orderedItem);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool OrderedItemExists(int id)
        {
            return _context.OrderedItems.Count(e => e.ItemId == id) > 0;
        }
    }
}