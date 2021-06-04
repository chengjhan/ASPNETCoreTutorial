using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Operas",
                columns: table => new
                {
                    OperaID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: true),
                    Composer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operas", x => x.OperaID);
                });

            migrationBuilder.InsertData(
                table: "Operas",
                columns: new[] { "OperaID", "Composer", "Title", "Year" },
                values: new object[,]
                {
                    { 1, "Wolfgang Amadeus Mozart", "Cosi Fan Tutte", 1790 },
                    { 2, "Giuseppe Verdi", "Rigoletto", 1851 },
                    { 3, "John Adams", "Nixon in China", 1987 },
                    { 4, "Alban Berg", "Wozzeck", 1922 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Operas");
        }
    }
}
