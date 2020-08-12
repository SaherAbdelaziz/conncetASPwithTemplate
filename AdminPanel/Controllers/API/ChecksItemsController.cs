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
using AdminPanel.ViewModels;

namespace AdminPanel.Controllers.API
{
    public class ChecksItemsController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        // GET: api/ChecksItems
        public IQueryable<ChecksItem> GetChecksItems()
        {
            return _context.ChecksItems;
        }

        // GET: api/ChecksItems/5
        //[ResponseType(typeof(ChecksItem))]
        public OrderViewModel GetChecksItem(long id) // this id is for order
        {
            //get chekItems based on order id
            var order = _context.Orders
                .Include(o => o.User)
                .Include(o => o.User.Outlet)
                .Include(o => o.User.Area)
                .SingleOrDefault(o => o.Id == id);

            if (order == null)
            {
                //return NotFound();
            }

            var checkItems = _context.ChecksItems
                .Include(ch=>ch.Item)
                .Where(ch => ch.Check_ID == order.CheckId &&ch.Fired==true &&
                             ch.Status!= "Aborted").ToList();

            var orderViewModel = new OrderViewModel(order , checkItems);
            return orderViewModel;
        }

        // PUT: api/ChecksItems/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutChecksItem(long id, ChecksItem checksItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != checksItem.Check_ID)
            {
                return BadRequest();
            }

            _context.Entry(checksItem).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ChecksItemExists(id))
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

        // POST: api/ChecksItems
        [ResponseType(typeof(ChecksItem))]
        public IHttpActionResult PostChecksItem(ChecksItem checksItem)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ChecksItems.Add(checksItem);

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ChecksItemExists(checksItem.Check_ID))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = checksItem.Check_ID }, checksItem);
        }

        // DELETE: api/ChecksItems/5
        [ResponseType(typeof(ChecksItem))]
        public IHttpActionResult DeleteChecksItem(long id)
        {
            ChecksItem checksItem = _context.ChecksItems.Find(id);
            if (checksItem == null)
            {
                return NotFound();
            }

            _context.ChecksItems.Remove(checksItem);
            _context.SaveChanges();

            return Ok(checksItem);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ChecksItemExists(long id)
        {
            return _context.ChecksItems.Count(e => e.Check_ID == id) > 0;
        }
    }
}