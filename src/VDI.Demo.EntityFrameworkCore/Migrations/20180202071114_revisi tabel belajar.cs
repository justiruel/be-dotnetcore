using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace VDI.Demo.Migrations
{
    public partial class revisitabelbelajar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_belajar",
                table: "belajar");

            migrationBuilder.RenameTable(
                name: "belajar",
                newName: "MS_Belajar");

            migrationBuilder.AddColumn<string>(
                name: "nama",
                table: "MS_Belajar",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "umur",
                table: "MS_Belajar",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MS_Belajar",
                table: "MS_Belajar",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MS_Belajar",
                table: "MS_Belajar");

            migrationBuilder.DropColumn(
                name: "nama",
                table: "MS_Belajar");

            migrationBuilder.DropColumn(
                name: "umur",
                table: "MS_Belajar");

            migrationBuilder.RenameTable(
                name: "MS_Belajar",
                newName: "belajar");

            migrationBuilder.AddPrimaryKey(
                name: "PK_belajar",
                table: "belajar",
                column: "Id");
        }
    }
}
