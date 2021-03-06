﻿namespace BoardGame.Api.Dto
{
    using Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CreateGamePlaySessionDto
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
                Players = this.Players.Select(p => new GamePlaySessionPlayer()
                {
                    PlayerId = p
                }).ToList()
            };
        }
    }
}
