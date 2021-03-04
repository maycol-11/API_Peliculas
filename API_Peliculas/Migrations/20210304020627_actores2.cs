using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace API_Peliculas.Migrations
{
    public partial class actores2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaNaciomiento",
                table: "Actores");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNacimiento",
                table: "Actores",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FechaNacimiento",
                table: "Actores");

            migrationBuilder.AddColumn<DateTime>(
                name: "FechaNaciomiento",
                table: "Actores",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
