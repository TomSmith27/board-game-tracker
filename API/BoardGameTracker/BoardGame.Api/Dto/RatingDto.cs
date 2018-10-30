using BoardGame.Api.Models;

namespace BoardGame.Api.Dto
{
    public class RatingDto
    {
        public RatingDto(PlayerRating r)
        {
            this.PlayerId = r.PlayerId;
            this.Rating = r.Rating;
        }

        public int PlayerId { get; set; }
        public int? Rating { get; set; }
    }
}
