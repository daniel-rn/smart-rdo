using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartRdo.Data.Migrations
{
    public partial class Adiciona_Tabela_Equipamentos_E_Itens_Checklist : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Equipamentos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipamentos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ItensChecklistsEquipamento",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Descricao = table.Column<string>(type: "varchar(200)", nullable: false),
                    IdEquipamento = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItensChecklistsEquipamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ItensChecklistsEquipamento_Equipamentos_IdEquipamento",
                        column: x => x.IdEquipamento,
                        principalTable: "Equipamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ItensChecklistsEquipamento_IdEquipamento",
                table: "ItensChecklistsEquipamento",
                column: "IdEquipamento");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItensChecklistsEquipamento");

            migrationBuilder.DropTable(
                name: "Equipamentos");
        }
    }
}
