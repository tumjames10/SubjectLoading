using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LS.Model.Migrations
{
    /// <inheritdoc />
    public partial class updateUsermodelAddFacultyID : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FacultyID",
                table: "User",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FacultyID",
                table: "User");
        }
    }
}
