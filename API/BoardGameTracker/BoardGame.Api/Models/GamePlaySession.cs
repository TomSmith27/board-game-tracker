namespace BoardGame.Api.Models
{
    using System;
    using System.Collections.Generic;

    public class GamePlaySession
    {
        public int Id { get; set; }
        public DateTimeOffset Date { get; set; }
        public BoardGameEntry Game { get; set; }
        public List<GamePlaySessionPlayer> Players { get; set; }
        public int GameId { get; set; }
    }
}
