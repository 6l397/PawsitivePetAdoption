using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PawsitivePetAdoption.Migrations
{
    /// <inheritdoc />
    public partial class changedNamesOfProperties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Animals",
                newName: "DateOfBirth");

            migrationBuilder.RenameColumn(
                name: "Age",
                table: "Adopters",
                newName: "DateOfBirth");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "Animals",
                newName: "Age");

            migrationBuilder.RenameColumn(
                name: "DateOfBirth",
                table: "Adopters",
                newName: "Age");
        }
    }
}
