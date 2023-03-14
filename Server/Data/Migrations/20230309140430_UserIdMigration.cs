using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BWASMAPP.Server.Data.Migrations
{
    public partial class UserIdMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Annonser",
                table: "Annonser");

            migrationBuilder.RenameTable(
                name: "Annonser",
                newName: "Annons");

            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Annons",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Annons",
                table: "Annons",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_Annons_ApplicationUserId",
                table: "Annons",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Annons_AspNetUsers_ApplicationUserId",
                table: "Annons",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Annons_AspNetUsers_ApplicationUserId",
                table: "Annons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Annons",
                table: "Annons");

            migrationBuilder.DropIndex(
                name: "IX_Annons_ApplicationUserId",
                table: "Annons");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Annons");

            migrationBuilder.RenameTable(
                name: "Annons",
                newName: "Annonser");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Annonser",
                table: "Annonser",
                column: "Id");
        }
    }
}
