using FindJobOnWeb.Model.Entities;
using FindJobOnWeb.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindJobOnWeb.Areas.Administrator.Controllers
{
    public class RegisterCpController : Controller
    {
        private readonly ICompanyService _service;
        public RegisterCpController(ICompanyService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Add([FromBody] Company company)
        {
            _service.InsertCompany(company);
            return Json(company);
        }

        public JsonResult GetMaxCompanyId()
        {
            using (var context = new JobOnWebContext())
            {
                var maxCompanyId = context.Companies.Max(c => c.Id);
                var company = context.Companies.FirstOrDefault(c => c.Id == maxCompanyId);
                return Json(company);
            }
        }
    }
}
