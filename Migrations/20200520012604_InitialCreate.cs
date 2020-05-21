using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ViralExposure.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TownCovidInformation",
                columns: table => new
                {
                    town_no = table.Column<string>(nullable: false),
                    town = table.Column<string>(nullable: true),
                    lastupdateddate = table.Column<DateTime>(nullable: false),
                    confirmedcases = table.Column<string>(nullable: true),
                    caserate = table.Column<string>(nullable: true),
                    deaths = table.Column<string>(nullable: true),
                    peopletested = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TownCovidInformation", x => x.town_no);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TownCovidInformation");
        }
    }
}
