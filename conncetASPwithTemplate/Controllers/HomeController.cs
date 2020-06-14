using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using conncetASPwithTemplate.Models;
using conncetASPwithTemplate.ViewModels;

namespace conncetASPwithTemplate.Controllers
{
    //[Authorize]
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

        public ActionResult IndexBurgers()
        {
            var items = _context.Items.ToList();
            return View(items);
        }

        public ActionResult IndexFullwidth()
        {
            return View();
        }

        public ActionResult IndexVideo()
        {
            return View();
        }

        public ActionResult Navigation()
        {
            var items = _context.Items.ToList();
            var subCategory = _context.SubCategories.ToList();
            var presets = _context.WebPresets.ToList();
            var menuItems = _context.WebMenuItems.ToList();
            var itemsToShowCount = 10;
            ItemsCategories itemsCategories =new ItemsCategories(items , presets, menuItems , itemsToShowCount);
            //itemsCategories.Items= items.ToList();

            return View(itemsCategories);
        }

        public ActionResult ShowItems()
        {
            var items = _context.Items.ToList();

            return View(items);
        }

        public ActionResult Offers()
        {
            return View();
        }

        public ActionResult Services()
        {
            return View();
        }

        public ActionResult Gallery()
        {
            return View();
        }

        public ActionResult Reviews()
        {
            return View();
        }

        public ActionResult FaQ()
        {
            return View();
        }

        public ActionResult Checkout()
        {
            return View();
        }

        [HttpPost]
        public ActionResult GetDefault(int val)
        {

            var data = _context.HdAreasServices
                .Where(id => id.AreaId==val).Select(hd => hd.OutLet).ToList();
            return Json(new { success = true, message = "Hello world" , outlets= data });

            //if (val != null)
            //{
            //    var data = _context.OutLets.ToList();
            //    return Json(new {Success = "true", Data = data});
            //}
            //return Json(new { Success = "false" });
        }

    }
}