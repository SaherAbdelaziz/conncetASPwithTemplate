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
using conncetASPwithTemplate.Dtos;

namespace conncetASPwithTemplate.Controllers.Api
{
    public class ModifiersGroupsController : ApiController
    {
        private ApplicationDbContext _context = new ApplicationDbContext();

        // GET: api/ModifiersGroups
        public IQueryable<ModifiersGroup> GetModifiersGroups()
        {
            return _context.ModifiersGroups;
        }

        // GET: api/ModifiersGroups/5
        //[ResponseType(typeof(ModifiersGroup))]
        // first retruferd id is the selected item and other ids is modifiers
        public ItemsAndGroupCount GetModifiersGroup(int id)
        {
            List<int> itemsIds = new List<int>();
            List<int> modifierGroupIds = new List<int>();
            itemsIds.Add(id);

            var item = _context.EldahanItems.FirstOrDefault(i => i.Id == id);
            var itemsModifiers = _context.ItemsModifiers.ToList();
            var modifierGroupId = 0;
            foreach (var itemsModifier in itemsModifiers)
            {
                if (item != null && itemsModifier.EldahanItemsId == item.Id)
                {
                    modifierGroupIds.Add(itemsModifier.ModifiersGroupId);
                }
            }
           
            var modifiers = _context.Modifiers
                .Where(t => modifierGroupIds.Contains(t.ModifiersGroupId)).ToList();

            foreach (var modifier in modifiers)
            {
                itemsIds.Add(modifier.EldahanItemsId);
            }

            var items =_context.EldahanItems
                .Where(t => itemsIds.Contains(t.Id)).ToList();

            var itemsAndGroup = new ItemsAndGroupCount(items , modifierGroupIds.Count());
            return itemsAndGroup;
        }

        // PUT: api/ModifiersGroups/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutModifiersGroup(int id, ModifiersGroup modifiersGroup)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != modifiersGroup.Id)
            {
                return BadRequest();
            }

            _context.Entry(modifiersGroup).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ModifiersGroupExists(id))
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

        // POST: api/ModifiersGroups
        [ResponseType(typeof(ModifiersGroup))]
        public IHttpActionResult PostModifiersGroup(ModifiersGroup modifiersGroup)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.ModifiersGroups.Add(modifiersGroup);
            _context.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = modifiersGroup.Id }, modifiersGroup);
        }

        // DELETE: api/ModifiersGroups/5
        [ResponseType(typeof(ModifiersGroup))]
        public IHttpActionResult DeleteModifiersGroup(int id)
        {
            ModifiersGroup modifiersGroup = _context.ModifiersGroups.Find(id);
            if (modifiersGroup == null)
            {
                return NotFound();
            }

            _context.ModifiersGroups.Remove(modifiersGroup);
            _context.SaveChanges();

            return Ok(modifiersGroup);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ModifiersGroupExists(int id)
        {
            return _context.ModifiersGroups.Count(e => e.Id == id) > 0;
        }
    }
}