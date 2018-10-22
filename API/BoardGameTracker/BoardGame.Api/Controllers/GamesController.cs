using BoardGame.Api.Database;
using BoardGame.Api.Dto;
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

        [HttpGet("")]
        public IActionResult Get()
        {
            return this.Ok(this.db.BoardGames.ToList());
        }

        [HttpPost("")]
        public IActionResult Create(BgObject bgObject)
        {
            return this.Ok(bgObject.ObjectId);
        }
    }
}