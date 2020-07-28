using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AdminPanel.Models;
using AdminPanel.ViewModels;

namespace AdminPanel.Controllers
{
    public class EldahanItemsController : Controller
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        // GET: EldahanItems
        public ActionResult Index()
        {
            var eldahanItems = _context.EldahanItems.Include(e => e.EldahanPreset);
            return View(eldahanItems.ToList());
        }

        // GET: EldahanItems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EldahanItems eldahanItems = _context.EldahanItems.Find(id);
            if (eldahanItems == null)
            {
                return HttpNotFound();
            }
            return View(eldahanItems);
        }

        // GET: EldahanItems/Create
        public ActionResult Create()
        {
            ViewBag.EldahanPresetId = new SelectList(_context.EldahanPresets, "Id", "Name");
            return View();
        }

        // POST: EldahanItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ItemViewModel model)
        {

            if (!ModelState.IsValid)
            {
                ViewBag.EldahanPresetId = new SelectList(_context.EldahanPresets, "Id", "Name", model.EldahanPresetId);

                return View(model);
            }

            var item = new EldahanItems(model);
            _context.EldahanItems.Add(item);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: EldahanItems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            EldahanItems eldahanItem = _context.EldahanItems.Find(id);
            if (eldahanItem == null)
            {
                return HttpNotFound();
            }


            ViewBag.EldahanPresetId = new SelectList(_context.EldahanPresets, "Id", "Name", eldahanItem.EldahanPresetId);
            var viewModel = new ItemViewModel(eldahanItem);

            return View(viewModel);
        }

        // POST: EldahanItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ItemViewModel model)
        {
            if (!ModelState.IsValid)
            {

                ViewBag.EldahanPresetId = new SelectList(_context.EldahanPresets, "Id", "Name", model.EldahanPresetId);
                return View(model);
                
            }

            var eldahanItem = _context.EldahanItems.SingleOrDefault(e => e.Id == model.Id);
            eldahanItem.Update(model);

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: EldahanItems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EldahanItems eldahanItems = _context.EldahanItems.Find(id);
            if (eldahanItems == null)
            {
                return HttpNotFound();
            }
            return View(eldahanItems);
        }

        // POST: EldahanItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EldahanItems eldahanItems = _context.EldahanItems.Find(id);
            _context.EldahanItems.Remove(eldahanItems);
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
