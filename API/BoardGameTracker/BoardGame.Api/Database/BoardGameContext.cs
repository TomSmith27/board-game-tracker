﻿using Microsoft.EntityFrameworkCore;

namespace BoardGame.Api.Database
{
    using Models;
    using System;

    public class BoardGameContext : DbContext
    {
        public BoardGameContext(DbContextOptions<BoardGameContext> options) : base(options) { }

        public DbSet<BoardGameEntry> Games { get; set; }
        public DbSet<BoardGameCategory> Categories { get; set; }
        public DbSet<GamePlaySession> GamePlaySessions { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<PlayerRating> Ratings { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=BoardGames;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameCategoryGameEntry>()
                .HasKey(t => new { t.BoardGameCategoryId, t.BoardGameEntryId });

            modelBuilder.Entity<GamePlaySessionPlayer>()
                .HasKey(t => new { t.GamePlaySessionId, t.PlayerId });

            modelBuilder.Entity<BoardGameEntry>()
                .HasMany(nv => nv.Categories);

            modelBuilder.Entity<BoardGameCategory>().HasMany(b => b.Games);

            modelBuilder.Entity<PlayerRating>().HasKey(p => new { p.GameId, p.PlayerId });

            modelBuilder.Entity<BoardGameEntry>().HasData(new BoardGameEntry()
            {
                Id = 1,
                Name = "Azul"
            });

            modelBuilder.Entity<GamePlaySession>().HasData(new GamePlaySession()
            {
                Id = 1,
                Date = DateTimeOffset.Now,
                GameId = 1,
            });

            modelBuilder.Entity<PlayerRating>().HasData(
                new PlayerRating()
                {
                    GameId = 1,
                    PlayerId = 1,
                    Rating = 4,
                }
            );
            Player adminAccount;
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                adminAccount = new Player()
                {
                    Id = 1,
                    Name = "Admin",
                    Username = "admin",
                    PasswordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes("password")),
                    PasswordSalt = hmac.Key
                };


                modelBuilder.Entity<Player>().HasData(adminAccount);

            }
        }
    }
}
