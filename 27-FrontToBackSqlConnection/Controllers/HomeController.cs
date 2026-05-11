using _27_FrontToBackSqlConnection.Data;
using _27_FrontToBackSqlConnection.Models;
using _27_FrontToBackSqlConnection.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _27_FrontToBackSqlConnection.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        //List<Slider> _sliders = new List<Slider>
        //{
        //    new Slider {Title = "basliq-1", Subtitle ="komekci basliq 1", Description = "gullerden qalmadi", Image = "1-1-524x617.png", Order = 3, isDeleted = false},
        //    new Slider {Title = "basliq-2", Subtitle ="komekci basliq 2", Description = "Mohtesem endirim", Image = "1-2-524x617.png", Order = 2, isDeleted = true},
        //    new Slider {Title = "basliq-3", Subtitle ="komekci basliq 3", Description = "Xirdalana manatdan", Image = "indir.jpg", Order = 1, isDeleted = false},


        //};



        public async Task<IActionResult> Index()
        {

            //_context.AddRange(_sliders);
            //_context.SaveChanges();

            List<Slider> sliders =  await _context.Sliders
                .OrderBy(s => s.Order)
                .Where(s => !s.IsDeleted)
                .Take(2)
                .ToListAsync();

            List<Product> products = await _context.Products
                .Where(p => !p.IsDeleted)
                .Include(p => p.ProductImages.Where(pi=>pi.isPrimary != null))
                .ToListAsync();

            HomeVM homeVM = new HomeVM()
            {
                sliders = sliders,
                products = products
            }; 

            return View(homeVM);
        }


    }
}
