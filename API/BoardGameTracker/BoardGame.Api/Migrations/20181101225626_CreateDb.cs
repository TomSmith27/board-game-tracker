using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BoardGame.Api.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ObjectId = table.Column<int>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Games",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ObjectId = table.Column<int>(nullable: false),
                    YearPublished = table.Column<DateTimeOffset>(nullable: false),
                    MinPlayers = table.Column<int>(nullable: false),
                    MaxPlayers = table.Column<int>(nullable: false),
                    PlayingTime = table.Column<int>(nullable: false),
                    MinPlaytime = table.Column<int>(nullable: false),
                    MaxPlaytime = table.Column<int>(nullable: false),
                    Age = table.Column<int>(nullable: false),
                    Image = table.Column<string>(nullable: true),
                    Thumbnail = table.Column<string>(nullable: true),
                    AverageRating = table.Column<double>(nullable: false),
                    UsersRated = table.Column<int>(nullable: false),
                    BestPlayerCount = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Games", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Players",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: true),
                    Username = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<byte[]>(nullable: true),
                    PasswordSalt = table.Column<byte[]>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Players", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GameCategoryGameEntry",
                columns: table => new
                {
                    BoardGameEntryId = table.Column<int>(nullable: false),
                    BoardGameCategoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GameCategoryGameEntry", x => new { x.BoardGameCategoryId, x.BoardGameEntryId });
                    table.ForeignKey(
                        name: "FK_GameCategoryGameEntry_Categories_BoardGameCategoryId",
                        column: x => x.BoardGameCategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GameCategoryGameEntry_Games_BoardGameEntryId",
                        column: x => x.BoardGameEntryId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GamePlaySessions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTimeOffset>(nullable: false),
                    GameId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamePlaySessions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GamePlaySessions_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ratings",
                columns: table => new
                {
                    PlayerId = table.Column<int>(nullable: false),
                    GameId = table.Column<int>(nullable: false),
                    Rating = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ratings", x => new { x.GameId, x.PlayerId });
                    table.ForeignKey(
                        name: "FK_Ratings_Games_GameId",
                        column: x => x.GameId,
                        principalTable: "Games",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ratings_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GamePlaySessionPlayer",
                columns: table => new
                {
                    PlayerId = table.Column<int>(nullable: false),
                    GamePlaySessionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GamePlaySessionPlayer", x => new { x.GamePlaySessionId, x.PlayerId });
                    table.ForeignKey(
                        name: "FK_GamePlaySessionPlayer_GamePlaySessions_GamePlaySessionId",
                        column: x => x.GamePlaySessionId,
                        principalTable: "GamePlaySessions",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GamePlaySessionPlayer_Players_PlayerId",
                        column: x => x.PlayerId,
                        principalTable: "Players",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Games",
                columns: new[] { "Id", "Age", "AverageRating", "BestPlayerCount", "Description", "Image", "MaxPlayers", "MaxPlaytime", "MinPlayers", "MinPlaytime", "Name", "ObjectId", "PlayingTime", "Thumbnail", "UsersRated", "YearPublished" },
                values: new object[] { 1, 0, 0.0, null, null, null, 0, 0, 0, 0, "Azul", 0, 0, null, 0, new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Name", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 1, "Admin", new byte[] { 122, 56, 172, 190, 229, 242, 242, 172, 198, 224, 109, 68, 21, 2, 180, 30, 215, 107, 248, 216, 77, 184, 101, 75, 32, 227, 26, 193, 246, 2, 156, 25, 138, 180, 199, 185, 124, 114, 54, 101, 60, 77, 188, 69, 97, 174, 116, 179, 170, 49, 106, 28, 135, 160, 132, 160, 77, 135, 76, 251, 229, 181, 67, 235 }, new byte[] { 214, 158, 196, 48, 174, 238, 177, 112, 255, 35, 81, 123, 255, 74, 83, 36, 1, 165, 136, 124, 246, 58, 14, 229, 168, 147, 118, 187, 91, 215, 225, 210, 205, 89, 152, 22, 24, 219, 90, 227, 47, 244, 14, 163, 152, 131, 116, 154, 71, 130, 187, 194, 115, 105, 113, 123, 19, 23, 205, 248, 91, 96, 246, 105, 50, 182, 20, 198, 31, 232, 43, 179, 183, 59, 72, 49, 204, 233, 172, 48, 63, 202, 246, 43, 76, 242, 130, 142, 74, 123, 8, 37, 147, 141, 97, 19, 14, 120, 201, 209, 106, 98, 227, 77, 51, 70, 17, 85, 191, 134, 211, 100, 233, 42, 70, 217, 133, 200, 16, 100, 96, 142, 211, 9, 178, 175, 219, 251 }, "admin" });

            migrationBuilder.InsertData(
                table: "GamePlaySessions",
                columns: new[] { "Id", "Date", "GameId" },
                values: new object[] { 1, new DateTimeOffset(new DateTime(2018, 11, 1, 22, 56, 26, 257, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), 1 });

            migrationBuilder.InsertData(
                table: "Ratings",
                columns: new[] { "GameId", "PlayerId", "Rating" },
                values: new object[] { 1, 1, 4 });

            migrationBuilder.CreateIndex(
                name: "IX_GameCategoryGameEntry_BoardGameEntryId",
                table: "GameCategoryGameEntry",
                column: "BoardGameEntryId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePlaySessionPlayer_PlayerId",
                table: "GamePlaySessionPlayer",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_GamePlaySessions_GameId",
                table: "GamePlaySessions",
                column: "GameId");

            migrationBuilder.CreateIndex(
                name: "IX_Ratings_PlayerId",
                table: "Ratings",
                column: "PlayerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameCategoryGameEntry");

            migrationBuilder.DropTable(
                name: "GamePlaySessionPlayer");

            migrationBuilder.DropTable(
                name: "Ratings");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "GamePlaySessions");

            migrationBuilder.DropTable(
                name: "Players");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}
