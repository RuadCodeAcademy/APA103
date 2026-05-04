using Microsoft.AspNetCore.Mvc;

namespace _25_MVC_Intro
{
    public class ProductController : Controller
    {
        public IActionResult index()
        {
            return View();
        }
    }
}
