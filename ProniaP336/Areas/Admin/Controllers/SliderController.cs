using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaP336.Contexts;

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
    }

