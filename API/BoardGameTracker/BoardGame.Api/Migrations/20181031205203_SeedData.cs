using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BoardGame.Api.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "GamePlaySessions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTimeOffset(new DateTime(2018, 10, 31, 20, 52, 2, 577, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { "Admin", new byte[] { 124, 133, 243, 219, 142, 150, 62, 67, 159, 187, 171, 225, 61, 223, 244, 14, 255, 248, 8, 36, 186, 118, 217, 18, 172, 155, 26, 30, 9, 157, 104, 183, 16, 206, 1, 61, 159, 109, 251, 226, 48, 240, 185, 200, 139, 252, 206, 228, 144, 219, 178, 177, 160, 50, 234, 216, 4, 79, 1, 111, 59, 160, 186, 215 }, new byte[] { 232, 63, 144, 104, 176, 185, 68, 163, 72, 160, 54, 111, 255, 14, 31, 37, 154, 68, 63, 197, 234, 1, 170, 207, 38, 4, 65, 198, 85, 219, 251, 128, 24, 218, 53, 21, 68, 150, 11, 239, 49, 157, 147, 174, 245, 247, 134, 233, 169, 228, 1, 222, 214, 234, 156, 64, 232, 28, 72, 28, 145, 21, 39, 159, 111, 156, 125, 103, 114, 39, 147, 54, 253, 104, 70, 121, 124, 0, 101, 215, 219, 10, 154, 205, 155, 179, 2, 123, 26, 59, 155, 76, 12, 99, 40, 78, 177, 9, 80, 24, 49, 135, 9, 79, 43, 206, 219, 134, 153, 241, 175, 64, 131, 167, 111, 222, 53, 36, 123, 105, 138, 235, 198, 10, 62, 188, 115, 29 }, "admin" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "GamePlaySessions",
                keyColumn: "Id",
                keyValue: 1,
                column: "Date",
                value: new DateTimeOffset(new DateTime(2018, 10, 31, 15, 28, 23, 972, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)));

            migrationBuilder.UpdateData(
                table: "Players",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { "Tom", null, null, null });

            migrationBuilder.InsertData(
                table: "Players",
                columns: new[] { "Id", "Name", "PasswordHash", "PasswordSalt", "Username" },
                values: new object[] { 2, "Jon", null, null, null });
        }
    }
}
