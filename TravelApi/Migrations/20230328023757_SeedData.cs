using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace TravelApi.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Places",
                columns: new[] { "PlaceId", "City", "Country", "Rating", "Review", "SeasonVisited", "State", "User_Name" },
                values: new object[,]
                {
                    { 1, "San Francisco", "USA", 4, "I love visiting the city in the spring", "spring", "California", "Luckie" },
                    { 2, "San Diego", "USA", 5, "Gorgeous in the summer", "summer", "California", "Luckie" },
                    { 3, "Las Vegas", "USA", 2, "I was not a fan of Vegas", "summer", "Nevada", "Luckie" },
                    { 4, "Grand Canyon Village", "USA", 5, "Most beautiful place I've ever seen", "summer", "Arizona", "Luckie" },
                    { 5, "Cleveland", "USA", 3, "City itself so-so, amazing people", "winter", "Ohio", "Luckie" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 5);
        }
    }
}
