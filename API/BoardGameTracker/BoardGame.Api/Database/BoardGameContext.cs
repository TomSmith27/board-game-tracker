using Microsoft.EntityFrameworkCore;
using System;

namespace BoardGame.Api.Database
{
    public class BoardGameContext : DbContext
    {
        public BoardGameContext(DbContextOptions<BoardGameContext> options) : base(options) { }

        public DbSet<BoardGame> BoardGames { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=BoardGames;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }
    }

    public class BoardGame
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTimeOffset Yearpublished { get; set; }

        public string Objectid { get; set; }
    }
}
