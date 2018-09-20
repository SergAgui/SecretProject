using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace GroupApp.Migrations
{
    public partial class GroupApp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CentralLocations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Establishment = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Thoughts = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CentralLocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "NorthLocations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Establishment = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Thoughts = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NorthLocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SouthLocations",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(nullable: false),
                    Establishment = table.Column<string>(nullable: false),
                    Address = table.Column<string>(nullable: true),
                    DateTime = table.Column<DateTime>(nullable: false),
                    Thoughts = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SouthLocations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    First = table.Column<string>(nullable: true),
                    Last = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CentralLocations");

            migrationBuilder.DropTable(
                name: "NorthLocations");

            migrationBuilder.DropTable(
                name: "SouthLocations");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}