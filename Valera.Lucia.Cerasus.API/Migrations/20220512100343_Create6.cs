using Microsoft.EntityFrameworkCore.Migrations;

namespace Valera.Lucia.Cerasus.API.Migrations
{
    public partial class Create6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Comidas_ComidaId",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Lugares_LugarId",
                table: "Productos");

            migrationBuilder.DropForeignKey(
                name: "FK_Productos_Usuarios_UsuarioId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_ComidaId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_LugarId",
                table: "Productos");

            migrationBuilder.DropIndex(
                name: "IX_Productos_UsuarioId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "ComidaId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "LugarId",
                table: "Productos");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Productos");

            migrationBuilder.AddColumn<int>(
                name: "ProductoId",
                table: "Usuarios",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductoId",
                table: "Lugares",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ProductoId",
                table: "Comidas",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_ProductoId",
                table: "Usuarios",
                column: "ProductoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Lugares_ProductoId",
                table: "Lugares",
                column: "ProductoId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Comidas_ProductoId",
                table: "Comidas",
                column: "ProductoId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Comidas_Productos_ProductoId",
                table: "Comidas",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Lugares_Productos_ProductoId",
                table: "Lugares",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_Productos_ProductoId",
                table: "Usuarios",
                column: "ProductoId",
                principalTable: "Productos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Comidas_Productos_ProductoId",
                table: "Comidas");

            migrationBuilder.DropForeignKey(
                name: "FK_Lugares_Productos_ProductoId",
                table: "Lugares");

            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_Productos_ProductoId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_ProductoId",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Lugares_ProductoId",
                table: "Lugares");

            migrationBuilder.DropIndex(
                name: "IX_Comidas_ProductoId",
                table: "Comidas");

            migrationBuilder.DropColumn(
                name: "ProductoId",
                table: "Usuarios");

            migrationBuilder.DropColumn(
                name: "ProductoId",
                table: "Lugares");

            migrationBuilder.DropColumn(
                name: "ProductoId",
                table: "Comidas");

            migrationBuilder.AddColumn<int>(
                name: "ComidaId",
                table: "Productos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "LugarId",
                table: "Productos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Productos",
                type: "INTEGER",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Productos_ComidaId",
                table: "Productos",
                column: "ComidaId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_LugarId",
                table: "Productos",
                column: "LugarId");

            migrationBuilder.CreateIndex(
                name: "IX_Productos_UsuarioId",
                table: "Productos",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Comidas_ComidaId",
                table: "Productos",
                column: "ComidaId",
                principalTable: "Comidas",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Lugares_LugarId",
                table: "Productos",
                column: "LugarId",
                principalTable: "Lugares",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Productos_Usuarios_UsuarioId",
                table: "Productos",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
