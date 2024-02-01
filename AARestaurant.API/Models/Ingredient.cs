namespace AARestaurant.API.Models
{
    public class Ingredient
    {
        public int IngredientId { get; set; }
        public string IngredientName { get; set; }
        public bool IsVeganFriendly { get; set; }
        public bool IsAllergen { get; set; }
        public ICollection<IngredientDish> Dishes { get; set; }
    }
}
