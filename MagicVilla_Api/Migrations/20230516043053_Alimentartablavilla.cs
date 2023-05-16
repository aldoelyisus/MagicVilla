using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MagicVilla_Api.Migrations
{
    /// <inheritdoc />
    public partial class Alimentartablavilla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "villas",
                columns: new[] { "Id", "Amenidad", "Detalle", "FechaActualizacion", "FechaCreacion", "ImagenUrl", "MetrosCuadrados", "Nombre", "Ocupantes", "Tarifa" },
                values: new object[,]
                {
                    { 1, "", "Detalle de la villa ", new DateTime(2023, 5, 15, 22, 30, 53, 530, DateTimeKind.Local).AddTicks(3769), new DateTime(2023, 5, 15, 22, 30, 53, 530, DateTimeKind.Local).AddTicks(3738), "", 55.0, "Villa real", 5, 200.0 },
                    { 2, "", "Detalle de la villa ", new DateTime(2023, 5, 15, 22, 30, 53, 530, DateTimeKind.Local).AddTicks(3785), new DateTime(2023, 5, 15, 22, 30, 53, 530, DateTimeKind.Local).AddTicks(3782), "", 85.0, "Premium vista pscina", 8, 500.0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
