using FindJobOnWeb.Model.Entities;
using FindJobOnWeb.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindJobOnWeb.Areas.Administrator.Controllers
{
    public class FindJobController : Controller
    {
        private readonly IJobPostService _service;
        public FindJobController(IJobPostService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View();
        }
        public JsonResult List()
        {
            IEnumerable<JobPost> jobPosts = _service.GetAllJobPost();
            return Json(jobPosts);

        }
    }
}
