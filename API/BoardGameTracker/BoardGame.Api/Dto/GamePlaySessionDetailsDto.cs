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
            this.Game = gamePlaySession.Game;
        }
        public int Id { get; set; }
        public DateTimeOffset Date { get; }
        public BoardGameEntry Game { get;  }
    }
}
