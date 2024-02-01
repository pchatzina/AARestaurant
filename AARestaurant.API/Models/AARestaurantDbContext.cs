using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;
using System.Reflection.Metadata;

namespace AARestaurant.API.Models
{
    public class AARestaurantDbContext : DbContext
    {
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<IngredientDish> IngredientsDishes { get; set; }
        public DbSet<DailyMenu> DailyMenu { get; set; }

        public string DbPath { get; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=AA-36H0HS3;Initial Catalog=AARestaurant;Integrated Security=True;Trust Server Certificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<IngredientDish>()
                .HasKey(id => new { id.DishId, id.IngredientId });

            modelBuilder.Entity<IngredientDish>()
                .HasOne(id => id.Dish)
                .WithMany(d => d.Ingredients)
                .HasForeignKey(id => id.DishId);

            modelBuilder.Entity<IngredientDish>()
                .HasOne(id => id.Ingredient)
                .WithMany(i => i.Dishes)
                .HasForeignKey(id => id.IngredientId);

            modelBuilder.Entity<DailyMenu>()
                .HasMany(p => p.DailyMenuDishes)
                .WithOne(c => c.DailyMenu)
                .HasForeignKey(c => c.DailyMenuId);
        }

    }
}
