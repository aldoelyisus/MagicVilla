using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_Api.Migrations
{
    /// <inheritdoc />
    public partial class ActualizarBasedatos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "MetrosCuadrados",
                table: "villas",
                type: "int",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion", "MetrosCuadrados" },
                values: new object[] { new DateTime(2023, 5, 15, 23, 5, 34, 829, DateTimeKind.Local).AddTicks(9644), new DateTime(2023, 5, 15, 23, 5, 34, 829, DateTimeKind.Local).AddTicks(9628), 55 });

            migrationBuilder.UpdateData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion", "MetrosCuadrados" },
                values: new object[] { new DateTime(2023, 5, 15, 23, 5, 34, 829, DateTimeKind.Local).AddTicks(9648), new DateTime(2023, 5, 15, 23, 5, 34, 829, DateTimeKind.Local).AddTicks(9647), 85 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "MetrosCuadrados",
                table: "villas",
                type: "float",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion", "MetrosCuadrados" },
                values: new object[] { new DateTime(2023, 5, 15, 22, 30, 53, 530, DateTimeKind.Local).AddTicks(3769), new DateTime(2023, 5, 15, 22, 30, 53, 530, DateTimeKind.Local).AddTicks(3738), 55.0 });

            migrationBuilder.UpdateData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion", "MetrosCuadrados" },
                values: new object[] { new DateTime(2023, 5, 15, 22, 30, 53, 530, DateTimeKind.Local).AddTicks(3785), new DateTime(2023, 5, 15, 22, 30, 53, 530, DateTimeKind.Local).AddTicks(3782), 85.0 });
        }
    }
}
