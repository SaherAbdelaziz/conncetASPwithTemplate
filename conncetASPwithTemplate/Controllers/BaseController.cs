using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using conncetASPwithTemplate.Models;
using conncetASPwithTemplate.ViewModels;
namespace conncetASPwithTemplate.Controllers
{
    public class BaseController : Controller
    {
        private ApplicationDbContext _context;


        public BaseController()
        {
            _context = new ApplicationDbContext();
            var OutLetId = User.Identity.GetUserOutletId();
            var HdAreasId = User.Identity.GetUserAreaId();
            var delivery = _context.HdAreasServices
                .SingleOrDefault(h => h.AreaId == HdAreasId && h.OutLetId == OutLetId).Services;


            ViewBag.Delivery = delivery;
        }

        // GET: Base
        public void Index()
        {
            
        }
    }
}