using BggApi.Service;
using BoardGame.Api.Database;
using BoardGame.Api.Dto;
using BoardGame.Api.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace BoardGame.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamesController : ControllerBase
    {
        private readonly BoardGameContext db;
        private readonly IBggService bggService;

        public GamesController(BoardGameContext db, IBggService bggService)
        {
            this.db = db;
            this.bggService = bggService;
        }

        [HttpGet("")]
        public IActionResult Get()
        {
            return this.Ok(this.db.BoardGames.ToList());
        }

        [HttpPost("")]
        public async Task<IActionResult> Create(BgObject bgObject)
        {
            var game = await this.bggService.Get(bgObject.ObjectId);

            this.db.BoardGames.Add(new BoardGameEntry()
            {
                Name = game.Name.Single(n => n.Primary).Text,
                Thumbnail = game.Thumbnail,
                MinPlayers = game.Minplayers,
                MaxPlayers = game.Maxplayers,
                Image = game.Image,
                ObjectId = game.Objectid
            });

            this.db.SaveChanges();

            return this.Ok(bgObject.ObjectId);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            this.db.BoardGames.Remove(this.db.BoardGames.Single(b => b.Id == id));
            this.db.SaveChanges();

            return this.Ok();
        }
    }
}