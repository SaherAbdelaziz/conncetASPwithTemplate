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
    public class ChecksController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();
        public string UserId;
        public Cart Cart { get; set; }


        public ChecksController()
        {
            UserId = User.Identity.GetUserId();
            Cart = _context.Carts
                .SingleOrDefault(c => c.ApplicationUserId == UserId);
        }
        // GET: api/Checks
        public IQueryable<Check> GetChecks()
        {
            return _context.Checks;
        }

        // GET: api/Checks/5
        [ResponseType(typeof(Check))]
        public IHttpActionResult GetCheck(long id)
        {
            Check check = _context.Checks.Find(id);
            if (check == null)
            {
                return NotFound();
            }

            return Ok(check);
        }

        // PUT: api/Checks/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCheck(long id, Check check)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != check.ID)
            {
                return BadRequest();
            }

            _context.Entry(check).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CheckExists(id))
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
        // PUT: api/Checks/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutCheck(int? promoCodeId)
        {

            var check = _context.Checks
                .SingleOrDefault(c => c.Cust_ID == UserId && c.MyStatus == "Open");

            check.HasPromoCode = true;
            check.PromoCodeId = (int) promoCodeId;
            _context.Entry(check).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                    throw;
                
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        // POST: api/Checks
        [ResponseType(typeof(Check))]
        public IHttpActionResult PostCheck(Check check)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Checks.Add(check);

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (CheckExists(check.ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = check.ID }, check);
        }

        // DELETE: api/Checks/5
        [ResponseType(typeof(Check))]
        public IHttpActionResult DeleteCheck(long id)
        {
            Check check = _context.Checks.Find(id);
            if (check == null)
            {
                return NotFound();
            }

            _context.Checks.Remove(check);
            _context.SaveChanges();

            return Ok(check);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool CheckExists(long id)
        {
            return _context.Checks.Count(e => e.ID == id) > 0;
        }
    }
}