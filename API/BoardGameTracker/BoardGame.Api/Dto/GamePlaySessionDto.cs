namespace BoardGame.Api.Dto
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Models;

    public class GamePlaySessionDto
    {
        public int GameId { get; set; }
        public DateTimeOffset Date { get; set; }
        public List<int> Players { get; set; }

        public GamePlaySession ToModel()
        {
            return new GamePlaySession()
            {
                GameId = this.GameId,
                Date = this.Date,
                PlayerRatings = this.Players.Select(p => new PlayerRating()
                {
                    PlayerId = p
                }).ToList()
            };
        }
    }
}
