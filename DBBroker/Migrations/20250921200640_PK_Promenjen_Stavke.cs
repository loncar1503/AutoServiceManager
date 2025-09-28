using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBBroker.Migrations
{
    /// <inheritdoc />
    public partial class PK_Promenjen_Stavke : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StavkeServisa",
                table: "StavkeServisa");

            migrationBuilder.DropIndex(
                name: "IX_StavkeServisa_ServisId",
                table: "StavkeServisa");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "StavkeServisa",
                type: "int",
                nullable: false)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "ServisId1",
                table: "StavkeServisa",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StavkeServisa",
                table: "StavkeServisa",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_StavkeServisa_ServisId_Rb",
                table: "StavkeServisa",
                columns: new[] { "ServisId", "Rb" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_StavkeServisa_ServisId1",
                table: "StavkeServisa",
                column: "ServisId1");

            migrationBuilder.AddForeignKey(
                name: "FK_StavkeServisa_Servisi_ServisId1",
                table: "StavkeServisa",
                column: "ServisId1",
                principalTable: "Servisi",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StavkeServisa_Servisi_ServisId1",
                table: "StavkeServisa");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StavkeServisa",
                table: "StavkeServisa");

            migrationBuilder.DropIndex(
                name: "IX_StavkeServisa_ServisId_Rb",
                table: "StavkeServisa");

            migrationBuilder.DropIndex(
                name: "IX_StavkeServisa_ServisId1",
                table: "StavkeServisa");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "StavkeServisa");

            migrationBuilder.DropColumn(
                name: "ServisId1",
                table: "StavkeServisa");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StavkeServisa",
                table: "StavkeServisa",
                columns: new[] { "Rb", "ServisId" });

            migrationBuilder.CreateIndex(
                name: "IX_StavkeServisa_ServisId",
                table: "StavkeServisa",
                column: "ServisId");
        }
    }
}
