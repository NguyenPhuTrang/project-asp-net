using FindJobOnWeb.Model.Entities;
using FindJobOnWeb.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindJobOnWeb.Areas.Administrator.Controllers
{
    public class JobPostController : Controller
    {
        private readonly IJobPostService _service;
        public JobPostController(IJobPostService service)
        {
            _service = service;
        }
        
        //public IActionResult Index()
        //{
        //    return View();
        //}
        public JsonResult List()
        {
            IEnumerable<JobPost> jobPosts = _service.GetAllJobPost();
            return Json(jobPosts);
        }
        [HttpPost]
        public JsonResult Add([FromBody] JobPost jobPost)
        {
            _service.InsertJobPost(jobPost);
            return Json(jobPost);
        }
        [HttpPost]
        public JsonResult Update([FromBody] JobPost jobPost)
        {
            _service.UpdateJobPost(jobPost);
            return Json(jobPost);
        }
        public JsonResult GetById(int id)
        {
            JobPost jobPost = _service.GetJobPost(id);
            return Json(jobPost);
        }
        public JsonResult Delete(int id)
        {
            _service.DeleteJobPost(id);
            return Json(id);
        }
        private readonly JobOnWebContext _dbContext;
        public JobPostController(JobOnWebContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Search(string searchTerm)
        {
            // Tìm kiếm các sản phẩm dựa trên giá trị searchTerm
            var products = _dbContext.JobPosts
                .Where(p => p.JobTypeName.Contains(searchTerm))
                .ToList();

            return View(products);
        }
    }
}

