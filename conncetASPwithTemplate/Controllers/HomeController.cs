    using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using conncetASPwithTemplate.Models;
using conncetASPwithTemplate.ViewModels;
using System.Data.Entity;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

namespace conncetASPwithTemplate.Controllers
{
    //[Authorize]
    public class HomeController : Controller
    {
        private ApplicationDbContext _context;
        public string UserId;

        public Cart Cart { get; set; }

        public HomeController()
        {
            _context = new ApplicationDbContext();
            bool logged = (System.Web.HttpContext.Current.User != null) &&
                         System.Web.HttpContext.Current.User.Identity.IsAuthenticated;

            if (logged)
            {
                ApplicationUser user = System.Web.HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>().FindById(System.Web.HttpContext.Current.User.Identity.GetUserId());
                UserId = user.Id;
                Cart = _context.Carts
                    .SingleOrDefault(c => c.ApplicationUserId == UserId);
                if (Cart == null)
                {
                    Cart = new Cart()
                    {
                        ApplicationUserId = UserId,

                    };
                    _context.Carts.Add(Cart);
                    _context.SaveChanges();
                }
            }

          
            
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
            var items = _context.EldahanItems.ToList();
            var presets = _context.EldahanPresets.ToList();
            var menuItems = _context.WebMenuItems.ToList();
            var itemsToShowCount = 10;
            ItemsCategories itemsCategories =new ItemsCategories(items , presets, menuItems , itemsToShowCount);
            //itemsCategories.Items= items.ToList();

            return View(itemsCategories);
        }

        public ActionResult ShowItems()
        {
            var items = _context.EldahanItems.ToList();

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
            var userId = User.Identity.GetUserId();
            var myUser=_context.Users
                .FirstOrDefault(u => u.Id == userId);

            var profileViewModel = new ProfileViewModel()
            {
                Name = myUser.Name,
                Email = myUser.Email,
                Phone = myUser.Phone,
                Adress = myUser.Adress,
                Adress2 = myUser.Adress2,
            };
            return View(profileViewModel);
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