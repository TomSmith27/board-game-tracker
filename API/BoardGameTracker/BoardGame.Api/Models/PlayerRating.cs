namespace BoardGame.Api.Models
{
    using System.ComponentModel.DataAnnotations;

    public class PlayerRating
    {
        public Player Player { get; set; }
        public int PlayerId { get; set; }
        public GamePlaySession GamePlaySession { get; set; }
        public int GamePlayerSessionId { get; set; }
        [Range(0, 5)]
        public int Rating { get; set; }
    }
}