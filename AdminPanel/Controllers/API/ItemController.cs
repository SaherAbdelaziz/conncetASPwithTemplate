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
    public class ItemController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        // GET: api/Item
        public IQueryable<Item> GetEldahanItems()
        {
            return _context.Items.Where(e=>e.Id<20);
        }

        // GET: api/Item/5
        [ResponseType(typeof(Item))]
        public IHttpActionResult GetEldahanItems(int id)
        {
            Item eldahanItems = _context.Items.Find(id);
            if (eldahanItems == null)
            {
                return NotFound();
            }

            return Ok(eldahanItems);
        }

        // PUT: api/Item/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEldahanItems(int id, Item item)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != item.Id)
            {
                return BadRequest();
            }

            _context.Entry(item).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EldahanItemsExists(id))
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

        // PUT: api/Item/5

        [ResponseType(typeof(void))]
        public void PutEldahanItems(Item itemModel)
        {
            var item = _context.Items
                .SingleOrDefault(o => o.Id == itemModel.Id);

            if (item == null)
            {
                return;
            }

            item.Available = itemModel.Available; // 0 for available 1 or others for not available

            _context.SaveChanges();


        }

        // POST: api/Item
        [ResponseType(typeof(Item))]
        public IHttpActionResult PostEldahanItems(Item item)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Items.Add(item);
            _context.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = item.Id }, item);
        }

        // DELETE: api/Item/5
        [ResponseType(typeof(Item))]
        public IHttpActionResult DeleteEldahanItems(int id)
        {
            Item item = _context.Items.Find(id);
            if (item == null)
            {
                return NotFound();
            }

            _context.Items.Remove(item);
            _context.SaveChanges();

            return Ok(item);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EldahanItemsExists(int id)
        {
            return _context.Items.Count(e => e.Id == id) > 0;
        }
    }
}