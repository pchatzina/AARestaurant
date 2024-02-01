namespace AARestaurant.API.Models
{
    public class DailyMenu
    {
        public int DailyMenuId { get; set; }
        public DateOnly Date { get; set; }
        public ICollection<Dish> DailyMenuDishes { get; set; }
    }
}
