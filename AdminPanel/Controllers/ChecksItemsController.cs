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
    public class ChecksItemsController : Controller
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        // GET: ChecksItems
        public ActionResult Index()
        {
            var checksItems = _context.ChecksItems.Include(c => c.Item);
            return View(checksItems.ToList());
        }

        // GET: ChecksItems/Details/5
        public ActionResult Details(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChecksItem checksItem = _context.ChecksItems.Find(id);
            if (checksItem == null)
            {
                return HttpNotFound();
            }
            return View(checksItem);
        }

        // GET: ChecksItems/Create
        public ActionResult Create()
        {
            ViewBag.ItemId = new SelectList(_context.Items, "Id", "Code");
            return View();
        }

        // POST: ChecksItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Check_ID,Serial,ItemId,QTY,UnitPrice,TotalPrice,DicountValue,Tax_Value,Adj_Value,NetPrice,Fired,Fired_Time,Voided,Voided_Time,Voided_Reason,P_On_Check,Complement,Status,IsModifier,Ref_Mod_Item,IsAssimbly,Ref_Ass_Item,Taxable,NoServiceCharge,Num_Fired,Num_Print,Server_ID,P_On_Report,Check_ID_Combine,Round_Check_Fired,Void_Effect_Invn,Promo_ID,Orig_Price,Officer,Comp_Reason_ID,End_Serial_Count,Discount_ID,Disc_Reason_ID,Hold,Hold_Time,Voided_By,Comp_By,Disc_By,Preparation_Time,Disc_Reason_Comment,Comp_Reason_Comment,Void_Reason_Comment,ModifierGroup_ID,Pick_Follow_Item_Qty,Modifier_Pick,Pre_Paid_Card")] ChecksItem checksItem)
        {
            if (ModelState.IsValid)
            {
                _context.ChecksItems.Add(checksItem);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.ItemId = new SelectList(_context.Items, "Id", "Code", checksItem.ItemId);
            return View(checksItem);
        }

        // GET: ChecksItems/Edit/5
        public ActionResult Edit(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChecksItem checksItem = _context.ChecksItems.Find(id);
            if (checksItem == null)
            {
                return HttpNotFound();
            }
            ViewBag.ItemId = new SelectList(_context.Items, "Id", "Code", checksItem.ItemId);
            return View(checksItem);
        }

        // POST: ChecksItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Check_ID,Serial,ItemId,QTY,UnitPrice,TotalPrice,DicountValue,Tax_Value,Adj_Value,NetPrice,Fired,Fired_Time,Voided,Voided_Time,Voided_Reason,P_On_Check,Complement,Status,IsModifier,Ref_Mod_Item,IsAssimbly,Ref_Ass_Item,Taxable,NoServiceCharge,Num_Fired,Num_Print,Server_ID,P_On_Report,Check_ID_Combine,Round_Check_Fired,Void_Effect_Invn,Promo_ID,Orig_Price,Officer,Comp_Reason_ID,End_Serial_Count,Discount_ID,Disc_Reason_ID,Hold,Hold_Time,Voided_By,Comp_By,Disc_By,Preparation_Time,Disc_Reason_Comment,Comp_Reason_Comment,Void_Reason_Comment,ModifierGroup_ID,Pick_Follow_Item_Qty,Modifier_Pick,Pre_Paid_Card")] ChecksItem checksItem)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(checksItem).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.ItemId = new SelectList(_context.Items, "Id", "Code", checksItem.ItemId);
            return View(checksItem);
        }

        // GET: ChecksItems/Delete/5
        public ActionResult Delete(long? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChecksItem checksItem = _context.ChecksItems.Find(id);
            if (checksItem == null)
            {
                return HttpNotFound();
            }
            return View(checksItem);
        }

        // POST: ChecksItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(long id)
        {
            ChecksItem checksItem = _context.ChecksItems.Find(id);
            _context.ChecksItems.Remove(checksItem);
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
