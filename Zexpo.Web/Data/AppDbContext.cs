using Microsoft.EntityFrameworkCore;
using Zexpo.Web.Models;

namespace Zexpo.Web.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options ) : base ( options ) 
        {  
        }

        public DbSet<Category> categories { get; set; }
    }

    
}
