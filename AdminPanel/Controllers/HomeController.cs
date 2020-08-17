﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web.Mvc;
using AdminPanel.Models;
using System.Data.Entity;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using AdminPanel.ViewModels;
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

            var cartItems = _context.CartItems
                .Include(c => c.Item)
                .ToList();

            var checkItems = _context.ChecksItems.ToList();

            //var checkItems = from ch in _context.ChecksItems
            //    join item in _context.Item on ch.Item_ID equals item.Id
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

        public ActionResult SendMail()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SendMail(EmailFormModel model)
        {
            if (ModelState.IsValid)
            {
                var body = "<p>Email From: {0} ({1})</p><p>Message:</p><p>{2}</p>";
                var message = new MailMessage();
                message.To.Add(new MailAddress(model.FromEmail));  // replace with valid value 
                message.From = new MailAddress("advbtech2000@gmail.com");  // replace with valid value
                message.Subject = "Your email subject";
                message.Body = string.Format(body, model.FromName, model.FromEmail, model.Message);
                message.IsBodyHtml = true;

                using (var smtp = new SmtpClient())
                {
                    smtp.UseDefaultCredentials = false;
                    var credential = new NetworkCredential
                    {
                        UserName = "advbtech2000@gmail.com",  // replace with valid value
                        Password = "ABTech123456"  // replace with valid value
                    };
                    smtp.Credentials = credential;
                    smtp.Host = "smtp.gmail.com";
                    smtp.Port = 587;
                    smtp.EnableSsl = true;
                    

                    await smtp.SendMailAsync(message);
                    return RedirectToAction("Sent");
                }
            }
            return View(model);
        }

        public ActionResult Sent()
        {
            return View();
        }

        public class EmailFormModel
        {
            [Required, Display(Name = "Your name")]
            public string FromName { get; set; }
            [Required, Display(Name = "Your email"), EmailAddress]
            public string FromEmail { get; set; }
            [Required]
            public string Message { get; set; }
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


            var cartItems = _context.CartItems
                .Include(c => c.Item)
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
            var items = _context.Items
                .Include(i=>i.WebPreset).ToList();

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