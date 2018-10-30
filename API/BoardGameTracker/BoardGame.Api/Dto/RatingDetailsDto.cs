namespace BoardGame.Api.Dto
{
    using Models;

    public class RatingDetailsDto
    {
        public RatingDetailsDto(PlayerRating r)
        {
            this.PlayerName = r.Player.Name;
            this.Rating = r.Rating;
        }
        public string PlayerName { get; }
        public int? Rating { get; }
    }
}