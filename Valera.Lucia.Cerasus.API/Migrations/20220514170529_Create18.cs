﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Valera.Lucia.Cerasus.API.Migrations
{
    public partial class Create18 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Foto1",
                table: "Corporativos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Foto2",
                table: "Corporativos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Foto3",
                table: "Corporativos",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Foto1",
                table: "Comuniones",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Foto2",
                table: "Comuniones",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Foto3",
                table: "Comuniones",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Foto1",
                table: "Bodas",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Foto2",
                table: "Bodas",
                type: "TEXT",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Foto3",
                table: "Bodas",
                type: "TEXT",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Foto1",
                table: "Corporativos");

            migrationBuilder.DropColumn(
                name: "Foto2",
                table: "Corporativos");

            migrationBuilder.DropColumn(
                name: "Foto3",
                table: "Corporativos");

            migrationBuilder.DropColumn(
                name: "Foto1",
                table: "Comuniones");

            migrationBuilder.DropColumn(
                name: "Foto2",
                table: "Comuniones");

            migrationBuilder.DropColumn(
                name: "Foto3",
                table: "Comuniones");

            migrationBuilder.DropColumn(
                name: "Foto1",
                table: "Bodas");

            migrationBuilder.DropColumn(
                name: "Foto2",
                table: "Bodas");

            migrationBuilder.DropColumn(
                name: "Foto3",
                table: "Bodas");
        }
    }
}
