using Book.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace Book.Web.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
                
        }
        public DbSet<Category> Categories { get; set; } 
    }

}
