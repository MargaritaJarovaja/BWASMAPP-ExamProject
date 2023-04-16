using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BWASMAPP.Server.Data.Migrations
{
    public partial class AddFieldContact : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Contact",
                table: "Annonser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Contact",
                table: "Annonser");
        }
    }
}
