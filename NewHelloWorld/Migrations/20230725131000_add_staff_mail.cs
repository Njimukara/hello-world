using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NewHelloWorld.Migrations
{
    /// <inheritdoc />
    public partial class add_staff_mail : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BranchManager",
                table: "Branches");

            migrationBuilder.AddColumn<string>(
                name: "StaffEmail",
                table: "Staff",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "StaffEmail",
                table: "Staff");

            migrationBuilder.AddColumn<string>(
                name: "BranchManager",
                table: "Branches",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
