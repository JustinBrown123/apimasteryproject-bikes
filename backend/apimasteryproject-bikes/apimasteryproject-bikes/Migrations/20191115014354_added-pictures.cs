using Microsoft.EntityFrameworkCore.Migrations;

namespace apimasteryproject_bikes.Migrations
{
    public partial class addedpictures : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bicycles",
                keyColumn: "ID",
                keyValue: 1,
                column: "Image",
                value: "./docs/Images/Specializedsworksshiv.jpg");

            migrationBuilder.UpdateData(
                table: "Bicycles",
                keyColumn: "ID",
                keyValue: 2,
                column: "Image",
                value: "./docs/Images/Trekboone.jpg");

            migrationBuilder.UpdateData(
                table: "Bicycles",
                keyColumn: "ID",
                keyValue: 3,
                column: "Image",
                value: "./docs/Images/Cannondalesystemsix.jpg");

            migrationBuilder.UpdateData(
                table: "Bicycles",
                keyColumn: "ID",
                keyValue: 4,
                column: "Image",
                value: "./docs/Images/Focusbigbird.jpg");

            migrationBuilder.UpdateData(
                table: "Bicycles",
                keyColumn: "ID",
                keyValue: 5,
                column: "Image",
                value: "./docs/Images/Focusizalcochrono.jpg");

            migrationBuilder.UpdateData(
                table: "Bicycles",
                keyColumn: "ID",
                keyValue: 6,
                column: "Image",
                value: "./docs/Images/Konasutra.jpg");

            migrationBuilder.UpdateData(
                table: "Bicycles",
                keyColumn: "ID",
                keyValue: 7,
                column: "Image",
                value: "./docs/Images/Transitionpatrol.jpg");

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

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ID",
                keyValue: 5,
                column: "Logo",
                value: "./docs/Images/Konalogo.jpg");

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ID",
                keyValue: 6,
                column: "Logo",
                value: "./docs/Images/Transitionlogo.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Bicycles",
                keyColumn: "ID",
                keyValue: 1,
                column: "Image",
                value: "Image");

            migrationBuilder.UpdateData(
                table: "Bicycles",
                keyColumn: "ID",
                keyValue: 2,
                column: "Image",
                value: "Image");

            migrationBuilder.UpdateData(
                table: "Bicycles",
                keyColumn: "ID",
                keyValue: 3,
                column: "Image",
                value: "Image");

            migrationBuilder.UpdateData(
                table: "Bicycles",
                keyColumn: "ID",
                keyValue: 4,
                column: "Image",
                value: "Image");

            migrationBuilder.UpdateData(
                table: "Bicycles",
                keyColumn: "ID",
                keyValue: 5,
                column: "Image",
                value: "Image");

            migrationBuilder.UpdateData(
                table: "Bicycles",
                keyColumn: "ID",
                keyValue: 6,
                column: "Image",
                value: "Image");

            migrationBuilder.UpdateData(
                table: "Bicycles",
                keyColumn: "ID",
                keyValue: 7,
                column: "Image",
                value: "Image");

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ID",
                keyValue: 1,
                column: "Logo",
                value: "Logo");

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ID",
                keyValue: 2,
                column: "Logo",
                value: "Logo");

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ID",
                keyValue: 3,
                column: "Logo",
                value: "Logo");

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ID",
                keyValue: 4,
                column: "Logo",
                value: "Logo");

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ID",
                keyValue: 5,
                column: "Logo",
                value: "Logo");

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ID",
                keyValue: 6,
                column: "Logo",
                value: "Logo");
        }
    }
}
