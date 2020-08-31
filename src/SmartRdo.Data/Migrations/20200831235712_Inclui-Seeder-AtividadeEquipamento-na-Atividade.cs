using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartRdo.Data.Migrations
{
    public partial class IncluiSeederAtividadeEquipamentonaAtividade : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Equipamentos",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("60f9b002-0f51-481c-a657-98a99e132242"), "Equipamento A" },
                    { new Guid("1bd1c1ec-c7c4-4042-a321-8a5fe4647b43"), "Equipamento B" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Equipamentos",
                keyColumn: "Id",
                keyValue: new Guid("1bd1c1ec-c7c4-4042-a321-8a5fe4647b43"));

            migrationBuilder.DeleteData(
                table: "Equipamentos",
                keyColumn: "Id",
                keyValue: new Guid("60f9b002-0f51-481c-a657-98a99e132242"));
        }
    }
}
