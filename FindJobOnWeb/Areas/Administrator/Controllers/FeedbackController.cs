using FindJobOnWeb.Model.Entities;
using FindJobOnWeb.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindJobOnWeb.Areas.Administrator.Controllers
{
    public class FeedbackController : Controller
    {
        private readonly IFeedbackService _service;
        public FeedbackController(IFeedbackService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Add([FromBody] Feedback feedback)
        {
            _service.InsertFeedback(feedback);
            return Json(feedback);
        }
         public JsonResult GetMaxFeedbackId()
        {
            using (var context = new JobOnWebContext())
            {
                var maxFeedbackId = context.Feedbacks.Max(f => f.Id);
                var Feedback = context.Feedbacks.FirstOrDefault(f => f.Id == maxFeedbackId);
                return Json(Feedback);
            }
        }
        public JsonResult List()
        {
            IEnumerable<Feedback> feedbacks = _service.GetAllFeedback();
            return Json(feedbacks);

        }
        public JsonResult GetById(int id)
        {
            Feedback feedback = _service.GetFeedback(id);
            return Json(feedback);
        }
        public JsonResult Delete(int id)
        {
            _service.DeleteFeedback(id);
            return Json(id);
        }
    }
}
