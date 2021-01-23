using Microsoft.EntityFrameworkCore;

namespace Blazor.CIMS.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options)
            : base(options)
        {
        }

        public DbSet<Computer> Computers { get; set; }
        public DbSet<Tablet> Tablets { get; set; }
    }
}
