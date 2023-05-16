using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_Api.Migrations
{
    /// <inheritdoc />
    public partial class AgregarBaseDatosN : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 5, 15, 23, 8, 20, 86, DateTimeKind.Local).AddTicks(6504), new DateTime(2023, 5, 15, 23, 8, 20, 86, DateTimeKind.Local).AddTicks(6492) });

            migrationBuilder.UpdateData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 5, 15, 23, 8, 20, 86, DateTimeKind.Local).AddTicks(6507), new DateTime(2023, 5, 15, 23, 8, 20, 86, DateTimeKind.Local).AddTicks(6506) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 5, 15, 23, 5, 34, 829, DateTimeKind.Local).AddTicks(9644), new DateTime(2023, 5, 15, 23, 5, 34, 829, DateTimeKind.Local).AddTicks(9628) });

            migrationBuilder.UpdateData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 5, 15, 23, 5, 34, 829, DateTimeKind.Local).AddTicks(9648), new DateTime(2023, 5, 15, 23, 5, 34, 829, DateTimeKind.Local).AddTicks(9647) });
        }
    }
}
