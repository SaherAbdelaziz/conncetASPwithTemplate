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
    public class OrderssController : Controller
    {
        private readonly ApplicationDbContext _context = new ApplicationDbContext();

        // GET: Orderss
        public ActionResult Index()
        {
            var orders = _context.Orders
                .Include(o => o.Admin)
                .Include(o => o.Cart)
                .Include(o => o.Check)
                .Include(o => o.User);
            return View(orders.ToList());
        }

        // GET: Orderss/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = _context.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // GET: Orderss/Create
        public ActionResult Create()
        {
            ViewBag.AdminId = new SelectList(_context.Users, "Id", "Name");
            ViewBag.CartId = new SelectList(_context.Carts, "Id", "ApplicationUserId");
            ViewBag.CheckId = new SelectList(_context.Checks, "ID", "CheckTitel");
            ViewBag.UserId = new SelectList(_context.Users, "Id", "Name");
            return View();
        }

        // POST: Orderss/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,UserId,AdminId,CheckId,DateCreated,Price,Delivery,TotalPrice,CartId,DeliveryTimeIndex,DeliveryTypeIndex,Details,OrderState,OrderPrepare")] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Orders.Add(order);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.AdminId = new SelectList(_context.Users, "Id", "Name", order.AdminId);
            ViewBag.CartId = new SelectList(_context.Carts, "Id", "ApplicationUserId", order.CartId);
            ViewBag.CheckId = new SelectList(_context.Checks, "ID", "CheckTitel", order.CheckId);
            ViewBag.UserId = new SelectList(_context.Users, "Id", "Name", order.UserId);
            return View(order);
        }

        // GET: Orderss/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = _context.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            ViewBag.AdminId = new SelectList(_context.Users, "Id", "Name", order.AdminId);
            ViewBag.CartId = new SelectList(_context.Carts, "Id", "ApplicationUserId", order.CartId);
            ViewBag.CheckId = new SelectList(_context.Checks, "ID", "CheckTitel", order.CheckId);
            ViewBag.UserId = new SelectList(_context.Users, "Id", "Name", order.UserId);
            return View(order);
        }

        // POST: Orderss/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,UserId,AdminId,CheckId,DateCreated,Price,Delivery,TotalPrice,CartId,DeliveryTimeIndex,DeliveryTypeIndex,Details,OrderState,OrderPrepare")] Order order)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(order).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.AdminId = new SelectList(_context.Users, "Id", "Name", order.AdminId);
            ViewBag.CartId = new SelectList(_context.Carts, "Id", "ApplicationUserId", order.CartId);
            ViewBag.CheckId = new SelectList(_context.Checks, "ID", "CheckTitel", order.CheckId);
            ViewBag.UserId = new SelectList(_context.Users, "Id", "Name", order.UserId);
            return View(order);
        }

        // GET: Orderss/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = _context.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: Orderss/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Order order = _context.Orders.Find(id);
            _context.Orders.Remove(order);
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
