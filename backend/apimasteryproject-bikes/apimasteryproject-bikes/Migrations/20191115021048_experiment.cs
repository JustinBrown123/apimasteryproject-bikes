using Microsoft.EntityFrameworkCore.Migrations;

namespace apimasteryproject_bikes.Migrations
{
    public partial class experiment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ID",
                keyValue: 1,
                column: "Logo",
                value: "./Images/Specializedlogo.jpg");

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ID",
                keyValue: 2,
                column: "Logo",
                value: "/Images/Treklogo.jpg");

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ID",
                keyValue: 3,
                column: "Logo",
                value: "Images/Cannondalelogo.jpg");

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ID",
                keyValue: 4,
                column: "Logo",
                value: "/docs/Images/Focuslogo.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ID",
                keyValue: 1,
                column: "Logo",
                value: "./docs/Images/Specializedlogo.jpg");

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ID",
                keyValue: 2,
                column: "Logo",
                value: "./docs/Images/Treklogo.jpg");

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ID",
                keyValue: 3,
                column: "Logo",
                value: "./docs/Images/Cannondalelogo.jpg");

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ID",
                keyValue: 4,
                column: "Logo",
                value: "./docs/Images/Focuslogo.jpg");
        }
    }
}
