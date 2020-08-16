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
    public class AvailableTablesController : ApiController
    {
        private string UserId;
        private readonly ApplicationDbContext _context;

        public AvailableTablesController()
        {
            _context = new ApplicationDbContext();
            UserId = User.Identity.GetUserId();
        }
        // GET: api/AvailableTables
        public IQueryable<AvailableTable> GetAvailableTables()
        {
            return _context.AvailableTables;
            
        }

        // GET: api/AvailableTables/5
        [ResponseType(typeof(AvailableTable))]
        public IHttpActionResult GetAvailableTable(int id)
        {
            var availableTable = _context.AvailableTables
                .FirstOrDefault(a => a.IDRow == id.ToString());

            if (availableTable == null)
            {
                return NotFound();
            }

            return Ok(availableTable);
        }

        // PUT: api/AvailableTables/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutAvailableTable(int id, AvailableTable availableTable)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != availableTable.ID)
            {
                return BadRequest();
            }

            _context.Entry(availableTable).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AvailableTableExists(id))
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
        //should lock table till close the popup window then delete table will be called to delete the record

        // POST: api/AvailableTables
        [ResponseType(typeof(AvailableTable))]
        public IHttpActionResult PostAvailableTable(AvailableTable availableTable)
        {
            //if (!ModelState.IsValid)
            //{
            //    return BadRequest(ModelState);
            //}
            var name = User.Identity.GetUserName();
            var aTable = new AvailableTable(UserId , name , availableTable.IDRow);
            //aTable.ID = 1;
            _context.AvailableTables.Add(aTable);
            _context.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = availableTable.ID }, availableTable);
        }

        // DELETE: api/AvailableTables/5
        [ResponseType(typeof(AvailableTable))]
        public IHttpActionResult DeleteAvailableTable(int id)
        {
            var availableTable = _context.AvailableTables
                .FirstOrDefault(a => a.IDRow == id.ToString());
            
            if (availableTable == null)
            {
                return NotFound();
            }

            _context.AvailableTables.Remove(availableTable);
            _context.SaveChanges();

            return Ok(availableTable);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool AvailableTableExists(int id)
        {
            return _context.AvailableTables.Count(e => e.ID == id) > 0;
        }
    }
}