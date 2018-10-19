namespace BoardGame.Api.Models
{
    using System;

    public class BoardGame
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTimeOffset Yearpublished { get; set; }

        public string Objectid { get; set; }
    }
}