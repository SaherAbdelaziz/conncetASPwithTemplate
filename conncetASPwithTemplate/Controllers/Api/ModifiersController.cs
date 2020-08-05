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
using conncetASPwithTemplate;
using conncetASPwithTemplate.Models;

namespace conncetASPwithTemplate.Controllers.Api
{
    public class ModifiersController : ApiController
    {
        private ApplicationDbContext _context = new ApplicationDbContext();

        // GET: api/Modifiers
        public IQueryable<Modifier> GetModifiers()
        {
            return _context.Modifiers.Include(m=>m.ModifiersGroup).Include(m=>m.EldahanItems);
        }

        // GET: api/Modifiers/5
        public IHttpActionResult GetModifier(int id )
        {
            Modifier modifier = _context.Modifiers.Find(id);//.Where(m=>m.ModifiersGroupId==id1);
            if (modifier == null)
            {
                return NotFound();
            }

            return Ok(modifier);
        }

        // PUT: api/Modifiers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutModifier(int id, Modifier modifier)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != modifier.ModifiersGroupId)
            {
                return BadRequest();
            }

            _context.Entry(modifier).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModifierExists(id))
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

        // POST: api/Modifiers
        [ResponseType(typeof(Modifier))]
        public IHttpActionResult PostModifier(Modifier modifier)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Modifiers.Add(modifier);

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ModifierExists(modifier.ModifiersGroupId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = modifier.ModifiersGroupId }, modifier);
        }

        // DELETE: api/Modifiers/5
        [ResponseType(typeof(Modifier))]
        public IHttpActionResult DeleteModifier(int id)
        {
            Modifier modifier = _context.Modifiers.Find(id);
            if (modifier == null)
            {
                return NotFound();
            }

            _context.Modifiers.Remove(modifier);
            _context.SaveChanges();

            return Ok(modifier);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ModifierExists(int id)
        {
            return _context.Modifiers.Count(e => e.ModifiersGroupId == id) > 0;
        }
    }
}