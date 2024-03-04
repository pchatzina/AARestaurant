using AARestaurant.API.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System.Text.Json;

namespace AARestaurant.API.Data
{
    public class Seed
    {

        public static async Task SeedIngredients(AARestaurantDbContext context)
        {
            if (await context.Ingredients.AnyAsync()) return;

            var ingredientsData = await File.ReadAllTextAsync("Data/SeedIngredients.json");

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            var ingredients = JsonSerializer.Deserialize<List<Ingredient>>(ingredientsData, options);

            foreach (var ingredient in ingredients)
            {
                context.Ingredients.Add(ingredient);
            }

            await context.SaveChangesAsync();

        }

        public static async Task SeedDishes(AARestaurantDbContext context)
        {
            if (await context.Dishes.AnyAsync()) return;

            var dishesData = await File.ReadAllTextAsync("Data/SeedDishes.json");

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            var dishes = JsonSerializer.Deserialize<List<Dish>>(dishesData, options);

            foreach (var dish in dishes)
            {
                foreach (var ingredient in dish.Ingredients)
                {
                    var existingIngredient = context.Ingredients.FirstOrDefault(i => i.Name == ingredient.Name);

                    if (existingIngredient != null)
                    {
                        dish.Ingredients.Remove(ingredient);
                        dish.Ingredients.Add(existingIngredient);
                    }
                }

                context.Dishes.Add(dish);
            }

            await context.SaveChangesAsync();
        }



        public static async Task SeedDailyMenus(AARestaurantDbContext context)
        {
            if (await context.DailyMenu.AnyAsync()) return;

            var dailyMenusData = await File.ReadAllTextAsync("Data/SeedDailyMenus.json");

            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            var dailyMenus = JsonSerializer.Deserialize<List<DailyMenu>>(dailyMenusData, options);

            foreach (var dailyMenu in dailyMenus)
            {
                context.DailyMenu.Add(dailyMenu);
            }

            await context.SaveChangesAsync();
        }


    }
}
