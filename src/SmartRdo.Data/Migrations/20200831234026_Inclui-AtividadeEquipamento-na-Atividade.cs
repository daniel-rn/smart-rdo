using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartRdo.Data.Migrations
{
    public partial class IncluiAtividadeEquipamentonaAtividade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AtividadesRecursos");

            migrationBuilder.DropTable(
                name: "Recursos");

            migrationBuilder.CreateTable(
                name: "AtividadesEquipamento",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AtividadeId = table.Column<Guid>(nullable: false),
                    EquipamentoId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtividadesEquipamento", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AtividadesEquipamento_Atividades_AtividadeId",
                        column: x => x.AtividadeId,
                        principalTable: "Atividades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AtividadesEquipamento_Equipamentos_EquipamentoId",
                        column: x => x.EquipamentoId,
                        principalTable: "Equipamentos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AtividadesEquipamento_AtividadeId",
                table: "AtividadesEquipamento",
                column: "AtividadeId");

            migrationBuilder.CreateIndex(
                name: "IX_AtividadesEquipamento_EquipamentoId",
                table: "AtividadesEquipamento",
                column: "EquipamentoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AtividadesEquipamento");

            migrationBuilder.CreateTable(
                name: "Recursos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AtividadesRecursos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    AtividadeId = table.Column<Guid>(type: "uuid", nullable: false),
                    RecursoId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtividadesRecursos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AtividadesRecursos_Atividades_AtividadeId",
                        column: x => x.AtividadeId,
                        principalTable: "Atividades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AtividadesRecursos_Recursos_RecursoId",
                        column: x => x.RecursoId,
                        principalTable: "Recursos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Recursos",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("60f9b002-0f51-481c-a657-98a99e132242"), "Recurso A" },
                    { new Guid("1bd1c1ec-c7c4-4042-a321-8a5fe4647b43"), "Recurso B" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AtividadesRecursos_AtividadeId",
                table: "AtividadesRecursos",
                column: "AtividadeId");

            migrationBuilder.CreateIndex(
                name: "IX_AtividadesRecursos_RecursoId",
                table: "AtividadesRecursos",
                column: "RecursoId");
        }
    }
}
