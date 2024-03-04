using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace AARestaurant.API.Models.Configuration
{
    public class DailyMenuEntityTypeConfiguration : IEntityTypeConfiguration<DailyMenu>
    {
        public void Configure(EntityTypeBuilder<DailyMenu> builder)
        {

            builder
                .HasKey(d => d.Id);

            builder
                .Property(d => d.Date)
                .IsRequired();


            builder
                .HasMany(d => d.Dishes);
        }
    }
}
