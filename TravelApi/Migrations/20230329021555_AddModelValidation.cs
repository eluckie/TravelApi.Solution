using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TravelApi.Migrations
{
    /// <inheritdoc />
    public partial class AddModelValidation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "User_Name",
                keyValue: null,
                column: "User_Name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "User_Name",
                table: "Places",
                type: "varchar(25)",
                maxLength: 25,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Places",
                type: "varchar(20)",
                maxLength: 20,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "SeasonVisited",
                table: "Places",
                type: "varchar(7)",
                maxLength: 7,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Review",
                keyValue: null,
                column: "Review",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Review",
                table: "Places",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "Country",
                keyValue: null,
                column: "Country",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Places",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "City",
                keyValue: null,
                column: "City",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Places",
                type: "varchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext",
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 1,
                column: "User_Name",
                value: "Luckie");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 2,
                column: "User_Name",
                value: "Luckie");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 3,
                column: "User_Name",
                value: "Luckie");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 4,
                column: "User_Name",
                value: "Luckie");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 5,
                column: "User_Name",
                value: "Luckie");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "User_Name",
                table: "Places",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(25)",
                oldMaxLength: 25)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "State",
                table: "Places",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "SeasonVisited",
                table: "Places",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(7)",
                oldMaxLength: 7,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Review",
                table: "Places",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "longtext")
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "Country",
                table: "Places",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Places",
                type: "longtext",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldMaxLength: 20)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 1,
                column: "User_Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 2,
                column: "User_Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 3,
                column: "User_Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 4,
                column: "User_Name",
                value: null);

            migrationBuilder.UpdateData(
                table: "Places",
                keyColumn: "PlaceId",
                keyValue: 5,
                column: "User_Name",
                value: null);
        }
    }
}
