using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class Refactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Producers_AddressId",
                table: "Producers");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 8.8234934754912700m, 1, new DateTime(2024, 1, 9, 17, 40, 10, 840, DateTimeKind.Local).AddTicks(6025) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 43.576858096380400m, 1, new DateTime(2023, 2, 8, 17, 40, 10, 840, DateTimeKind.Local).AddTicks(6057) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 99.541973512377900m, 5, new DateTime(2023, 4, 6, 17, 40, 10, 840, DateTimeKind.Local).AddTicks(6060) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price", "ProductionDate" },
                values: new object[] { 94.317146257386400m, new DateTime(2023, 11, 17, 17, 40, 10, 840, DateTimeKind.Local).AddTicks(6062) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 96.72427087562600m, 1, new DateTime(2023, 8, 16, 17, 40, 10, 840, DateTimeKind.Local).AddTicks(6065) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 31.103013308530300m, 2, new DateTime(2023, 9, 26, 17, 40, 10, 840, DateTimeKind.Local).AddTicks(6067) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 33.739954987855500m, 2, new DateTime(2023, 8, 22, 17, 40, 10, 840, DateTimeKind.Local).AddTicks(6070) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 94.99437261577600m, 2, new DateTime(2024, 1, 14, 17, 40, 10, 840, DateTimeKind.Local).AddTicks(6072) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 79.335578509786600m, 3, new DateTime(2023, 12, 11, 17, 40, 10, 840, DateTimeKind.Local).AddTicks(6074) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 93.201892198585300m, 4, new DateTime(2023, 12, 10, 17, 40, 10, 840, DateTimeKind.Local).AddTicks(6078) });

            migrationBuilder.CreateIndex(
                name: "IX_Producers_AddressId",
                table: "Producers",
                column: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Producers_AddressId",
                table: "Producers");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 0.41045240184945900m, 3, new DateTime(2023, 2, 9, 16, 49, 4, 698, DateTimeKind.Local).AddTicks(1483) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 18.727277044399300m, 3, new DateTime(2023, 6, 27, 16, 49, 4, 698, DateTimeKind.Local).AddTicks(1513) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 88.617618476508200m, 1, new DateTime(2024, 1, 23, 16, 49, 4, 698, DateTimeKind.Local).AddTicks(1517) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price", "ProductionDate" },
                values: new object[] { 1.7196206886152900m, new DateTime(2023, 9, 26, 16, 49, 4, 698, DateTimeKind.Local).AddTicks(1519) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 19.515694418668900m, 3, new DateTime(2023, 10, 17, 16, 49, 4, 698, DateTimeKind.Local).AddTicks(1521) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 40.298028813647900m, 4, new DateTime(2023, 7, 19, 16, 49, 4, 698, DateTimeKind.Local).AddTicks(1547) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 17.409180896913200m, 5, new DateTime(2023, 3, 25, 16, 49, 4, 698, DateTimeKind.Local).AddTicks(1550) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 28.404295002296300m, 5, new DateTime(2023, 4, 25, 16, 49, 4, 698, DateTimeKind.Local).AddTicks(1553) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 42.734831688275300m, 4, new DateTime(2023, 9, 16, 16, 49, 4, 698, DateTimeKind.Local).AddTicks(1555) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 46.779424198720600m, 2, new DateTime(2023, 6, 24, 16, 49, 4, 698, DateTimeKind.Local).AddTicks(1558) });

            migrationBuilder.CreateIndex(
                name: "IX_Producers_AddressId",
                table: "Producers",
                column: "AddressId",
                unique: true);
        }
    }
}
