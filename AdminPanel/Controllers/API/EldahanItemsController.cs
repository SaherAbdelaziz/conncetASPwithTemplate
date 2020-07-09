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
    public class EldahanItemsController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        // GET: api/EldahanItems
        public IQueryable<EldahanItems> GetEldahanItems()
        {
            return _context.EldahanItems.Where(e=>e.Id<20);
        }

        // GET: api/EldahanItems/5
        [ResponseType(typeof(EldahanItems))]
        public IHttpActionResult GetEldahanItems(int id)
        {
            EldahanItems eldahanItems = _context.EldahanItems.Find(id);
            if (eldahanItems == null)
            {
                return NotFound();
            }

            return Ok(eldahanItems);
        }

        // PUT: api/EldahanItems/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutEldahanItems(int id, EldahanItems eldahanItems)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != eldahanItems.Id)
            {
                return BadRequest();
            }

            _context.Entry(eldahanItems).State = EntityState.Modified;

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

        // POST: api/EldahanItems
        [ResponseType(typeof(EldahanItems))]
        public IHttpActionResult PostEldahanItems(EldahanItems eldahanItems)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.EldahanItems.Add(eldahanItems);
            _context.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = eldahanItems.Id }, eldahanItems);
        }

        // DELETE: api/EldahanItems/5
        [ResponseType(typeof(EldahanItems))]
        public IHttpActionResult DeleteEldahanItems(int id)
        {
            EldahanItems eldahanItems = _context.EldahanItems.Find(id);
            if (eldahanItems == null)
            {
                return NotFound();
            }

            _context.EldahanItems.Remove(eldahanItems);
            _context.SaveChanges();

            return Ok(eldahanItems);
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
            return _context.EldahanItems.Count(e => e.Id == id) > 0;
        }
    }
}