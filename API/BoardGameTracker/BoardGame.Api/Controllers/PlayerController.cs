namespace BoardGame.Api.Controllers
{
    using BoardGame.Api.Dto.Player;
    using Database;
    using Dto;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    [Route("api/player")]
    [ApiController]
    public class PlayerController : ControllerBase
    {
        private readonly BoardGameContext db;

        public PlayerController(BoardGameContext db)
        {
            this.db = db;
        }

        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            return this.Ok(await this.db.Players.ToListAsync());
        }

        [HttpPost("")]
        public IActionResult Create(CreatePlayerDto player)
        {
            this.db.Players.Add(player.ToModel());
            this.db.SaveChanges();
            return this.Ok();
        }
    }
}
