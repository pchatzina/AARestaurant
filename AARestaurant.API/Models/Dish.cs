namespace AARestaurant.API.Models
{
    public class Dish
    {
        public int DishId { get; set; }
        public string DishName { get; set; }
        public string DishDescription { get; set; }
        public int DailyMenuId { get; set; }
= 0;    public DailyMenu DailyMenu { get; set; }
        public ICollection<IngredientDish> Ingredients { get; set; }

    }
}
