using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdminPanel.Models;
using System.Data.Entity;
using AdminPanel.ViewModels;

namespace AdminPanel.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;


        public HomeController()
        {
            _context = new ApplicationDbContext();
        }

        public ActionResult Index()
        {
            return View();
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
                .Include(o=>o.OutLet)
                .Include(o=>o.HdAreas)
                .Include(o=>o.Services)
                .ToList();

            var cartItems = _context.CartItems
                .Include(c=>c.Item)
                .ToList();

            var selectedModifiers = _context.SelectedModifiers
                .Include(m =>m.ItemModifier)
                .ToList();


            var ordersViewModelViewModel = new OrdersViewModel()
            {
                CartItems = cartItems,
                Orders = orders,
                selectedModifiers = selectedModifiers,
            };

            return View(ordersViewModelViewModel);
        }

        public ActionResult Items()
        {
            var items = _context.Items.ToList();

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