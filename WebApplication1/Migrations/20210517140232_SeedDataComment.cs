using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApplication1.Migrations
{
    public partial class SeedDataComment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "CommentId", "LastModified", "OperaID", "UserComment", "UserName" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 5, 17, 22, 2, 32, 317, DateTimeKind.Local).AddTicks(5962), 1, "comment1", "user1" },
                    { 2, new DateTime(2021, 5, 17, 22, 2, 32, 318, DateTimeKind.Local).AddTicks(7578), 1, "comment2", "user2" },
                    { 3, new DateTime(2021, 5, 17, 22, 2, 32, 318, DateTimeKind.Local).AddTicks(7600), 2, "comment3", "user3" },
                    { 4, new DateTime(2021, 5, 17, 22, 2, 32, 318, DateTimeKind.Local).AddTicks(7602), 2, "comment4", "user4" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "CommentId",
                keyValue: 4);
        }
    }
}
