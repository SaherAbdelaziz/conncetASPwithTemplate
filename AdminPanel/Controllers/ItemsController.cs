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
    public class ItemsController : Controller
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        // GET: Items
        public ActionResult Index()
        {
            var items = _context.Items.Include(i => i.WebPreset);
            return View(items.ToList());
        }

        // GET: Items/Details/5
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

        // GET: Items/Create
        public ActionResult Create()
        {
            ViewBag.WebPresetId = new SelectList(_context.WebPresets, "Id", "Code");
            return View();
        }

        // POST: Items/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Code,Name,Name2,BarCode,CrossCode,Taxable,Assimbly,WebPresetId,IsModifier,StandAlone,PrintOnChick,PrintOnReport,FollowItem,Image_Item,BackColor,fontColor,Cost,OpenPrice,StaticPrice,Description1,Description2,Description3,Description4,ModPrice_0,ItemFont,UseItemTimer,ItemTimerValue,Active,CreateDate,ModifiedDate,User_ID,NoServiceCharge,Market_Price,Item_Track,PrintItemOnCheck,IsParent,Rest_ID_Active,Open_Food,Mod_Price,Pre_Paid_Card,WebOrder,Listed,Available")] Item item)
        {
            if (ModelState.IsValid)
            {
                _context.Items.Add(item);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.WebPresetId = new SelectList(_context.WebPresets, "Id", "Code", item.WebPresetId);
            return View(item);
        }

        // GET: Items/Edit/5
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
            ViewBag.WebPresetId = new SelectList(_context.WebPresets, "Id", "Name", item.WebPresetId);
            return View(item);
        }

        // POST: Items/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Code,Name,Name2,BarCode,CrossCode,Taxable,Assimbly,WebPresetId,IsModifier,StandAlone,PrintOnChick,PrintOnReport,FollowItem,Image_Item,BackColor,fontColor,Cost,OpenPrice,StaticPrice,Description1,Description2,Description3,Description4,ModPrice_0,ItemFont,UseItemTimer,ItemTimerValue,Active,CreateDate,ModifiedDate,User_ID,NoServiceCharge,Market_Price,Item_Track,PrintItemOnCheck,IsParent,Rest_ID_Active,Open_Food,Mod_Price,Pre_Paid_Card,WebOrder,Listed,Available")] Item item)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(item).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.WebPresetId = new SelectList(_context.WebPresets, "Id", "Code", item.WebPresetId);
            return View(item);
        }

        // GET: Items/Delete/5
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

        // POST: Items/Delete/5
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
