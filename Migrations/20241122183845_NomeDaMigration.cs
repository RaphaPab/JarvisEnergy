using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JarvisEnergy.Migrations
{
    /// <inheritdoc />
    public partial class NomeDaMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Temperatura",
                table: "TJD_JS_DISPOSITIVO",
                newName: "NR_TEMPERATURA");

            migrationBuilder.RenameColumn(
                name: "ConsumoWatts",
                table: "TJD_JS_DISPOSITIVO",
                newName: "NR_CONSUMO_WATTS");

            migrationBuilder.AlterColumn<float>(
                name: "NR_CONSUMO_WATTS",
                table: "TJD_JS_DISPOSITIVO",
                type: "BINARY_FLOAT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "NVARCHAR2(2000)");

            migrationBuilder.AddColumn<float>(
                name: "NR_CUSTO_CONSUMO",
                table: "TJD_JS_DISPOSITIVO",
                type: "BINARY_FLOAT",
                nullable: false,
                defaultValue: 0f);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "NR_CUSTO_CONSUMO",
                table: "TJD_JS_DISPOSITIVO");

            migrationBuilder.RenameColumn(
                name: "NR_TEMPERATURA",
                table: "TJD_JS_DISPOSITIVO",
                newName: "Temperatura");

            migrationBuilder.RenameColumn(
                name: "NR_CONSUMO_WATTS",
                table: "TJD_JS_DISPOSITIVO",
                newName: "ConsumoWatts");

            migrationBuilder.AlterColumn<string>(
                name: "ConsumoWatts",
                table: "TJD_JS_DISPOSITIVO",
                type: "NVARCHAR2(2000)",
                nullable: false,
                oldClrType: typeof(float),
                oldType: "BINARY_FLOAT");
        }
    }
}
