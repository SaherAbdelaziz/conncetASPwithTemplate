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
    public class Web_PresetController : ApiController
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        // GET: api/Web_Preset
        public IQueryable<Web_Preset> GetWebPresets()
        {
            return _context.WebPresets;
        }

        // GET: api/Web_Preset/5
        [ResponseType(typeof(Web_Preset))]
        public IHttpActionResult GetWeb_Preset(int id)
        {
            Web_Preset web_Preset = _context.WebPresets.Find(id);
            if (web_Preset == null)
            {
                return NotFound();
            }

            return Ok(web_Preset);
        }

        // PUT: api/Web_Preset/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutWeb_Preset(int id, Web_Preset web_Preset)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != web_Preset.Id)
            {
                return BadRequest();
            }

            _context.Entry(web_Preset).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!Web_PresetExists(id))
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

        // POST: api/Web_Preset
        [ResponseType(typeof(Web_Preset))]
        public IHttpActionResult PostWeb_Preset(Web_Preset web_Preset)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.WebPresets.Add(web_Preset);
            _context.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = web_Preset.Id }, web_Preset);
        }

        // DELETE: api/Web_Preset/5
        [ResponseType(typeof(Web_Preset))]
        public IHttpActionResult DeleteWeb_Preset(int id)
        {
            Web_Preset web_Preset = _context.WebPresets.Find(id);
            if (web_Preset == null)
            {
                return NotFound();
            }

            _context.WebPresets.Remove(web_Preset);
            _context.SaveChanges();

            return Ok(web_Preset);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool Web_PresetExists(int id)
        {
            return _context.WebPresets.Count(e => e.Id == id) > 0;
        }
    }
}