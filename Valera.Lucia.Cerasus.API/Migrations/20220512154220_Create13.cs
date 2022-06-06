using Microsoft.EntityFrameworkCore.Migrations;

namespace Valera.Lucia.Cerasus.API.Migrations
{
    public partial class Create13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Corporativo",
                table: "Corporativo");

            migrationBuilder.RenameTable(
                name: "Corporativo",
                newName: "Corporativos");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Corporativos",
                table: "Corporativos",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Corporativos",
                table: "Corporativos");

            migrationBuilder.RenameTable(
                name: "Corporativos",
                newName: "Corporativo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Corporativo",
                table: "Corporativo",
                column: "Id");
        }
    }
}
