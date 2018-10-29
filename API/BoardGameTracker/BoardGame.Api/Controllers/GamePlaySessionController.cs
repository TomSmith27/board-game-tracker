namespace BoardGame.Api.Controllers
{
    using System.Linq;
    using System.Threading.Tasks;
    using Database;
    using Dto;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;

    [Route("api/game-session")]
    [ApiController]
    public class GamePlaySessionController : ControllerBase
    {
        private readonly BoardGameContext db;

        public GamePlaySessionController(BoardGameContext db)
        {
            this.db = db;
        }

        [HttpGet("")]
        public async Task<IActionResult> Index()
        {
            return this.Ok(await this.db.GamePlaySessions.ToListAsync());
        }

        [HttpPost("")]
        public IActionResult Create(GamePlaySessionDto gameSession)
        {
            var players = db.Players.ToDictionary(p => p.Id);
            foreach (var player in gameSession.Players)
            {
                if (!players.ContainsKey(player))
                {
                    return this.BadRequest($"No player exists with id {player}");
                }
            }

            db.GamePlaySessions.Add(gameSession.ToModel());
            db.SaveChanges();

            return this.Ok();
        }
    }
}
