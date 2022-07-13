using Microsoft.EntityFrameworkCore;
using UpConstructor.Models;

namespace UpConstructor.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        public DbSet<Slider> Sliders { get; set; }
    }
}
