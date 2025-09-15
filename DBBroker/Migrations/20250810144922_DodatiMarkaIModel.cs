using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBBroker.Migrations
{
    /// <inheritdoc />
    public partial class DodatiMarkaIModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Marka",
                table: "Vozila");

            migrationBuilder.DropColumn(
                name: "Model",
                table: "Vozila");

            migrationBuilder.AddColumn<int>(
                name: "ModelVozilaId",
                table: "Vozila",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Marke",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Marke", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ModeliVozila",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Naziv = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MarkaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ModeliVozila", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ModeliVozila_Marke_MarkaId",
                        column: x => x.MarkaId,
                        principalTable: "Marke",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vozila_ModelVozilaId",
                table: "Vozila",
                column: "ModelVozilaId");

            migrationBuilder.CreateIndex(
                name: "IX_ModeliVozila_MarkaId",
                table: "ModeliVozila",
                column: "MarkaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vozila_ModeliVozila_ModelVozilaId",
                table: "Vozila",
                column: "ModelVozilaId",
                principalTable: "ModeliVozila",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vozila_ModeliVozila_ModelVozilaId",
                table: "Vozila");

            migrationBuilder.DropTable(
                name: "ModeliVozila");

            migrationBuilder.DropTable(
                name: "Marke");

            migrationBuilder.DropIndex(
                name: "IX_Vozila_ModelVozilaId",
                table: "Vozila");

            migrationBuilder.DropColumn(
                name: "ModelVozilaId",
                table: "Vozila");

            migrationBuilder.AddColumn<string>(
                name: "Marka",
                table: "Vozila",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Model",
                table: "Vozila",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
