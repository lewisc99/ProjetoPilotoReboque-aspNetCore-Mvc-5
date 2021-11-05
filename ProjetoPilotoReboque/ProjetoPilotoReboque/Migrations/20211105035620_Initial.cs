using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ProjetoPilotoReboque.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ColaboradorLogin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCompleto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ColaboradorLogin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Fornecedor",
                columns: table => new
                {
                    FornecedorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fornecedor", x => x.FornecedorId);
                });

            migrationBuilder.CreateTable(
                name: "FornecedorLogin",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCompleto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Senha = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FornecedorLogin", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FormularioAcionamento",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClienteNomeCompleto = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContratoNumero = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FornecedorId = table.Column<int>(type: "int", nullable: false),
                    DataDoAcionamento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Placa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TipoDeOcorrencia = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Descricao = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Endereço = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FormularioAcionamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FormularioAcionamento_Fornecedor_FornecedorId",
                        column: x => x.FornecedorId,
                        principalTable: "Fornecedor",
                        principalColumn: "FornecedorId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FormularioAcionamento_FornecedorId",
                table: "FormularioAcionamento",
                column: "FornecedorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ColaboradorLogin");

            migrationBuilder.DropTable(
                name: "FormularioAcionamento");

            migrationBuilder.DropTable(
                name: "FornecedorLogin");

            migrationBuilder.DropTable(
                name: "Fornecedor");
        }
    }
}
