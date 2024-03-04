namespace AARestaurant.API.Models
{
    public class Dish
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public ICollection<Ingredient> Ingredients { get; set; }

    }
}
