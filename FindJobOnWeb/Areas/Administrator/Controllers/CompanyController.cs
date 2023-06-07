using FindJobOnWeb.Model.Entities;
using FindJobOnWeb.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindJobOnWeb.Areas.Administrator.Controllers
{
    public class CompanyController : Controller
    {
        private readonly ICompanyService _service;
        public CompanyController(ICompanyService service)
        {
            _service = service;
        }
        public IActionResult Index()
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
    }
}
