using Microsoft.EntityFrameworkCore.Migrations;

namespace apimasteryproject_bikes.Migrations
{
    public partial class logoimage : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Logo",
                table: "Manufacturers",
                newName: "Image");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Manufacturers",
                newName: "Logo");
        }
    }
}
