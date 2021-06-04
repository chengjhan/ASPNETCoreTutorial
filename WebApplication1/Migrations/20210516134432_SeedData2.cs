using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class SeedData2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Operas",
                columns: new[] { "OperaID", "Composer", "Title", "Year" },
                values: new object[,]
                {
                    { 5, "Wolfgang Amadeus Mozart", "Cosi Fan Tutte", 1790 },
                    { 26, "Giuseppe Verdi", "Rigoletto", 1851 },
                    { 25, "Wolfgang Amadeus Mozart", "Cosi Fan Tutte", 1790 },
                    { 24, "Alban Berg", "Wozzeck", 1922 },
                    { 23, "John Adams", "Nixon in China", 1987 },
                    { 22, "Giuseppe Verdi", "Rigoletto", 1851 },
                    { 21, "Wolfgang Amadeus Mozart", "Cosi Fan Tutte", 1790 },
                    { 20, "Alban Berg", "Wozzeck", 1922 },
                    { 19, "John Adams", "Nixon in China", 1987 },
                    { 18, "Giuseppe Verdi", "Rigoletto", 1851 },
                    { 17, "Wolfgang Amadeus Mozart", "Cosi Fan Tutte", 1790 },
                    { 16, "Alban Berg", "Wozzeck", 1922 },
                    { 15, "John Adams", "Nixon in China", 1987 },
                    { 14, "Giuseppe Verdi", "Rigoletto", 1851 },
                    { 13, "Wolfgang Amadeus Mozart", "Cosi Fan Tutte", 1790 },
                    { 12, "Alban Berg", "Wozzeck", 1922 },
                    { 11, "John Adams", "Nixon in China", 1987 },
                    { 10, "Giuseppe Verdi", "Rigoletto", 1851 },
                    { 9, "Wolfgang Amadeus Mozart", "Cosi Fan Tutte", 1790 },
                    { 8, "Alban Berg", "Wozzeck", 1922 },
                    { 7, "John Adams", "Nixon in China", 1987 },
                    { 6, "Giuseppe Verdi", "Rigoletto", 1851 },
                    { 27, "John Adams", "Nixon in China", 1987 },
                    { 28, "Alban Berg", "Wozzeck", 1922 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Operas",
                keyColumn: "OperaID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Operas",
                keyColumn: "OperaID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Operas",
                keyColumn: "OperaID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Operas",
                keyColumn: "OperaID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Operas",
                keyColumn: "OperaID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Operas",
                keyColumn: "OperaID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Operas",
                keyColumn: "OperaID",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Operas",
                keyColumn: "OperaID",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Operas",
                keyColumn: "OperaID",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Operas",
                keyColumn: "OperaID",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Operas",
                keyColumn: "OperaID",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Operas",
                keyColumn: "OperaID",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Operas",
                keyColumn: "OperaID",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Operas",
                keyColumn: "OperaID",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Operas",
                keyColumn: "OperaID",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Operas",
                keyColumn: "OperaID",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Operas",
                keyColumn: "OperaID",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Operas",
                keyColumn: "OperaID",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Operas",
                keyColumn: "OperaID",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Operas",
                keyColumn: "OperaID",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Operas",
                keyColumn: "OperaID",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Operas",
                keyColumn: "OperaID",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Operas",
                keyColumn: "OperaID",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Operas",
                keyColumn: "OperaID",
                keyValue: 28);
        }
    }
}
