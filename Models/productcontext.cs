using Microsoft.EntityFrameworkCore;

namespace TodoApi23.Models
{
    public class productContext : DbContext
    {
        public productContext(DbContextOptions<productContext> options)
            : base(options)
        {
        }

        public DbSet<product> TodoItems { get; set; }
    }
}