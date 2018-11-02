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
            this.Date = gamePlaySession.Date;
        }

        public GamePlaySessionDto(IGrouping<DateTimeOffset, GamePlaySession> game)
        {
            this.Date = game.First().Date;
        }
        public DateTimeOffset Date { get; set; }
    }
}
