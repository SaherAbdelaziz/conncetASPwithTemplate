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
    public class ItemsController : Controller
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        // GET: Item
        public ActionResult Index()
        {
            var eldahanItems = _context.Items.Include(e => e.WebPreset);
            return View(eldahanItems.ToList());
        }

        // GET: Item/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = _context.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // GET: Item/Create
        public ActionResult Create()
        {
            ViewBag.EldahanPresetId = new SelectList(_context.WebPresets, "Id", "Name");
            return View();
        }

        // POST: Item/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(ItemViewModel model)
        {

            if (!ModelState.IsValid)
            {
                ViewBag.EldahanPresetId = new SelectList(_context.WebPresets, "Id", "Name", model.EldahanPresetId);

                return View(model);
            }

            var item = new Item(model);
            _context.Items.Add(item);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }

        // GET: Item/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            Item item = _context.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }


            ViewBag.EldahanPresetId = new SelectList(_context.WebPresets, "Id", "Name", item.WebPresetId);
            var viewModel = new ItemViewModel(item);

            return View(viewModel);
        }

        // POST: Item/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(ItemViewModel model)
        {
            if (!ModelState.IsValid)
            {

                ViewBag.EldahanPresetId = new SelectList(_context.WebPresets, "Id", "Name", model.EldahanPresetId);
                return View(model);
                
            }

            var eldahanItem = _context.Items.SingleOrDefault(e => e.Id == model.Id);
            eldahanItem.Update(model);

            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        // GET: Item/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = _context.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: Item/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Item item = _context.Items.Find(id);
            _context.Items.Remove(item);
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
