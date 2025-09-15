using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBBroker.Migrations
{
    /// <inheritdoc />
    public partial class StavkaServisa_Napomena : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Kolicina",
                table: "StavkeServisa");

            migrationBuilder.AddColumn<string>(
                name: "Napomena",
                table: "StavkeServisa",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Napomena",
                table: "StavkeServisa");

            migrationBuilder.AddColumn<int>(
                name: "Kolicina",
                table: "StavkeServisa",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
