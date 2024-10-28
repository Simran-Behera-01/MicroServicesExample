using MicroServicesExample.Services.ProductApi.Models;
using Microsoft.EntityFrameworkCore;

namespace MicroServicesExample.Services.ProductApi.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options) { }
        public DbSet<Product> Products { get; set; }   
    }
}
