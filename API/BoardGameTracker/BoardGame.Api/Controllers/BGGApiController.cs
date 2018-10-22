using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace BoardGame.Api.Controllers
{
    using Dto;

    [Route("api/bgg")]
    [ApiController]
    public class BGGApiController : ControllerBase
    {
        private HttpClient client = new HttpClient();

        public BGGApiController()
        {
            this.client.BaseAddress = new Uri("https://www.boardgamegeek.com/xmlapi/");
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));
        }


        [HttpGet("search")]
        public async Task<ActionResult<IEnumerable<string>>> Search(string search)
        {
            var result = await this.client.GetAsync($"search?search={search}");
            if(result.StatusCode == HttpStatusCode.OK)
            {
                using (var stream = new MemoryStream(await result.Content.ReadAsByteArrayAsync()))
                {
                    var serializer = new XmlSerializer(typeof(BoardgameSearchResult));
                    var boardGames = (BoardgameSearchResult)serializer.Deserialize(stream);
                    return this.Ok(boardGames);
                    //then do whatever you want
                }
            }
            
            return this.BadRequest();
        }
    }
}