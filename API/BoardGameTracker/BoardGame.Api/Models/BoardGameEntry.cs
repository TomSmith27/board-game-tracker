namespace BoardGame.Api.Models
{
    using BggApi.Dto;
    using System;
    using System.Linq;
    using System.Xml.Linq;

    public class BoardGameEntry
    {
        public BoardGameEntry()
        {

        }

        public BoardGameEntry(Boardgame boardGame)
        {

            this.Name = boardGame.Name.Single(n => n.Primary).Text;
            this.Description = boardGame.Description;
            this.ObjectId = boardGame.Objectid;
            this.YearPublished = new DateTimeOffset(new DateTime(boardGame.Yearpublished, 1, 1));
            this.MinPlayers = boardGame.Minplayers;

        }
        public int Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int ObjectId { get; set; }

        public DateTimeOffset YearPublished { get; set; }

        public int MinPlayers { get; set; }

        public int MaxPlayers { get; set; }

        public int PlayingTime { get; set; }

        public int MinPlaytime { get; set; }

        public int MaxPlaytime { get; set; }

        public int Age { get; set; }

        public string Image { get; set; }

        public string Thumbnail { get; set; }

        public BoardGameCategory Category { get; set; }


    }
}