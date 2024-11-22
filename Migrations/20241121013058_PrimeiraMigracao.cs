using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace JarvisEnergy.Migrations
{
    /// <inheritdoc />
    public partial class PrimeiraMigracao : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "TJD_JS_DISPOSITIVO",
                columns: table => new
                {
                    ID_DISPOSITIVO = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NM_DISPOSITIVO = table.Column<string>(type: "NVARCHAR2(150)", maxLength: 150, nullable: false),
                    DS_DISPOSITIVO = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false),
                    NR_VOLTAGEM = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    DS_STATUS = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    Temperatura = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    ConsumoWatts = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TJD_JS_DISPOSITIVO", x => x.ID_DISPOSITIVO);
                });

            migrationBuilder.CreateTable(
                name: "TJD_JS_ENDERECO_USUARIO",
                columns: table => new
                {
                    ID_ENDERECO_CLIENTE = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    ID_USUARIO = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    NM_RUA = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    NR_RESIDENCIA = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    NM_BAIRRO = table.Column<string>(type: "NVARCHAR2(30)", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TJD_JS_ENDERECO_USUARIO", x => x.ID_ENDERECO_CLIENTE);
                });

            migrationBuilder.CreateTable(
                name: "TJD_JS_RELATORIO",
                columns: table => new
                {
                    ID_RELATORIO = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    TP_RELATORIO = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    NM_RELATORIO = table.Column<string>(type: "NVARCHAR2(100)", maxLength: 100, nullable: false),
                    NR_RELATORIO = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    DS_RELATORIO = table.Column<string>(type: "NVARCHAR2(200)", maxLength: 200, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TJD_JS_RELATORIO", x => x.ID_RELATORIO);
                });

            migrationBuilder.CreateTable(
                name: "TJD_JS_TELEFONE",
                columns: table => new
                {
                    ID_TELEFONE = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    ID_USUARIO = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    NR_TELEFONE = table.Column<long>(type: "NUMBER(19)", nullable: false),
                    NR_DDD = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DS_TELEFONE = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TJD_JS_TELEFONE", x => x.ID_TELEFONE);
                });

            migrationBuilder.CreateTable(
                name: "TJD_JS_USUARIO",
                columns: table => new
                {
                    ID_USUARIO = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    NM_USUARIO = table.Column<string>(type: "NVARCHAR2(50)", maxLength: 50, nullable: false),
                    NR_CPF = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    NR_RG = table.Column<string>(type: "NVARCHAR2(2000)", nullable: false),
                    DT_NASCIMENTO = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    CD_SENHA = table.Column<string>(type: "NVARCHAR2(150)", maxLength: 150, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TJD_JS_USUARIO", x => x.ID_USUARIO);
                });

            migrationBuilder.CreateTable(
                name: "TJD_JS_USUARIO_DISPOSITIVO",
                columns: table => new
                {
                    ID_USUARIO_DISPOSITIVO = table.Column<int>(type: "NUMBER(10)", nullable: false)
                        .Annotation("Oracle:Identity", "START WITH 1 INCREMENT BY 1"),
                    ID_USUARIO = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    ID_DISPOSITIVO = table.Column<int>(type: "NUMBER(10)", nullable: false),
                    DT_INICIO = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false),
                    DT_FIM = table.Column<DateTime>(type: "TIMESTAMP(7)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TJD_JS_USUARIO_DISPOSITIVO", x => x.ID_USUARIO_DISPOSITIVO);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "TJD_JS_DISPOSITIVO");

            migrationBuilder.DropTable(
                name: "TJD_JS_ENDERECO_USUARIO");

            migrationBuilder.DropTable(
                name: "TJD_JS_RELATORIO");

            migrationBuilder.DropTable(
                name: "TJD_JS_TELEFONE");

            migrationBuilder.DropTable(
                name: "TJD_JS_USUARIO");

            migrationBuilder.DropTable(
                name: "TJD_JS_USUARIO_DISPOSITIVO");
        }
    }
}
