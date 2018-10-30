namespace BoardGame.Api.Dto
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    public class GamePlaySessionDetailsDto
    {
        public GamePlaySessionDetailsDto(GamePlaySession gamePlaySession)
        {
            this.Id = gamePlaySession.Id;
            this.Date = gamePlaySession.Date;
            this.GameName = gamePlaySession.Game.Name;
            this.GameId = gamePlaySession.GameId;
            this.Ratings = gamePlaySession.PlayerRatings.Select(r => new RatingDetailsDto(r)).ToList();
        }
        public int Id { get; set; }
        public DateTimeOffset Date { get; }
        public string GameName { get; }
        public int GameId { get;  }
        public List<RatingDetailsDto> Ratings { get;  }
    }
}
