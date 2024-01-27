using Microsoft.EntityFrameworkCore;
using CoffeeShop.Api.Data.Entities;

namespace CoffeeShop.Api.Data
{
    public partial class DataContext : DbContext
    {
        public const string ConnectionStringName = "CoffeeShop";
        public DataContext():base()
        {            
        }
        public DataContext(DbContextOptions<DataContext> options): base(options)
        {
        }

        public DbSet<Category> Categories { get; set; }
        public DbSet<Offer> Offers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            SeedData(modelBuilder);
        }
    }
}
