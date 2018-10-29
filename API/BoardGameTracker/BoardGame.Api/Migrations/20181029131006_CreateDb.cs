﻿using System;
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

            migrationBuilder.CreateIndex(
                name: "IX_GameCategoryGameEntry_BoardGameEntryId",
                table: "GameCategoryGameEntry",
                column: "BoardGameEntryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GameCategoryGameEntry");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Games");
        }
    }
}