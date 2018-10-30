namespace BoardGame.Api.Controllers
{
    using System.Collections.Generic;
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
        public async Task<IActionResult> Get()
        {
            var gamePlaySessions = this.db.GamePlaySessions.Include(g => g.Game)
                .Include(g => g.PlayerRatings).ToList();
            List<GamePlaySessionDto> gamePlaySessionDtos = new List<GamePlaySessionDto>();
            foreach (var game in gamePlaySessions)
            {
                gamePlaySessionDtos.Add(new GamePlaySessionDto(game));
            }
            return this.Ok(gamePlaySessionDtos);
        }

        [HttpGet("{sessionId:int}")]
        public IActionResult Get(int sessionId)
        {
            var gamePlaySession = this.db.GamePlaySessions
                .Include(g => g.Game)
                .Include(g => g.PlayerRatings).ThenInclude(p => p.Player)
                .Single(g => g.Id == sessionId);

            return this.Ok(new GamePlaySessionDetailsDto(gamePlaySession));
        }

        [HttpPost("")]
        public IActionResult Create(CreateGamePlaySessionDto gameSession)
        {
            var players = db.Players.ToDictionary(p => p.Id);
            foreach (var player in gameSession.Players)
            {
                if (!players.ContainsKey(player))
                {
                    return this.BadRequest($"No player exists with id {player}");
                }
            }

            var session = gameSession.ToModel();
            db.GamePlaySessions.Add(session);
            db.SaveChanges();

            return this.Ok(session.Id);
        }
    }
}
