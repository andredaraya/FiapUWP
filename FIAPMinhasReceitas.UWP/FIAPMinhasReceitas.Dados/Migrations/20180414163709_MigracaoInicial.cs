using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace FIAPMinhasReceitas.Dados.Migrations
{
    public partial class MigracaoInicial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Receitas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Categoria = table.Column<int>(nullable: false),
                    Instrucoes = table.Column<string>(nullable: true),
                    MinutosPreparo = table.Column<int>(nullable: false),
                    Preco = table.Column<decimal>(nullable: false),
                    Titulo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receitas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Receitas");
        }
    }
}
