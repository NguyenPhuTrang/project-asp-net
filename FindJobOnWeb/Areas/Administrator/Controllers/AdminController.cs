using FindJobOnWeb.Model.Entities;
using FindJobOnWeb.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindJobOnWeb.Areas.Administrator.Controllers
{
    public class AdminController : Controller
    {
        private readonly ICompanyService _service;
        public AdminController(ICompanyService service)
        {
            _service = service;
        }
        public IActionResult Company()
        {
            return View();
        }
        public JsonResult List()
        {
            IEnumerable<Company> companies = _service.GetAllCompany();
            return Json(companies);

        }
        public JsonResult GetById(int id)
        {
            Company company = _service.GetCompany(id);
            return Json(company);
        }
        public JsonResult Delete(int id)
        {
            _service.DeleteCompany(id);
            return Json(id);
        }
          public IActionResult Users()
        {
            return View();
        }
        public IActionResult Profles()
        {
            return View();
        }
        public IActionResult FeedBack()
        {
            return View();
        }
    }
}
