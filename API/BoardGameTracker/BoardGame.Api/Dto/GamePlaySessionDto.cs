using BoardGame.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BoardGame.Api.Dto
{
    public class GamePlaySessionDto
    {
        public GamePlaySessionDto(GamePlaySession gamePlaySession)
        {
            this.Id = gamePlaySession.Id;
            this.Date = gamePlaySession.Date;
            this.GameName = gamePlaySession.Game.Name;
            this.GameId = gamePlaySession.GameId;
            this.Ratings = gamePlaySession.PlayerRatings.Select(r => new RatingDto(r)).ToList();
        }
        public int Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public string GameName { get; set; }
        public int GameId { get; set; }
        public List<RatingDto> Ratings { get; set; }
    }
}
