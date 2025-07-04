using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IMS.Plugins.EFCore.Migrations
{
    public partial class InitialCreate5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Position",
                table: "Employers",
                newName: "EmployerPosition");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Employers",
                newName: "EmployerName");

            migrationBuilder.RenameColumn(
                name: "Department",
                table: "Employers",
                newName: "EmployerDepartment");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Employers",
                newName: "EmployerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "EmployerPosition",
                table: "Employers",
                newName: "Position");

            migrationBuilder.RenameColumn(
                name: "EmployerName",
                table: "Employers",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "EmployerDepartment",
                table: "Employers",
                newName: "Department");

            migrationBuilder.RenameColumn(
                name: "EmployerId",
                table: "Employers",
                newName: "Id");
        }
    }
}
