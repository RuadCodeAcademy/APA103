using _27_FrontToBackSqlConnection.Data;
using _27_FrontToBackSqlConnection.Models;
using _27_FrontToBackSqlConnection.Utilities.Enums;
using _27_FrontToBackSqlConnection.Utilities.Extension;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _27_FrontToBackSqlConnection.Areas.AdminPanel.Controllers
{
    [Area("AdminPanel")]
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> sliders = await _context.Sliders.Where(s=>!s.IsDeleted).ToListAsync();

            return View(sliders);
        }

        public IActionResult Create()
        {
            return View();
        }

       

        [HttpPost]

        public async Task<IActionResult> Create(Slider slider)
        {
            if (slider.Photo == null)
            {
                ModelState.AddModelError("Photo", "Zəhmət olmasa şəkil seçin!");
                return View(slider);
            }

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (!slider.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError(nameof(Slider.Photo), "File type is incorrect!");
                return View();
            }

            if (!slider.Photo.CheckFileSize(FileSize.MB,2))
            {
                ModelState.AddModelError(nameof(Slider.Photo), "File size must be less than 2mb!");
                return View();
            }

            string imageUrl = await slider.Photo.CreateFile(_env.WebRootPath, "assets", "images", "website-images");



            slider.Image = imageUrl;

            await _context.AddAsync(slider);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

            
        }

    }
}
