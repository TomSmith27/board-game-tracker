namespace BoardGame.Api.Controllers
{
    using Database;
    using Dto;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using System.Threading.Tasks;

    [Route("api/rating")]
    [ApiController]
    public class RatingController : ControllerBase
    {
        private readonly BoardGameContext db;

        public RatingController(BoardGameContext db)
        {
            this.db = db;
        }

        [HttpPost("")]
        public async Task<IActionResult> Rate(int gamePlayerSessionId, int playerId, CreateRatingDto ratingDto)
        {
            var rating = await this.db.Ratings.SingleAsync(r => r.GamePlayerSessionId == gamePlayerSessionId && r.PlayerId == playerId);
            rating.Rating = ratingDto.Rating;


            this.db.SaveChanges();
            return this.Ok();
        }
    }
}
