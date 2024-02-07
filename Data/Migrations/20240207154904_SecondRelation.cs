using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class SecondRelation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "AddressId",
                table: "Producers",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    City = table.Column<string>(type: "TEXT", nullable: false),
                    Street = table.Column<string>(type: "TEXT", nullable: false),
                    PostalCode = table.Column<string>(type: "TEXT", nullable: false),
                    Region = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "PostalCode", "Region", "Street" },
                values: new object[] { 1, "City1", "100-000", "Region1", "Street1" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "PostalCode", "Region", "Street" },
                values: new object[] { 2, "City2", "200-000", "Region2", "Street2" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "PostalCode", "Region", "Street" },
                values: new object[] { 3, "City3", "300-000", "Region3", "Street3" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "PostalCode", "Region", "Street" },
                values: new object[] { 4, "City4", "400-000", "Region4", "Street4" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "PostalCode", "Region", "Street" },
                values: new object[] { 5, "City5", "500-000", "Region5", "Street5" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "PostalCode", "Region", "Street" },
                values: new object[] { 6, "City6", "600-000", "Region6", "Street6" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "PostalCode", "Region", "Street" },
                values: new object[] { 7, "City7", "700-000", "Region7", "Street7" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "PostalCode", "Region", "Street" },
                values: new object[] { 8, "City8", "800-000", "Region8", "Street8" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "PostalCode", "Region", "Street" },
                values: new object[] { 9, "City9", "900-000", "Region9", "Street9" });

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "City", "PostalCode", "Region", "Street" },
                values: new object[] { 10, "City10", "1000-000", "Region10", "Street10" });

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
                columns: new[] { "Price", "ProductionDate" },
                values: new object[] { 17.409180896913200m, new DateTime(2023, 3, 25, 16, 49, 4, 698, DateTimeKind.Local).AddTicks(1550) });

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

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddressId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddressId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddressId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddressId",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 5,
                column: "AddressId",
                value: 5);

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "AddressId", "Description", "Name" },
                values: new object[] { 6, 6, "Description for Producer6", "Producer6" });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "AddressId", "Description", "Name" },
                values: new object[] { 7, 7, "Description for Producer7", "Producer7" });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "AddressId", "Description", "Name" },
                values: new object[] { 8, 8, "Description for Producer8", "Producer8" });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "AddressId", "Description", "Name" },
                values: new object[] { 9, 9, "Description for Producer9", "Producer9" });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "AddressId", "Description", "Name" },
                values: new object[] { 10, 10, "Description for Producer10", "Producer10" });

            migrationBuilder.CreateIndex(
                name: "IX_Producers_AddressId",
                table: "Producers",
                column: "AddressId",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Producers_Addresses_AddressId",
                table: "Producers",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Producers_Addresses_AddressId",
                table: "Producers");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropIndex(
                name: "IX_Producers_AddressId",
                table: "Producers");

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Producers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "AddressId",
                table: "Producers");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 49.747095326631300m, 2, new DateTime(2023, 5, 9, 15, 9, 32, 408, DateTimeKind.Local).AddTicks(4141) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 38.493835067853400m, 5, new DateTime(2024, 1, 28, 15, 9, 32, 408, DateTimeKind.Local).AddTicks(4178) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 18.015648385266500m, 5, new DateTime(2023, 7, 1, 15, 9, 32, 408, DateTimeKind.Local).AddTicks(4181) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price", "ProductionDate" },
                values: new object[] { 41.793481868608100m, new DateTime(2024, 1, 29, 15, 9, 32, 408, DateTimeKind.Local).AddTicks(4208) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 94.145126426487300m, 5, new DateTime(2023, 8, 23, 15, 9, 32, 408, DateTimeKind.Local).AddTicks(4211) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 30.722479614157300m, 2, new DateTime(2024, 1, 15, 15, 9, 32, 408, DateTimeKind.Local).AddTicks(4214) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Price", "ProductionDate" },
                values: new object[] { 78.898362568490400m, new DateTime(2024, 1, 4, 15, 9, 32, 408, DateTimeKind.Local).AddTicks(4217) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 71.6072458916600m, 1, new DateTime(2023, 4, 26, 15, 9, 32, 408, DateTimeKind.Local).AddTicks(4219) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 61.514679427223800m, 3, new DateTime(2023, 12, 11, 15, 9, 32, 408, DateTimeKind.Local).AddTicks(4222) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 10.777473707995300m, 4, new DateTime(2023, 10, 9, 15, 9, 32, 408, DateTimeKind.Local).AddTicks(4225) });
        }
    }
}
