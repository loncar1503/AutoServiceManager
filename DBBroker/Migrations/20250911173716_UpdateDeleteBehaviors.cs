using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBBroker.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDeleteBehaviors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MajstorLicence_Licence_LicencaId",
                table: "MajstorLicence");

            migrationBuilder.DropForeignKey(
                name: "FK_MajstorLicence_Majstori_MajstorId",
                table: "MajstorLicence");

            migrationBuilder.DropForeignKey(
                name: "FK_Servisi_Majstori_MajstorId",
                table: "Servisi");

            migrationBuilder.DropForeignKey(
                name: "FK_Servisi_Vozila_VoziloRegBroj",
                table: "Servisi");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkeServisa_Usluge_UslugaId",
                table: "StavkeServisa");

            migrationBuilder.DropForeignKey(
                name: "FK_Vozila_Klijenti_KlijentId",
                table: "Vozila");

            migrationBuilder.AddForeignKey(
                name: "FK_MajstorLicence_Licence_LicencaId",
                table: "MajstorLicence",
                column: "LicencaId",
                principalTable: "Licence",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MajstorLicence_Majstori_MajstorId",
                table: "MajstorLicence",
                column: "MajstorId",
                principalTable: "Majstori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Servisi_Majstori_MajstorId",
                table: "Servisi",
                column: "MajstorId",
                principalTable: "Majstori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Servisi_Vozila_VoziloRegBroj",
                table: "Servisi",
                column: "VoziloRegBroj",
                principalTable: "Vozila",
                principalColumn: "RegBroj",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StavkeServisa_Usluge_UslugaId",
                table: "StavkeServisa",
                column: "UslugaId",
                principalTable: "Usluge",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Vozila_Klijenti_KlijentId",
                table: "Vozila",
                column: "KlijentId",
                principalTable: "Klijenti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MajstorLicence_Licence_LicencaId",
                table: "MajstorLicence");

            migrationBuilder.DropForeignKey(
                name: "FK_MajstorLicence_Majstori_MajstorId",
                table: "MajstorLicence");

            migrationBuilder.DropForeignKey(
                name: "FK_Servisi_Majstori_MajstorId",
                table: "Servisi");

            migrationBuilder.DropForeignKey(
                name: "FK_Servisi_Vozila_VoziloRegBroj",
                table: "Servisi");

            migrationBuilder.DropForeignKey(
                name: "FK_StavkeServisa_Usluge_UslugaId",
                table: "StavkeServisa");

            migrationBuilder.DropForeignKey(
                name: "FK_Vozila_Klijenti_KlijentId",
                table: "Vozila");

            migrationBuilder.AddForeignKey(
                name: "FK_MajstorLicence_Licence_LicencaId",
                table: "MajstorLicence",
                column: "LicencaId",
                principalTable: "Licence",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MajstorLicence_Majstori_MajstorId",
                table: "MajstorLicence",
                column: "MajstorId",
                principalTable: "Majstori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Servisi_Majstori_MajstorId",
                table: "Servisi",
                column: "MajstorId",
                principalTable: "Majstori",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Servisi_Vozila_VoziloRegBroj",
                table: "Servisi",
                column: "VoziloRegBroj",
                principalTable: "Vozila",
                principalColumn: "RegBroj",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StavkeServisa_Usluge_UslugaId",
                table: "StavkeServisa",
                column: "UslugaId",
                principalTable: "Usluge",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Vozila_Klijenti_KlijentId",
                table: "Vozila",
                column: "KlijentId",
                principalTable: "Klijenti",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
