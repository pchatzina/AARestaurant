using AARestaurant.API.Data;
using AARestaurant.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

var connString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<AARestaurantDbContext>(opt =>
{
    opt.UseSqlServer(connString);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

//using var scope = app.Services.CreateScope();
//var services = scope.ServiceProvider;

//var context = services.GetRequiredService<AARestaurantDbContext>();
//await context.Database.MigrateAsync();
//await Seed.SeedIngredients(context);
//await Seed.SeedDishes(context);
//await Seed.SeedDailyMenus(context);

app.Run();
