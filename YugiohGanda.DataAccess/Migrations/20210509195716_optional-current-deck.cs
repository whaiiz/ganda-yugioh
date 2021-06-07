using Microsoft.EntityFrameworkCore.Migrations;

namespace YugiohGanda.Core.Migrations
{
    public partial class optionalcurrentdeck : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Decks_CurrentDeckId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CurrentDeckId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "CurrentDeckId",
                table: "AspNetUsers",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CurrentDeckId",
                table: "AspNetUsers",
                column: "CurrentDeckId",
                unique: true,
                filter: "[CurrentDeckId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Decks_CurrentDeckId",
                table: "AspNetUsers",
                column: "CurrentDeckId",
                principalTable: "Decks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_Decks_CurrentDeckId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_CurrentDeckId",
                table: "AspNetUsers");

            migrationBuilder.AlterColumn<int>(
                name: "CurrentDeckId",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_CurrentDeckId",
                table: "AspNetUsers",
                column: "CurrentDeckId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_Decks_CurrentDeckId",
                table: "AspNetUsers",
                column: "CurrentDeckId",
                principalTable: "Decks",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
