using Microsoft.EntityFrameworkCore;
using TestStoreMVC.Models;

namespace TestStoreMVC.Services
{
    public class AppLicationDbContext :DbContext
    {
        public AppLicationDbContext(DbContextOptions<AppLicationDbContext> options): base(options) 
        {
        
        }
        public DbSet<Product> Products { get; set; }
    }
}
