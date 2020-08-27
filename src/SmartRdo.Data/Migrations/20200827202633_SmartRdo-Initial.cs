using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartRdo.Data.Migrations
{
    public partial class SmartRdoInitial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Areas",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(20)", nullable: false),
                    CodigoArea = table.Column<string>(type: "varchar(13)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Areas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Clientes",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(200)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clientes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Operadores",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Operadores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Recursos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recursos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Responsaveis",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Nome = table.Column<string>(type: "varchar(20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsaveis", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Atividades",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Codigo = table.Column<string>(type: "varchar(20)", nullable: false),
                    Descricao = table.Column<string>(type: "varchar(200)", nullable: false),
                    Inicio = table.Column<DateTime>(nullable: false),
                    Fim = table.Column<DateTime>(nullable: false),
                    InicioPrevisto = table.Column<DateTime>(nullable: false),
                    FimPrevisto = table.Column<DateTime>(nullable: false),
                    ClienteId = table.Column<Guid>(nullable: false),
                    AreaId = table.Column<Guid>(nullable: false),
                    ResponsavelAreaId = table.Column<Guid>(nullable: false),
                    OperadorId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Atividades", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Atividades_Areas_AreaId",
                        column: x => x.AreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Atividades_Clientes_ClienteId",
                        column: x => x.ClienteId,
                        principalTable: "Clientes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Atividades_Operadores_OperadorId",
                        column: x => x.OperadorId,
                        principalTable: "Operadores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Atividades_Responsaveis_ResponsavelAreaId",
                        column: x => x.ResponsavelAreaId,
                        principalTable: "Responsaveis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ResponsaveisArea",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AreaId = table.Column<Guid>(nullable: false),
                    ResponsavelAreaId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ResponsaveisArea", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ResponsaveisArea_Areas_ResponsavelAreaId",
                        column: x => x.ResponsavelAreaId,
                        principalTable: "Areas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ResponsaveisArea_Responsaveis_ResponsavelAreaId",
                        column: x => x.ResponsavelAreaId,
                        principalTable: "Responsaveis",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AtividadesFotos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Foto = table.Column<string>(type: "varchar(200)", nullable: false),
                    AtividadeId = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AtividadesFotos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AtividadesFotos_Atividades_AtividadeId",
                        column: x => x.AtividadeId,
                        principalTable: "Atividades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AtividadesRecursos",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AtividadeId = table.Column<Guid>(nullable: false),
                    RecursoId = table.Column<Guid>(nullable: false)
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

            migrationBuilder.CreateTable(
                name: "AvaliacaoAtividade",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    AtividadeId = table.Column<Guid>(nullable: false),
                    Observacao = table.Column<string>(type: "varchar(100)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AvaliacaoAtividade", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AvaliacaoAtividade_Atividades_AtividadeId",
                        column: x => x.AtividadeId,
                        principalTable: "Atividades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Areas",
                columns: new[] { "Id", "CodigoArea", "Nome" },
                values: new object[,]
                {
                    { new Guid("c59c8d12-7ef0-47f7-9486-9c98b0589852"), "0001", "Galpao" },
                    { new Guid("a92df7e5-8692-4859-80ec-9662e5524989"), "0002", "Patio" },
                    { new Guid("880c6a2a-a4d9-41d4-b886-84b48c16d6fe"), "0003", "Refeitorioa" },
                    { new Guid("362682de-e0a4-42e8-8e67-0ae9f720e724"), "0004", "Producao" },
                    { new Guid("3b87e8f9-aad1-4864-b8fc-e9d545c044f2"), "0005", "Almoxarifado" }
                });

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("320923ee-b72b-46bb-b2d8-4ae4146ca2c3"), "Cliente A" },
                    { new Guid("b15227ac-d07f-4ccb-a346-e8638a50ddc5"), "Cliente B" }
                });

            migrationBuilder.InsertData(
                table: "Operadores",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("3b87e8f9-aad1-4864-b8fc-e9d545c044f2"), "Ronaldo Ghesti" },
                    { new Guid("362682de-e0a4-42e8-8e67-0ae9f720e724"), "Gustavo Sousa" },
                    { new Guid("880c6a2a-a4d9-41d4-b886-84b48c16d6fe"), "Gabriel Cotrim" },
                    { new Guid("a92df7e5-8692-4859-80ec-9662e5524989"), "Murilo Seno" },
                    { new Guid("c59c8d12-7ef0-47f7-9486-9c98b0589852"), "Daniel Nascimento" }
                });

            migrationBuilder.InsertData(
                table: "Recursos",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("60f9b002-0f51-481c-a657-98a99e132242"), "Recurso A" },
                    { new Guid("1bd1c1ec-c7c4-4042-a321-8a5fe4647b43"), "Recurso B" }
                });

            migrationBuilder.InsertData(
                table: "Responsaveis",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("c59c8d12-7ef0-47f7-9486-9c98b0589852"), "Daniel Nascimento" },
                    { new Guid("a92df7e5-8692-4859-80ec-9662e5524989"), "Murilo Seno" },
                    { new Guid("880c6a2a-a4d9-41d4-b886-84b48c16d6fe"), "Gabriel Cotrim" },
                    { new Guid("362682de-e0a4-42e8-8e67-0ae9f720e724"), "Gustavo Sousa" },
                    { new Guid("3b87e8f9-aad1-4864-b8fc-e9d545c044f2"), "Ronaldo Ghesti" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atividades_AreaId",
                table: "Atividades",
                column: "AreaId");

            migrationBuilder.CreateIndex(
                name: "IX_Atividades_ClienteId",
                table: "Atividades",
                column: "ClienteId");

            migrationBuilder.CreateIndex(
                name: "IX_Atividades_OperadorId",
                table: "Atividades",
                column: "OperadorId");

            migrationBuilder.CreateIndex(
                name: "IX_Atividades_ResponsavelAreaId",
                table: "Atividades",
                column: "ResponsavelAreaId");

            migrationBuilder.CreateIndex(
                name: "IX_AtividadesFotos_AtividadeId",
                table: "AtividadesFotos",
                column: "AtividadeId");

            migrationBuilder.CreateIndex(
                name: "IX_AtividadesRecursos_AtividadeId",
                table: "AtividadesRecursos",
                column: "AtividadeId");

            migrationBuilder.CreateIndex(
                name: "IX_AtividadesRecursos_RecursoId",
                table: "AtividadesRecursos",
                column: "RecursoId");

            migrationBuilder.CreateIndex(
                name: "IX_AvaliacaoAtividade_AtividadeId",
                table: "AvaliacaoAtividade",
                column: "AtividadeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ResponsaveisArea_ResponsavelAreaId",
                table: "ResponsaveisArea",
                column: "ResponsavelAreaId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AtividadesFotos");

            migrationBuilder.DropTable(
                name: "AtividadesRecursos");

            migrationBuilder.DropTable(
                name: "AvaliacaoAtividade");

            migrationBuilder.DropTable(
                name: "ResponsaveisArea");

            migrationBuilder.DropTable(
                name: "Recursos");

            migrationBuilder.DropTable(
                name: "Atividades");

            migrationBuilder.DropTable(
                name: "Areas");

            migrationBuilder.DropTable(
                name: "Clientes");

            migrationBuilder.DropTable(
                name: "Operadores");

            migrationBuilder.DropTable(
                name: "Responsaveis");
        }
    }
}
