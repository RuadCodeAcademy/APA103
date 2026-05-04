using Microsoft.AspNetCore.Mvc;

namespace _25_MVC_Intro
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            //return Content("APA 103");

            //var student = new JsonResult(new {id  = 1, name ="ali", surname = "Quliyev"});

            //return student;

            return View();
        }

        public IActionResult Detail(int? id)
        {
            if (id is null || id < 1)
            {
                return RedirectToAction("Error");
            }

            return RedirectToAction("index", "Product");
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
