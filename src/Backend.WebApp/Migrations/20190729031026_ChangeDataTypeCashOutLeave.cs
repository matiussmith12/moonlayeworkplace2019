using Microsoft.EntityFrameworkCore.Migrations;

namespace Backend.WebApp.Migrations
{
    public partial class ChangeDataTypeCashOutLeave : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SpecialNotes",
                table: "Employees",
                maxLength: 225,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 225);

            migrationBuilder.AlterColumn<string>(
                name: "ReasonLeaving",
                table: "Employees",
                maxLength: 225,
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 225);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "SpecialNotes",
                table: "Employees",
                maxLength: 225,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 225,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "ReasonLeaving",
                table: "Employees",
                maxLength: 225,
                nullable: false,
                oldClrType: typeof(string),
                oldMaxLength: 225,
                oldNullable: true);
        }
    }
}
