using Microsoft.EntityFrameworkCore.Migrations;

namespace Warsztaty.Core.Migrations
{
    public partial class init00 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Number",
                table: "Contact");

            migrationBuilder.AlterColumn<int>(
                name: "Phone",
                table: "Contact",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Contact",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Contact");

            migrationBuilder.AlterColumn<string>(
                name: "Phone",
                table: "Contact",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "Number",
                table: "Contact",
                nullable: false,
                defaultValue: 0);
        }
    }
}
