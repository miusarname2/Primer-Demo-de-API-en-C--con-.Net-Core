using Microsoft.EntityFrameworkCore;
using Demo1.Models;

namespace Demo1.Data
{
    public class StoreDbContext : DbContext
    {
        public StoreDbContext(DbContextOptions<StoreDbContext> options) : base(options) { }

        public DbSet<ProductEntity> Products { get; set; }
    }
}
