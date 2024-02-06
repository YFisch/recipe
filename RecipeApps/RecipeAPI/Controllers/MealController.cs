using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeAppSystem;

namespace RecipeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MealController : ControllerBase
    {
        [HttpGet]
        public List<bizMeal> Get()
        {
            return new bizMeal().GetMealSummary();
        }

        [HttpGet("{id:int:min(0)}")]

        public bizMeal Get(int id)
        {
            bizMeal m = new();
            m.Load(id);
            return m;
        }
    }
}
