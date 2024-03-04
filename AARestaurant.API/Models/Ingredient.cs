namespace AARestaurant.API.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsVeganFriendly { get; set; }
        public bool IsAllergen { get; set; }
    }
}
