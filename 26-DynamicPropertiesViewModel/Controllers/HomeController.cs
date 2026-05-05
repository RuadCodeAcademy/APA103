using _26_DynamicPropertiesViewModel.Models;
using _26_DynamicPropertiesViewModel.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace _26_DynamicPropertiesViewModel.Controllers
{
    public class HomeController :Controller
    {

        List<Student> students = new List<Student>
        {
            new Student{Id =1, Name = "Ruad", Age = 19},
            new Student{Id =2, Name = "Aysu", Age = 19},
            new Student{Id =5, Name = "Gunel", Age = 19},
        };

        List<Teacher> teachers = new List<Teacher>
        {
            new Teacher{Id = 1, Name = "Ali", Salary = 500},
            new Teacher{Id = 2, Name = "Ruad", Salary = 4500},
        };
        public IActionResult Index()
        {
            //ViewBag.Students = students;

            //ViewData["Students"] = students;

            //TempData["name"] = "Ruslan";

            HomeVM homeVM = new()
            {
                Teachers = teachers,
                Students = students
            };

            return View(homeVM);  
        }

        public IActionResult Details()
        {
            return View();
        }


        [Route("korporativ-satislar")]
        public IActionResult CorporativeSales()
        {
            return View();
        }
    }
}
