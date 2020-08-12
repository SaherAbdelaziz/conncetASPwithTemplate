﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminPanel.Models;
using System.Data.Entity;
using AdminPanel.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
namespace AdminPanel.Controllers
{
    [Authorize(Roles = "Manger")]
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;


        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            var orders = _context.Orders
                .Include(o => o.User)
                .Include(o => o.User.Outlet)
                .Include(o => o.User.Area)
                .ToList();

            var cartItems = _context.MyCartItems
                .Include(c => c.EldahanItem)
                .ToList();

            var checkItems = _context.ChecksItems.ToList();

            //var checkItems = from ch in _context.ChecksItems
            //    join item in _context.EldahanItems on ch.Item_ID equals item.Id
            //    select new { ch.Item_ID, item.Name };

            var ordersViewModelViewModel = new OrdersViewModel()
            {
                MyCartItems = cartItems,
                Orders = orders,
                ChecksItems = checkItems,
            };

            return View("Tables", ordersViewModelViewModel);

            //var orderedItems = _context.OrderedItems
            //    .Include(e => e.Order)
            //    .Include(e => e.Order.OutLet)
            //    .Include(e => e.Order.HdAreas)
            //    .Include(e => e.Item)
            //    .ToList();



            //return View("Tables" , orderedItems);

        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Tables()
        {


            var orders = _context.Orders
                .Include(o => o.User)
                .Include(o => o.User.Outlet)
                .Include(o => o.User.Area)
                .ToList();


            var cartItems = _context.MyCartItems
                .Include(c => c.EldahanItem)
                .ToList();

            var checkItems = _context.ChecksItems.ToList();


            var ordersViewModelViewModel = new OrdersViewModel()
            {
                MyCartItems = cartItems,
                Orders = orders,
                ChecksItems = checkItems,
            };

            return View(ordersViewModelViewModel);


            //var orderedItems = _context.OrderedItems
            //    .Include(e => e.Order)
            //    .Include(e => e.Order.OutLet)
            //    .Include(e => e.Order.HdAreas)
            //    .Include(e => e.Item)
            //    .ToList();

            //return View(orderedItems);


        }

        public ActionResult Items()
        {
            var items = _context.EldahanItems
                .Include(i=>i.EldahanPreset).ToList();

            return View(items);
        }
        

        public ActionResult test()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetDefault(int val)
        {

            var data = _context.HdAreasServices
                .Where(id => id.AreaId == val).Select(hd => hd.OutLet).ToList();
            return Json(new { success = true, message = "Hello world", outlets = data });

            //if (val != null)
            //{
            //    var data = _context.OutLets.ToList();
            //    return Json(new {Success = "true", Data = data});
            //}
            //return Json(new { Success = "false" });
        }

        
    }
}