using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MovieList.Migrations
{
    public partial class AddedFloatAndGenre : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Movie",
                maxLength: 64,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<float>(
                name: "Rating",
                table: "Movie",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(2,1)");

            migrationBuilder.AddColumn<int>(
                name: "Genre",
                table: "Movie",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Genre", "Rating", "ReleaseDate", "Title" },
                values: new object[] { 1, 3, 5f, new DateTime(1997, 2, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Titanic" });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Genre", "Rating", "ReleaseDate", "Title" },
                values: new object[] { 2, 0, 2.3f, new DateTime(2005, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Screem" });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "Id", "Genre", "Rating", "ReleaseDate", "Title" },
                values: new object[] { 3, 0, 4.4f, new DateTime(1997, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "The Shining" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Movie",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DropColumn(
                name: "Genre",
                table: "Movie");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Movie",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 64);

            migrationBuilder.AlterColumn<decimal>(
                name: "Rating",
                table: "Movie",
                type: "decimal(2,1)",
                nullable: false,
                oldClrType: typeof(float));
        }
    }
}
