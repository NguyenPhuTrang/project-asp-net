using FindJobOnWeb.Model.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindJobOnWeb.Areas.Administrator.Controllers
{
    public class LoginAdController : Controller
    {
        private readonly JobOnWebContext _context;
        public LoginAdController(JobOnWebContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginAd(string email, string password)
        {
            var admin = _context.Admins.FirstOrDefault(a => a.Email == email && a.Password == password);
            if (admin != null)
            {
                return Json(new { success = true });
            }
            else
            {
                return Json(new { success = false });
            }

        }
    }
}

