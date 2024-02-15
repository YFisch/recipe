using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeAppSystem;

namespace RecipeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {
        [HttpGet]
        public List<bizRecipe> Get()
        {
            return new bizRecipe().GetRecipeSummary();
        }

        [HttpGet("{id:int:min(0)}")]

        public bizRecipe Get(int id)
        {
            bizRecipe r = new();
            r.Load(id);
            return r;
        }

        [HttpGet("getbycookbook/{cookbookdesc}")]
        public List<bizRecipe> GetBycookbook(string cookbookdesc)
        {
            return new bizRecipe().GetRecipeCookbook(cookbookdesc);
        }
    }
}
