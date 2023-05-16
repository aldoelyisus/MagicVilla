using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MagicVilla_Api.Migrations
{
    /// <inheritdoc />
    public partial class AgregarNumeroVillaTabla : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "NumeroVilla",
                columns: table => new
                {
                    VillaNo = table.Column<int>(type: "int", nullable: false),
                    VillaId = table.Column<int>(type: "int", nullable: false),
                    DetalleEspecial = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FechaCreacion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FechaActualizacion = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NumeroVilla", x => x.VillaNo);
                    table.ForeignKey(
                        name: "FK_NumeroVilla_villas_VillaId",
                        column: x => x.VillaId,
                        principalTable: "villas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 5, 16, 16, 6, 32, 659, DateTimeKind.Local).AddTicks(509), new DateTime(2023, 5, 16, 16, 6, 32, 659, DateTimeKind.Local).AddTicks(486) });

            migrationBuilder.UpdateData(
                table: "villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "FechaActualizacion", "FechaCreacion" },
                values: new object[] { new DateTime(2023, 5, 16, 16, 6, 32, 659, DateTimeKind.Local).AddTicks(516), new DateTime(2023, 5, 16, 16, 6, 32, 659, DateTimeKind.Local).AddTicks(514) });

            migrationBuilder.CreateIndex(
                name: "IX_NumeroVilla_VillaId",
                table: "NumeroVilla",
                column: "VillaId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "NumeroVilla");

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
    }
}
