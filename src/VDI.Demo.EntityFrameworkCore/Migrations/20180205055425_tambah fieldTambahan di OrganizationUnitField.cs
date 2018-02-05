using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace VDI.Demo.Migrations
{
    public partial class tambahfieldTambahandiOrganizationUnitField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "OrganizationUnits",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "fieldTambahan",
                table: "OrganizationUnits",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "OrganizationUnits");

            migrationBuilder.DropColumn(
                name: "fieldTambahan",
                table: "OrganizationUnits");
        }
    }
}
