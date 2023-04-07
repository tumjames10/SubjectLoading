using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LS.Model.Migrations
{
    /// <inheritdoc />
    public partial class SubjectCodeDepartmentAllias : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Code",
                table: "Subject",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Subject",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Allias",
                table: "Department",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Code",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Subject");

            migrationBuilder.DropColumn(
                name: "Allias",
                table: "Department");
        }
    }
}
