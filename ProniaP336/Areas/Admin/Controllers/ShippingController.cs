using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProniaP336.Contexts;
using ProniaP336.Models;

namespace ProniaP336.Areas.Admin.Controllers;

[Area("Admin")]
public class ShippingController : Controller
{
    private readonly ProniaDbContext _context;

    public ShippingController(ProniaDbContext context)
    {
        _context = context;
    }
    public async Task<IActionResult> Index()
    {
        var shippings = await _context.Shippings.ToListAsync();
        return View(shippings);
    }

    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(Shipping shipping)
    {
        await _context.Shippings.AddAsync(shipping);
        await _context.SaveChangesAsync();

        return RedirectToAction("Index");
    }
    [HttpPost]
    public IActionResult Delete(int id)
    {
        var slider = _context.Sliders.SingleOrDefault(s => s.Id == id);
        _context.Sliders.Remove(slider);
        _context.SaveChanges();

        return RedirectToAction("Index");
    }
}

