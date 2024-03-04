using AARestaurant.API.Models.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System.Reflection.Metadata;

namespace AARestaurant.API.Models
{
    public class AARestaurantDbContext : DbContext
    {
        private readonly IConfiguration _configuration;
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<DailyMenu> DailyMenu { get; set; }


        public AARestaurantDbContext(IConfiguration configuration, DbContextOptions<AARestaurantDbContext> options) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            new DishEntityTypeConfiguration().Configure(modelBuilder.Entity<Dish>());
            new IngredientEntityTypeConfiguration().Configure(modelBuilder.Entity<Ingredient>());
            new DailyMenuEntityTypeConfiguration().Configure(modelBuilder.Entity<DailyMenu>());

        }

    }
}
