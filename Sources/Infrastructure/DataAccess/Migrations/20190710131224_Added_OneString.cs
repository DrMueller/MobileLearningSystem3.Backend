﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace Mmu.Mls3.WebApi.Migrations
{
    public partial class Added_OneString : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "OneString",
                schema: "Core",
                table: "LearningSession",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "OneString",
                schema: "Core",
                table: "LearningSession");
        }
    }
}
