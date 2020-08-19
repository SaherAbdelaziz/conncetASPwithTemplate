using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using AdminPanel.Models;

namespace AdminPanel.Controllers
{
    public class OrdersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Orders
        public ActionResult Index()
        {
            var orders = db.Orders
                .Include(o => o.Cart).Include(o => o.User);
            return View(orders.ToList());
        }

        // GET: Orders/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // GET: Orders/Create
        public ActionResult Create()
        {
            ViewBag.CartId = new SelectList(db.Carts, "Id", "ApplicationUserId");
            ViewBag.HdAreasId = new SelectList(db.HdAreas, "Id", "Code");
            ViewBag.OutLetId = new SelectList(db.OutLets, "Id", "Code");
            return View();
        }

        // POST: Orders/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,CustomerName,CustomerPhone,CustomerAddress1,CustomerAddress2,CustomerStreet,CustomerBuilding,CustomerFloor,CustomerApartment,CustomerSpecialMark,DateCreated,Price,Delivery,TotalPrice,OutLetId,HdAreasId,ServicesId,CartId,DeliveryTimeIndex,Details,OrderState,OrderPrepare")] Order order)
        {
            if (ModelState.IsValid)
            {
                db.Orders.Add(order);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.CartId = new SelectList(db.Carts, "Id", "ApplicationUserId", order.CartId);
            //ViewBag.HdAreasId = new SelectList(db.HdAreas, "Id", "Code", order.HdAreasId);
            //ViewBag.OutLetId = new SelectList(db.OutLets, "Id", "Code", order.OutLetId);
            return View(order);
        }

        // GET: Orders/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            ViewBag.CartId = new SelectList(db.Carts, "Id", "ApplicationUserId", order.CartId);

            ViewBag.HdAreasId = new SelectList(db.HdAreas, "Id", "Code", order.User.AreaId);
            ViewBag.OutLetId = new SelectList(db.OutLets, "Id", "Code", order.User.OutletId);
            return View(order);
        }

        // POST: Orders/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,CustomerName,CustomerPhone,CustomerAddress1,CustomerAddress2,CustomerStreet,CustomerBuilding,CustomerFloor,CustomerApartment,CustomerSpecialMark,DateCreated,Price,Delivery,TotalPrice,OutLetId,HdAreasId,ServicesId,CartId,DeliveryTimeIndex,Details,OrderState,OrderPrepare")] Order order)
        {
            //var tmpOrder = db.Orders.SingleOrDefault(o=>o.Id==order.Id);
            //order.CartId = tmpOrder.CartId;
            //order.OrderState = tmpOrder.OrderState;
            //order.OrderPrepare = order.OrderPrepare;
                if (ModelState.IsValid)
            {
                db.Entry(order).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index" , "Home");
            }
            ViewBag.CartId = new SelectList(db.Carts, "Id", "ApplicationUserId", order.CartId);
            ViewBag.HdAreasId = new SelectList(db.HdAreas, "Id", "Code", order.User.AreaId);
            ViewBag.OutLetId = new SelectList(db.OutLets, "Id", "Code", order.User.OutletId);
            return View(order);
        }


        
        // POST: Orders/EditItems/5
        //public ActionResult EditItems(int id)
        //{
        //    var model = new ItemOrderModelCheckList(id, GetItems(id));

        //    return View(model);
        //}

        //[HttpPost]
        //public ActionResult EditItems(ItemOrderModelCheckList model , int myId)
        //{

        //    if (ModelState.IsValid)
        //    {
        //        var selectedItemsIds = string.Join(",", model.SelectedItems);
        //        //List<double?> prices=new List<double?>();
        //        double? prices = 0;
        //        List<string> Names=new List<string>();
        //        List<int> q=new List<int>();

        //        foreach (var i in model.SelectedItems)
        //        {

        //            var id = int.Parse(i);
        //            var item = db.Items
        //                .SingleOrDefault(e => e.Id == id);

        //            Names.Add(item.Name2);
        //            //q.Add(i);
        //            prices+=item.StaticPrice;
        //        }
        //        //update order based on new selected items
        //        var order = db.Orders.SingleOrDefault(o => o.Id == myId);
        //        var n = string.Join(" @ ", Names);
        //        //var p = string.Join("/n", Names);

        //        order.Details = n;
        //        order.Price = (double) prices;
        //        order.TotalPrice = (double) prices + order.Delivery;
        //        db.SaveChanges();

        //        //model.OrderId
        //        //var items = db.Item
        //        //    .Where(e => model.SelectedItems.ToList().Contains(e));

        //        // Save data to database, and redirect to Success page.

        //        return RedirectToAction("Index" , "Home");
        //    }
        //    model.AvailableItem = GetItems(myId);
        //    return View(model);
        //}


        //private IList<SelectListItem> GetItems(int id)
        //{
        //    var item = db.OrderedItems
        //        .Where(od => od.OrderId == id)
        //        .Include(od => od.Item)
        //        .ToList();

        //    List<SelectListItem> model = new List<SelectListItem>();
        //    foreach (var i in item)
        //    {
        //        var x = new SelectListItem
        //            { Text = i.Item.Name2, Value = i.Item.Id.ToString(), Selected = true};
        //        model.Insert(0 , x);
        //    }
        //    // i.Quantity+"x"+
        //    return model;
        //}


        // GET: Orders/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Order order = db.Orders.Find(id);
            if (order == null)
            {
                return HttpNotFound();
            }
            return View(order);
        }

        // POST: Orders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Order order = db.Orders.Find(id);
            db.Orders.Remove(order);
            db.SaveChanges();
            return RedirectToAction("Index");
        }




        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }



    }
}
