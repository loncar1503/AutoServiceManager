using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBBroker.Migrations
{
    /// <inheritdoc />
    public partial class DodataGodinaProizvodnje2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Servisi_Vozila_VoziloRegBroj1",
                table: "Servisi");

            migrationBuilder.DropIndex(
                name: "IX_Servisi_VoziloRegBroj1",
                table: "Servisi");

            migrationBuilder.DropColumn(
                name: "VoziloRegBroj1",
                table: "Servisi");

            migrationBuilder.AddColumn<int>(
                name: "GodinaProizvodnje",
                table: "Vozila",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "GodinaProizvodnje",
                table: "Vozila");

            migrationBuilder.AddColumn<string>(
                name: "VoziloRegBroj1",
                table: "Servisi",
                type: "nvarchar(20)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Servisi_VoziloRegBroj1",
                table: "Servisi",
                column: "VoziloRegBroj1");

            migrationBuilder.AddForeignKey(
                name: "FK_Servisi_Vozila_VoziloRegBroj1",
                table: "Servisi",
                column: "VoziloRegBroj1",
                principalTable: "Vozila",
                principalColumn: "RegBroj");
        }
    }
}
