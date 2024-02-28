using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaP336.Contexts;
using ProniaP336.Models;

namespace ProniaP336.Areas.Admin.Controllers;

[Area("Admin")]
    public class SliderController : Controller
    {
        private readonly ProniaDbContext _context;

        public SliderController(ProniaDbContext context)
    {
        _context = context;
    }
        public async Task<IActionResult> Index()
        {
            var sliders = await _context.Sliders.ToListAsync();
            return View(sliders);
        }

        public IActionResult Create() { 
            return View();
        }
    [HttpPost]
    public async Task<IActionResult> Create(Slider slider)
    {
        await _context.Sliders.AddAsync(slider);
        await _context.SaveChangesAsync();

        return RedirectToAction("Index");
    }
}

