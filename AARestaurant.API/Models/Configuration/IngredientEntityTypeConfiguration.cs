using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AARestaurant.API.Models.Configuration
{
    public class IngredientEntityTypeConfiguration : IEntityTypeConfiguration<Ingredient>
    {
        public void Configure(EntityTypeBuilder<Ingredient> builder)
        {
            builder
                .HasKey(i => i.Id);

            builder
                .Property(i => i.Name)
                .IsRequired();

            builder
                .Property(i => i.IsVeganFriendly)
                .IsRequired();

            builder
                .Property(i => i.IsAllergen)
                .IsRequired();
        }
    }
}
