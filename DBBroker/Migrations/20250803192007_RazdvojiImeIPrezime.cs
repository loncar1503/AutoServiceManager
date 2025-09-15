using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBBroker.Migrations
{
    /// <inheritdoc />
    public partial class RazdvojiImeIPrezime : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImePrezime",
                table: "Majstori",
                newName: "Prezime");

            migrationBuilder.AddColumn<string>(
                name: "Ime",
                table: "Majstori",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
            
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Ime",
                table: "Majstori");

            migrationBuilder.RenameColumn(
                name: "Prezime",
                table: "Majstori",
                newName: "ImePrezime");
        }
    }
}
