namespace BoardGame.Api.Controllers
{
    using Database;
    using Dto;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

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
            var gamePlaySessions = this.db.GamePlaySessions.Include(g => g.Game).GroupBy(g => g.Date).OrderByDescending(d => d.Key).ToList();
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
                .Single(g => g.Id == sessionId);

            return this.Ok(new GamePlaySessionDetailsDto(gamePlaySession));
        }

        [HttpPost("")]
        public IActionResult Create(CreateGamePlaySessionDto gameSession)
        {
            var players = db.Players.ToDictionary(p => p.Id);
            var currentRatings = db.Ratings.ToDictionary(r => new Tuple<int, int>(r.GameId, r.PlayerId));
            foreach (var player in gameSession.Players)
            {
                if(!currentRatings.ContainsKey(new Tuple<int, int>(gameSession.GameId, player)))
                {
                    this.db.Ratings.Add(new Models.PlayerRating()
                    {
                        GameId = gameSession.GameId,
                        PlayerId = player,
                    });
                }


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
