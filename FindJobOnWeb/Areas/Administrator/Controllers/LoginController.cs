using FindJobOnWeb.Model.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindJobOnWeb.Areas.Administrator.Controllers
{
    public class LoginController : Controller
    {
      
        private readonly JobOnWebContext _context;
        public LoginController(JobOnWebContext context) 
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string email, string password)
        {
            var user = _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);
            if (user != null)
            {
                return Json(new { success = true });
            }
            else
            {
                return Json(new { success = false });
            }

        }
        [HttpPost]
        public IActionResult LoginCp(string email, string password)
        {
            var company = _context.Companies.FirstOrDefault(c => c.Email == email && c.Password == password);
            if (company != null)
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
