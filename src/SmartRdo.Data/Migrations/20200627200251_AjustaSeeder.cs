using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartRdo.Data.Migrations
{
    public partial class AjustaSeeder : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("bf31009f-1d9c-4c81-a4d5-2a5eb8611f95"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("ca52f3f4-03b6-403f-a143-45e90146ffd1"));

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
                    { new Guid("47019220-7be5-45db-b1c8-c7246d4c3bce"), "Cliente A" },
                    { new Guid("865a1cfb-6972-48a6-9f64-fa18f59261cf"), "Cliente B" }
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: new Guid("362682de-e0a4-42e8-8e67-0ae9f720e724"));

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: new Guid("3b87e8f9-aad1-4864-b8fc-e9d545c044f2"));

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: new Guid("880c6a2a-a4d9-41d4-b886-84b48c16d6fe"));

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: new Guid("a92df7e5-8692-4859-80ec-9662e5524989"));

            migrationBuilder.DeleteData(
                table: "Areas",
                keyColumn: "Id",
                keyValue: new Guid("c59c8d12-7ef0-47f7-9486-9c98b0589852"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("47019220-7be5-45db-b1c8-c7246d4c3bce"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("865a1cfb-6972-48a6-9f64-fa18f59261cf"));

            migrationBuilder.DeleteData(
                table: "Responsaveis",
                keyColumn: "Id",
                keyValue: new Guid("362682de-e0a4-42e8-8e67-0ae9f720e724"));

            migrationBuilder.DeleteData(
                table: "Responsaveis",
                keyColumn: "Id",
                keyValue: new Guid("3b87e8f9-aad1-4864-b8fc-e9d545c044f2"));

            migrationBuilder.DeleteData(
                table: "Responsaveis",
                keyColumn: "Id",
                keyValue: new Guid("880c6a2a-a4d9-41d4-b886-84b48c16d6fe"));

            migrationBuilder.DeleteData(
                table: "Responsaveis",
                keyColumn: "Id",
                keyValue: new Guid("a92df7e5-8692-4859-80ec-9662e5524989"));

            migrationBuilder.DeleteData(
                table: "Responsaveis",
                keyColumn: "Id",
                keyValue: new Guid("c59c8d12-7ef0-47f7-9486-9c98b0589852"));

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("bf31009f-1d9c-4c81-a4d5-2a5eb8611f95"), "Cliente A" },
                    { new Guid("ca52f3f4-03b6-403f-a143-45e90146ffd1"), "Cliente B" }
                });
        }
    }
}
