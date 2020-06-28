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

namespace conncetASPwithTemplate.Controllers.Api
{
    public class EldahanItemsController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: api/EldahanItems
        public IQueryable<EldahanItems> GetEldahanItems()
        {
            return db.EldahanItems;
        }

        // GET: api/EldahanItems/5
        [ResponseType(typeof(EldahanItems))]
        public IHttpActionResult GetEldahanItems(int id)
        {
            EldahanItems eldahanItems = db.EldahanItems.Find(id);
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

            db.Entry(eldahanItems).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
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

            db.EldahanItems.Add(eldahanItems);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = eldahanItems.Id }, eldahanItems);
        }

        // DELETE: api/EldahanItems/5
        [ResponseType(typeof(EldahanItems))]
        public IHttpActionResult DeleteEldahanItems(int id)
        {
            EldahanItems eldahanItems = db.EldahanItems.Find(id);
            if (eldahanItems == null)
            {
                return NotFound();
            }

            db.EldahanItems.Remove(eldahanItems);
            db.SaveChanges();

            return Ok(eldahanItems);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool EldahanItemsExists(int id)
        {
            return db.EldahanItems.Count(e => e.Id == id) > 0;
        }
    }
}