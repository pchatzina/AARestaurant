namespace AARestaurant.API.Models
{
    public class DailyMenu
    {
        public int Id { get; set; }
        public DateOnly Date { get; set; }
        public ICollection<Dish> Dishes { get; set; }
    }
}
