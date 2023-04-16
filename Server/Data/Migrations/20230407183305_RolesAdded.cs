using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BWASMAPP.Server.Data.Migrations
{
    public partial class RolesAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Contact",
                table: "Annonser",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6c467644-aec4-4179-a39b-8efc0fe4dbc0", "94416d4e-e5f9-4d36-86a9-4e0781f181f1", "Manager", "MANAGER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bd7ca637-2d3d-469b-9829-15fccaff97a7", "916a05b8-804e-4ea3-b4d5-503f69a32d5b", "User", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ec9cdb64-3b06-497c-8b17-7ccb448cfe4f", "87607ad3-0f29-4374-b707-60b52d428e1e", "Admin", "ADMIN" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6c467644-aec4-4179-a39b-8efc0fe4dbc0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd7ca637-2d3d-469b-9829-15fccaff97a7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec9cdb64-3b06-497c-8b17-7ccb448cfe4f");

            migrationBuilder.AlterColumn<string>(
                name: "Contact",
                table: "Annonser",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
