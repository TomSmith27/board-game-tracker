using Microsoft.EntityFrameworkCore;

namespace BoardGame.Api.Database
{
    using Models;

    public class BoardGameContext : DbContext
    {
        public BoardGameContext(DbContextOptions<BoardGameContext> options) : base(options) { }

        public DbSet<BoardGameEntry> Games { get; set; }
        public DbSet<BoardGameCategory> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\ProjectsV13;Initial Catalog=BoardGames;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<GameCategoryGameEntry>()
                .HasKey(t => new { t.BoardGameCategoryId, t.BoardGameEntryId});

            modelBuilder.Entity<BoardGameEntry>()
                .HasMany(nv => nv.Categories);

            modelBuilder.Entity<BoardGameCategory>().HasMany(b => b.Games);
        }
    }
}
