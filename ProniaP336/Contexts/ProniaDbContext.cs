using Microsoft.EntityFrameworkCore;
using ProniaP336.Models;

namespace ProniaP336.Contexts
{
    public class ProniaDbContext : DbContext
    {
        public ProniaDbContext(DbContextOptions<ProniaDbContext> options) : base(options)
        {
        }

        public DbSet<Slider> Sliders { get; set; } = null!;
        public DbSet<Shipping> Shippings { get; set; } = null !;
    }
}
