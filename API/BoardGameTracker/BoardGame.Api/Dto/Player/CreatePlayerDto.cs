﻿namespace BoardGame.Api.Dto.Player
{
    using Models;
    public class CreatePlayerDto
    {
        public string Name { get; set; }

        public Player ToModel()
        {
            return new Player()
            {
                Name =  this.Name
            };
        }
    }
}
