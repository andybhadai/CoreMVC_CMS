using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TechnoBergCMS.Data.Migrations
{
    public partial class ChangedProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Heigth",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "Height",
                table: "Products",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Height",
                table: "Products");

            migrationBuilder.AddColumn<int>(
                name: "Heigth",
                table: "Products",
                nullable: false,
                defaultValue: 0);
        }
    }
}
