using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBBroker.Migrations
{
    /// <inheritdoc />
    public partial class DodavanjeSvihKlasaIVeza : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Klijenti",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BrojTelefona = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Klijenti", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Usluge",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cena = table.Column<double>(type: "float", nullable: false),
                    Opis = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usluge", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vozila",
                columns: table => new
                {
                    RegBroj = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Marka = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KlijentId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vozila", x => x.RegBroj);
                    table.ForeignKey(
                        name: "FK_Vozila_Klijenti_KlijentId",
                        column: x => x.KlijentId,
                        principalTable: "Klijenti",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Servisi",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OpisProblema = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumPrijema = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UkupnaCena = table.Column<double>(type: "float", nullable: false),
                    MajstorId = table.Column<int>(type: "int", nullable: false),
                    VoziloRegBroj = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Servisi", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Servisi_Majstori_MajstorId",
                        column: x => x.MajstorId,
                        principalTable: "Majstori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Servisi_Vozila_VoziloRegBroj",
                        column: x => x.VoziloRegBroj,
                        principalTable: "Vozila",
                        principalColumn: "RegBroj",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "StavkeServisa",
                columns: table => new
                {
                    Rb = table.Column<int>(type: "int", nullable: false),
                    ServisId = table.Column<int>(type: "int", nullable: false),
                    Cena = table.Column<double>(type: "float", nullable: false),
                    Kolicina = table.Column<int>(type: "int", nullable: false),
                    UslugaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StavkeServisa", x => new { x.Rb, x.ServisId });
                    table.ForeignKey(
                        name: "FK_StavkeServisa_Servisi_ServisId",
                        column: x => x.ServisId,
                        principalTable: "Servisi",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_StavkeServisa_Usluge_UslugaId",
                        column: x => x.UslugaId,
                        principalTable: "Usluge",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Servisi_MajstorId",
                table: "Servisi",
                column: "MajstorId");

            migrationBuilder.CreateIndex(
                name: "IX_Servisi_VoziloRegBroj",
                table: "Servisi",
                column: "VoziloRegBroj");

            migrationBuilder.CreateIndex(
                name: "IX_StavkeServisa_ServisId",
                table: "StavkeServisa",
                column: "ServisId");

            migrationBuilder.CreateIndex(
                name: "IX_StavkeServisa_UslugaId",
                table: "StavkeServisa",
                column: "UslugaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vozila_KlijentId",
                table: "Vozila",
                column: "KlijentId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "StavkeServisa");

            migrationBuilder.DropTable(
                name: "Servisi");

            migrationBuilder.DropTable(
                name: "Usluge");

            migrationBuilder.DropTable(
                name: "Vozila");

            migrationBuilder.DropTable(
                name: "Klijenti");
        }
    }
}
