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
using System.Web.Mvc;
namespace conncetASPwithTemplate.Controllers.Api
{
    public class ItemsModifiersController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        // GET: api/ItemsModifiers
        public IQueryable<ItemsModifier> GetItemsModifiers()
        {
            var itemsModifiers = _context.ItemsModifiers
                .Include(i => i.ModifiersGroup);
            return itemsModifiers;
        }
        // GET: api/ItemsModifiers/5
        [ResponseType(typeof(ItemsModifier))]
        public IHttpActionResult GetItemsModifier(int id)
        {
            ItemsModifier itemsModifier = _context.ItemsModifiers.Find(id);
            if (itemsModifier == null)
            {
                return NotFound();
            }

            return Ok(itemsModifier);
        }

        // PUT: api/ItemsModifiers/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutItemsModifier(int id, ItemsModifier itemsModifier)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != itemsModifier.ItemId)
            {
                return BadRequest();
            }

            _context.Entry(itemsModifier).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ItemsModifierExists(id))
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

        // POST: api/ItemsModifiers
        [ResponseType(typeof(ItemsModifier))]
        public IHttpActionResult PostItemsModifier(ItemsModifier itemsModifier)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ItemsModifiers.Add(itemsModifier);

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateException)
            {
                if (ItemsModifierExists(itemsModifier.ItemId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtRoute("DefaultApi", new { id = itemsModifier.ItemId }, itemsModifier);
        }

        // DELETE: api/ItemsModifiers/5
        [ResponseType(typeof(ItemsModifier))]
        public IHttpActionResult DeleteItemsModifier(int id)
        {
            ItemsModifier itemsModifier = _context.ItemsModifiers.Find(id);
            if (itemsModifier == null)
            {
                return NotFound();
            }

            _context.ItemsModifiers.Remove(itemsModifier);
            _context.SaveChanges();

            return Ok(itemsModifier);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ItemsModifierExists(int id)
        {
            return _context.ItemsModifiers.Count(e => e.ItemId == id) > 0;
        }
    }
}