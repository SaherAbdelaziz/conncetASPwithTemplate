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
    public class PromoesController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        // GET: api/Promoes
        public IQueryable<Promo> GetPromos()
        {
            return _context.Promos;
        }

        // GET: api/Promoes/5
        [ResponseType(typeof(Promo))]
        public IHttpActionResult GetPromo(int id)
        {
            Promo promo = _context.Promos.Find(id);
            if (promo == null)
            {
                return NotFound();
            }
            
            return Ok(promo);
        }

        // PUT: api/Promoes/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutPromo(int id, Promo promo)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != promo.Id)
            {
                return BadRequest();
            }

            _context.Entry(promo).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PromoExists(id))
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

        // POST: api/Promoes
        [ResponseType(typeof(Promo))]
        public IHttpActionResult PostPromo(Promo model)
        {
            if (model.Id == -1)
            {
                Promo promo = _context.Promos.SingleOrDefault(p => p.Code == model.Code);
                if (promo == null)
                    return NotFound();
                else
                {
                    return Ok(promo);
                }
            }
            else
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                _context.Promos.Add(model);
                _context.SaveChanges();
                return CreatedAtRoute("DefaultApi", new { id = model.Id }, model);
            }
            
        }

        // DELETE: api/Promoes/5
        [ResponseType(typeof(Promo))]
        public IHttpActionResult DeletePromo(int id)
        {
            Promo promo = _context.Promos.Find(id);
            if (promo == null)
            {
                return NotFound();
            }

            _context.Promos.Remove(promo);
            _context.SaveChanges();

            return Ok(promo);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool PromoExists(int id)
        {
            return _context.Promos.Count(e => e.Id == id) > 0;
        }
    }
}