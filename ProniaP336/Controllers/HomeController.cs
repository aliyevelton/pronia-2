using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaP336.Contexts;
using ProniaP336.ViewModels;

namespace ProniaP336.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProniaDbContext _context;
        public HomeController(ProniaDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var sliders = await _context.Sliders.ToListAsync();
            var shippings = await _context.Shippings.ToListAsync();

            HomeViewModel homeViewModel = new HomeViewModel
            {
                Sliders = sliders,
                Shippings = shippings
            };

            return View(homeViewModel);
        }

    }
}
