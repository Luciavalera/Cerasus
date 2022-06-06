using Microsoft.EntityFrameworkCore.Migrations;

namespace Valera.Lucia.Cerasus.API.Migrations
{
    public partial class Create22 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Eventos");
        }
    }
}
