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

        [HttpPost("gameplay-session/{gamePlaySessionId:int}/player/{playerId:int}")]
        public async Task<IActionResult> Rate(int gamePlaySessionId, int playerId, CreateRatingDto ratingDto)
        {
            var rating = await this.db.Ratings.SingleAsync(r => r.GamePlaySessionId == gamePlaySessionId && r.PlayerId == playerId);
            rating.Rating = ratingDto.Rating;


            this.db.SaveChanges();
            return this.Ok();
        }
    }
}
