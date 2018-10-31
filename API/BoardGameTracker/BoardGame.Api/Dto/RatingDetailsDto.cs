namespace BoardGame.Api.Dto
{
    using Models;

    public class RatingDetailsDto
    {
        public RatingDetailsDto(PlayerRating r)
        {
            this.PlayerName = r.Player.Name;
            this.PlayerId = r.Player.Id;
            this.Rating = r.Rating;
        }
        public int PlayerId { get; set; }
        public string PlayerName { get; }
        public int? Rating { get; }
    }
}