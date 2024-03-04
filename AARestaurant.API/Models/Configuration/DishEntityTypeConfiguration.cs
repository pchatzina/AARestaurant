using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using System.Reflection.Emit;

namespace AARestaurant.API.Models.Configuration
{
    public class DishEntityTypeConfiguration : IEntityTypeConfiguration<Dish>
    {
        public void Configure(EntityTypeBuilder<Dish> builder)
        {
            builder
                .HasKey(d => d.Id);

            builder
                .Property(d => d.Name)
                .IsRequired();

            builder
                .Property(d => d.Description)
                .IsRequired();

            builder
                .HasMany(d => d.Ingredients)
                .WithMany();

        }
    }
}
