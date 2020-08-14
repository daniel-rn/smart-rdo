using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmartRdo.Data.Migrations
{
    public partial class Remove_Local_Descarte : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("a0195f94-2d22-4161-bef5-366b907afb64"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("a6d1af9d-8c1b-4973-bdf2-668dac3f5a6d"));

            migrationBuilder.DropColumn(
                name: "LocalDescarte",
                table: "Atividades");

            migrationBuilder.AlterColumn<Guid>(
                name: "OperadorId",
                table: "Atividades",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uuid",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("320923ee-b72b-46bb-b2d8-4ae4146ca2c3"), "Cliente A" },
                    { new Guid("b15227ac-d07f-4ccb-a346-e8638a50ddc5"), "Cliente B" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("320923ee-b72b-46bb-b2d8-4ae4146ca2c3"));

            migrationBuilder.DeleteData(
                table: "Clientes",
                keyColumn: "Id",
                keyValue: new Guid("b15227ac-d07f-4ccb-a346-e8638a50ddc5"));

            migrationBuilder.AlterColumn<Guid>(
                name: "OperadorId",
                table: "Atividades",
                type: "uuid",
                nullable: true,
                oldClrType: typeof(Guid));

            migrationBuilder.AddColumn<string>(
                name: "LocalDescarte",
                table: "Atividades",
                type: "varchar(255)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Clientes",
                columns: new[] { "Id", "Nome" },
                values: new object[,]
                {
                    { new Guid("a0195f94-2d22-4161-bef5-366b907afb64"), "Cliente A" },
                    { new Guid("a6d1af9d-8c1b-4973-bdf2-668dac3f5a6d"), "Cliente B" }
                });
        }
    }
}
