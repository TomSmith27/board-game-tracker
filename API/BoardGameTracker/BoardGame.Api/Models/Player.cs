namespace BoardGame.Api.Models
{
    using System.Collections.Generic;

    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<PlayerRating> Ratings { get; set; }
    }
}