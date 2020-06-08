using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using conncetASPwithTemplate.Models;

namespace conncetASPwithTemplate.Controllers
{
    [Authorize]
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
            return View(items);
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

        public ActionResult checkout()
        {
            return View();
        }


        
    }
}