using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Producers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Producers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false),
                    ProducerId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductionDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Producers_ProducerId",
                        column: x => x.ProducerId,
                        principalTable: "Producers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 1, "Description for Producer1", "Producer1" });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 2, "Description for Producer2", "Producer2" });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 3, "Description for Producer3", "Producer3" });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 4, "Description for Producer4", "Producer4" });

            migrationBuilder.InsertData(
                table: "Producers",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { 5, "Description for Producer5", "Producer5" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 1, "Description for Product1", "Product1", 49.747095326631300m, 2, new DateTime(2023, 5, 9, 15, 9, 32, 408, DateTimeKind.Local).AddTicks(4141) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 2, "Description for Product2", "Product2", 38.493835067853400m, 5, new DateTime(2024, 1, 28, 15, 9, 32, 408, DateTimeKind.Local).AddTicks(4178) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 3, "Description for Product3", "Product3", 18.015648385266500m, 5, new DateTime(2023, 7, 1, 15, 9, 32, 408, DateTimeKind.Local).AddTicks(4181) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 4, "Description for Product4", "Product4", 41.793481868608100m, 4, new DateTime(2024, 1, 29, 15, 9, 32, 408, DateTimeKind.Local).AddTicks(4208) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 5, "Description for Product5", "Product5", 94.145126426487300m, 5, new DateTime(2023, 8, 23, 15, 9, 32, 408, DateTimeKind.Local).AddTicks(4211) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 6, "Description for Product6", "Product6", 30.722479614157300m, 2, new DateTime(2024, 1, 15, 15, 9, 32, 408, DateTimeKind.Local).AddTicks(4214) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 7, "Description for Product7", "Product7", 78.898362568490400m, 5, new DateTime(2024, 1, 4, 15, 9, 32, 408, DateTimeKind.Local).AddTicks(4217) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 8, "Description for Product8", "Product8", 71.6072458916600m, 1, new DateTime(2023, 4, 26, 15, 9, 32, 408, DateTimeKind.Local).AddTicks(4219) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 9, "Description for Product9", "Product9", 61.514679427223800m, 3, new DateTime(2023, 12, 11, 15, 9, 32, 408, DateTimeKind.Local).AddTicks(4222) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "ProducerId", "ProductionDate" },
                values: new object[] { 10, "Description for Product10", "Product10", 10.777473707995300m, 4, new DateTime(2023, 10, 9, 15, 9, 32, 408, DateTimeKind.Local).AddTicks(4225) });

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProducerId",
                table: "Products",
                column: "ProducerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Producers");
        }
    }
}
