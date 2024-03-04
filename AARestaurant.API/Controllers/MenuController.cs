using AARestaurant.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AARestaurant.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuController : ControllerBase
    {

        private readonly AARestaurantDbContext _dbContext;

        public MenuController(AARestaurantDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet("daily")]
        public IActionResult GetDailyMenu()
        {
            var currentDate = DateOnly.FromDateTime(DateTime.Today);

            var dailyMenu = _dbContext.DailyMenu
                .Include(d => d.Dishes)
                .ThenInclude(i => i.Ingredients)
                .Where(menu => menu.Date == currentDate);


            if (dailyMenu != null)
            {
                return Ok(dailyMenu);
            }

            return NotFound("Daily menu not found for today.");
        }

        [HttpGet("weekly")]
        public IActionResult GetWeeklyMenu()
        {

            var currentDate = DateOnly.FromDateTime(DateTime.Today);
            var startOfWeek = DateOnly.FromDateTime(DateTime.Today).AddDays(-(int)currentDate.DayOfWeek + 1);
            var endOfWeek = DateOnly.FromDateTime(DateTime.Today).AddDays(7 - (int)currentDate.DayOfWeek);


            var weeklyMenu = _dbContext.DailyMenu
                .Include(d => d.Dishes)
                .ThenInclude(i => i.Ingredients)
                .Where(menu => menu.Date >= startOfWeek && menu.Date <= endOfWeek);


            if (weeklyMenu != null)
            {
                return Ok(weeklyMenu);
            }

            return NotFound("Weekly menu not found.");
        }
    }
}
