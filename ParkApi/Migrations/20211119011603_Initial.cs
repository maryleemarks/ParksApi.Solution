using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ParkApi.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parks",
                columns: table => new
                {
                    ParkId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Type = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    State = table.Column<string>(type: "longtext CHARACTER SET utf8mb4", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parks", x => x.ParkId);
                });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "ParkId", "Name", "Rating", "State", "Type" },
                values: new object[,]
                {
                    { 1, "Big Bend", 8, "Texas", "State" },
                    { 2, "Big Bend", 10, "Texas", "National" },
                    { 3, "Crater Lake", 10, "Oregon", "National" },
                    { 4, "Bastrop", 5, "Texas", "State" },
                    { 5, "Dead Horse Point", 7, "Utah", "State" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parks");
        }
    }
}
