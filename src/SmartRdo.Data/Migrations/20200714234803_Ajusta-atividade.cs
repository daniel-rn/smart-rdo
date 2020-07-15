using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartRdo.Data.Migrations
{
    public partial class Ajustaatividade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("47019220-7be5-45db-b1c8-c7246d4c3bce"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("865a1cfb-6972-48a6-9f64-fa18f59261cf"));

            migrationBuilder.AddColumn<Guid>(
                name: "OperadorId",
                table: "Atividades",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("a0195f94-2d22-4161-bef5-366b907afb64"), "Cliente A" },
                    { new Guid("a6d1af9d-8c1b-4973-bdf2-668dac3f5a6d"), "Cliente B" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Atividades_OperadorId",
                table: "Atividades",
                column: "OperadorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Atividades_Operadores_OperadorId",
                table: "Atividades",
                column: "OperadorId",
                principalTable: "Operadores",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Atividades_Operadores_OperadorId",
                table: "Atividades");

            migrationBuilder.DropIndex(
                name: "IX_Atividades_OperadorId",
                table: "Atividades");

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("a0195f94-2d22-4161-bef5-366b907afb64"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("a6d1af9d-8c1b-4973-bdf2-668dac3f5a6d"));

            migrationBuilder.DropColumn(
                name: "OperadorId",
                table: "Atividades");

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("47019220-7be5-45db-b1c8-c7246d4c3bce"), "Cliente A" },
                    { new Guid("865a1cfb-6972-48a6-9f64-fa18f59261cf"), "Cliente B" }
                });
        }
    }
}
