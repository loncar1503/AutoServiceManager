using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBBroker.Migrations
{
    /// <inheritdoc />
    public partial class Pocetna : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Licence",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Institucija = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Kategorija = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Licence", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Majstori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImePrezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Specijalizacija = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Majstori", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MajstorLicence",
                columns: table => new
                {
                    MajstorId = table.Column<int>(type: "int", nullable: false),
                    LicencaId = table.Column<int>(type: "int", nullable: false),
                    Datum = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MajstorLicence", x => new { x.MajstorId, x.LicencaId });
                    table.ForeignKey(
                        name: "FK_MajstorLicence_Licence_LicencaId",
                        column: x => x.LicencaId,
                        principalTable: "Licence",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MajstorLicence_Majstori_MajstorId",
                        column: x => x.MajstorId,
                        principalTable: "Majstori",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MajstorLicence_LicencaId",
                table: "MajstorLicence",
                column: "LicencaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MajstorLicence");

            migrationBuilder.DropTable(
                name: "Licence");

            migrationBuilder.DropTable(
                name: "Majstori");
        }
    }
}
