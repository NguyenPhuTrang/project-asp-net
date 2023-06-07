using FindJobOnWeb.Model.Entities;
using FindJobOnWeb.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindJobOnWeb.Areas.Administrator.Controllers
{
    public class JobdetailsController : Controller
    {
        private readonly IJobPostService _service;
        public JobdetailsController(IJobPostService service)
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
        public JsonResult GetById(int id)
        {
            JobPost jobPost = _service.GetJobPost(id);
            return Json(jobPost);
        } 
    }
}
