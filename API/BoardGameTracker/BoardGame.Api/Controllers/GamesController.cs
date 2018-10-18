using BoardGame.Api.Database;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace BoardGame.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private BoardGameContext db;

        public GamesController(BoardGameContext db)
        {
            this.db = db;
        }
        [Route("")]
        public IActionResult Get()
        {
            return this.Ok(this.db.BoardGames.ToList());
        }
    }
}