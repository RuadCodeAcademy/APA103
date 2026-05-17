using _27_FrontToBackSqlConnection.Areas.AdminPanel.ViewModels.Sliders;
using _27_FrontToBackSqlConnection.Data;
using _27_FrontToBackSqlConnection.Models;
using _27_FrontToBackSqlConnection.Utilities.Enums;
using _27_FrontToBackSqlConnection.Utilities.Extension;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NuGet.Protocol;

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

        public async Task<IActionResult> Create(SliderCreateVM sliderCreateVM)
        {
            if (sliderCreateVM.Photo == null)
            {
                ModelState.AddModelError("Photo", "Zəhmət olmasa şəkil seçin!");
                return View(sliderCreateVM);
            }

            if (!ModelState.IsValid)
            {
                return View(sliderCreateVM);
            }

            if (!sliderCreateVM.Photo.CheckFileType("image/"))
            {
                ModelState.AddModelError(nameof(sliderCreateVM.Photo), "File type is incorrect!");
                return View(sliderCreateVM);
            }

            if (!sliderCreateVM.Photo.CheckFileSize(FileSize.MB,2))
            {
                ModelState.AddModelError(nameof(sliderCreateVM.Photo), "File size must be less than 2mb!");
                return View(sliderCreateVM);
            }

            Slider slider = new()
            {
                Title = sliderCreateVM.Title,
                Subtitle = sliderCreateVM.Subtitle,
                Description = sliderCreateVM.Description,
                Order = sliderCreateVM.Order,
                Image = await sliderCreateVM.Photo.CreateFile(_env.WebRootPath, "assets", "images", "website-images"),
            };

            

            await _context.AddAsync(slider);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));

            
        }


        public async Task<IActionResult> Delete(int? id)
        {
            if (id is null || id < 1) return BadRequest();

            Slider? slider = await _context.Sliders
                .Where(s => !s.IsDeleted)
                .FirstOrDefaultAsync(s => s.Id == id);

            if (slider is null) return NotFound();

            slider.Image.DeleteFile(_env.WebRootPath, "assets", "images", "website-images");

            _context.Remove(slider);

            await _context.SaveChangesAsync();

            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detail(int? id)
        {
            Slider? slider = await _context.Sliders.Where(s=>!s.IsDeleted).FirstOrDefaultAsync(s=>s.Id == id);

            return View(slider);
        }

        public async Task<IActionResult> Update(int? id)
        {
            if (id is null || id < 1) return BadRequest();

            Slider? slider = await _context.Sliders
                .Where(s => !s.IsDeleted)
                .FirstOrDefaultAsync(s => s.Id == id);

            if (slider is null) return NotFound();


            SliderUpdateVM sliderUpdateVM = new()
            {
                Title = slider.Title,
                Subtitle = slider.Subtitle,
                Description = slider.Description,
                Order = slider.Order,
                Image = slider.Image,

            };

            return View(sliderUpdateVM); 
        }

    }
}
