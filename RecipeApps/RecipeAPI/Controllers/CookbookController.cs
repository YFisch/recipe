using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeAppSystem;

namespace RecipeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CookbookController : ControllerBase
    {
        [HttpGet]
        public List<bizCookbook> Get()
        {
            return new bizCookbook().GetCookbookSummary();
        }

        [HttpGet("{id:int:min(0)}")]

        public bizCookbook Get(int id)
        {
            bizCookbook c = new();
            c.Load(id);
            return c;
        }
    }
}
