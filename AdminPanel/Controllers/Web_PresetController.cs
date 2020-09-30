using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AdminPanel.Models;

namespace AdminPanel.Controllers
{
    public class Web_PresetController : Controller
    {
        private ApplicationDbContext _context = new ApplicationDbContext();

        // GET: Web_Preset
        public ActionResult Index()
        {
            return View(_context.WebPresets.ToList());
        }

        // GET: Web_Preset/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Web_Preset web_Preset = _context.WebPresets.Find(id);
            if (web_Preset == null)
            {
                return HttpNotFound();
            }
            return View(web_Preset);
        }

        // GET: Web_Preset/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Web_Preset/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Code,Name,Name2,Description,ImagePreset,Active,CreateDate,ModifiedDate,UserId,RestIdActive,OutLetIdActive,ByTime,StartTime,EndTime")] Web_Preset web_Preset)
        {
            if (ModelState.IsValid)
            {
                _context.WebPresets.Add(web_Preset);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(web_Preset);
        }

        // GET: Web_Preset/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Web_Preset web_Preset = _context.WebPresets.Find(id);
            if (web_Preset == null)
            {
                return HttpNotFound();
            }
            return View(web_Preset);
        }

        // POST: Web_Preset/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Code,Name,Name2,Description,ImagePreset,Active,CreateDate,ModifiedDate,UserId,RestIdActive,OutLetIdActive,ByTime,StartTime,EndTime")] Web_Preset web_Preset)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(web_Preset).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(web_Preset);
        }

        // GET: Web_Preset/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Web_Preset web_Preset = _context.WebPresets.Find(id);
            if (web_Preset == null)
            {
                return HttpNotFound();
            }
            return View(web_Preset);
        }

        // POST: Web_Preset/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Web_Preset web_Preset = _context.WebPresets.Find(id);
            _context.WebPresets.Remove(web_Preset);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
