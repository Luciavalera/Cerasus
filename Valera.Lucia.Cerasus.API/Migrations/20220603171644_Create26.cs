using Microsoft.EntityFrameworkCore.Migrations;

namespace Valera.Lucia.Cerasus.API.Migrations
{
    public partial class Create26 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PrecioComida",
                table: "Formularios");

            migrationBuilder.DropColumn(
                name: "PrecioLugar",
                table: "Formularios");

            migrationBuilder.AddColumn<string>(
                name: "Comida",
                table: "Formularios",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lugar",
                table: "Formularios",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Comida",
                table: "Formularios");

            migrationBuilder.DropColumn(
                name: "Lugar",
                table: "Formularios");

            migrationBuilder.AddColumn<int>(
                name: "PrecioComida",
                table: "Formularios",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PrecioLugar",
                table: "Formularios",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);
        }
    }
}
