using FindJobOnWeb.Model.Entities;
using FindJobOnWeb.Service;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FindJobOnWeb.Areas.Administrator.Controllers
{

    public class RegisterController : Controller
    {
        private readonly IUserService _service;
        public RegisterController(IUserService service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Add([FromBody] User user)
        {
            _service.InsertUser(user);
            return Json(user);
        }

        public JsonResult GetMaxUserId()
        {
            using (var context = new JobOnWebContext())
            {
                var maxUserId = context.Users.Max(u => u.Id);
                var user = context.Users.FirstOrDefault(u => u.Id == maxUserId);
                return Json(user);
            }
        }
        public JsonResult List()
        {
            IEnumerable<User> users = _service.GetAllUser();
            return Json(users);

        }
        public JsonResult GetById(int id)
        {
            User user = _service.GetUser(id);
            return Json(user);
        }
        public JsonResult Delete(int id)
        {
            _service.DeleteUser(id);
            return Json(id);
        }


    }
}
