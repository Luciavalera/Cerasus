using Microsoft.EntityFrameworkCore.Migrations;

namespace Valera.Lucia.Cerasus.API.Migrations
{
    public partial class Create24 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eventos");

            migrationBuilder.CreateTable(
                name: "Infos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Home = table.Column<string>(type: "TEXT", nullable: true),
                    Boda = table.Column<string>(type: "TEXT", nullable: true),
                    Comunion = table.Column<string>(type: "TEXT", nullable: true),
                    Corporativo = table.Column<string>(type: "TEXT", nullable: true),
                    Filosofia = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Infos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Infos");

            migrationBuilder.CreateTable(
                name: "Eventos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Boda = table.Column<string>(type: "TEXT", nullable: true),
                    Comunion = table.Column<string>(type: "TEXT", nullable: true),
                    Corporativo = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eventos", x => x.Id);
                });
        }
    }
}
