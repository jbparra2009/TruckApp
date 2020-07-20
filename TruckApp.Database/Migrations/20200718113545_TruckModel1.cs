using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TruckApp.Database.Migrations
{
    public partial class TruckModel1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PurchasePrice",
                table: "Trucks",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<int>(
                name: "PurchasePrice",
                table: "Trailers",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.CreateTable(
                name: "BrokerStaff",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone1 = table.Column<string>(nullable: true),
                    Fax1 = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    BrokerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrokerStaff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BrokerStaff_Brokers_BrokerId",
                        column: x => x.BrokerId,
                        principalTable: "Brokers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "FactoryStaff",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Phone1 = table.Column<string>(nullable: true),
                    Fax1 = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Created = table.Column<DateTime>(nullable: false),
                    FactoryId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FactoryStaff", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FactoryStaff_Factories_FactoryId",
                        column: x => x.FactoryId,
                        principalTable: "Factories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Loads",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreated = table.Column<DateTime>(nullable: false),
                    LoadNumber = table.Column<string>(nullable: true),
                    LoadRate = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PickupAddress = table.Column<string>(nullable: true),
                    PickupCity = table.Column<string>(nullable: true),
                    PickupState = table.Column<string>(nullable: true),
                    PickupZipCode = table.Column<string>(nullable: true),
                    PickupDate = table.Column<DateTime>(nullable: false),
                    DeliveryAddress = table.Column<string>(nullable: true),
                    DeliveryCity = table.Column<string>(nullable: true),
                    DeliveryState = table.Column<string>(nullable: true),
                    DeliveryZipCode = table.Column<string>(nullable: true),
                    DeliveryDate = table.Column<DateTime>(nullable: false),
                    Mileage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MileageEmpty = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MileageTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoadAverage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DriverPayment = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DriverAdvance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DriverFinalDeposit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FuelAverage = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FuelCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FixedCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoadExpenses = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoadExpensesDetail = table.Column<string>(nullable: true),
                    LoadTotalDeposit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoadRealDeposit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoadRevenue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoadAdvance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LoadAdvanceDetail = table.Column<string>(nullable: true),
                    DispatchCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FactoryCost = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LumperValue = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LumperDetail = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Loads", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LoadDataRelationships",
                columns: table => new
                {
                    LoadId = table.Column<int>(nullable: false),
                    BrokerId = table.Column<int>(nullable: false),
                    DispatchId = table.Column<int>(nullable: false),
                    DriverId = table.Column<int>(nullable: false),
                    FactoryId = table.Column<int>(nullable: false),
                    TrailerId = table.Column<int>(nullable: false),
                    TruckId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoadDataRelationships", x => new { x.LoadId, x.BrokerId, x.DispatchId, x.DriverId, x.FactoryId, x.TrailerId, x.TruckId });
                    table.ForeignKey(
                        name: "FK_LoadDataRelationships_Brokers_BrokerId",
                        column: x => x.BrokerId,
                        principalTable: "Brokers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoadDataRelationships_Dispatches_DispatchId",
                        column: x => x.DispatchId,
                        principalTable: "Dispatches",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoadDataRelationships_Drivers_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Drivers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoadDataRelationships_Factories_FactoryId",
                        column: x => x.FactoryId,
                        principalTable: "Factories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoadDataRelationships_Loads_LoadId",
                        column: x => x.LoadId,
                        principalTable: "Loads",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoadDataRelationships_Trailers_TrailerId",
                        column: x => x.TrailerId,
                        principalTable: "Trailers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_LoadDataRelationships_Trucks_TruckId",
                        column: x => x.TruckId,
                        principalTable: "Trucks",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BrokerStaff_BrokerId",
                table: "BrokerStaff",
                column: "BrokerId");

            migrationBuilder.CreateIndex(
                name: "IX_FactoryStaff_FactoryId",
                table: "FactoryStaff",
                column: "FactoryId");

            migrationBuilder.CreateIndex(
                name: "IX_LoadDataRelationships_BrokerId",
                table: "LoadDataRelationships",
                column: "BrokerId");

            migrationBuilder.CreateIndex(
                name: "IX_LoadDataRelationships_DispatchId",
                table: "LoadDataRelationships",
                column: "DispatchId");

            migrationBuilder.CreateIndex(
                name: "IX_LoadDataRelationships_DriverId",
                table: "LoadDataRelationships",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_LoadDataRelationships_FactoryId",
                table: "LoadDataRelationships",
                column: "FactoryId");

            migrationBuilder.CreateIndex(
                name: "IX_LoadDataRelationships_TrailerId",
                table: "LoadDataRelationships",
                column: "TrailerId");

            migrationBuilder.CreateIndex(
                name: "IX_LoadDataRelationships_TruckId",
                table: "LoadDataRelationships",
                column: "TruckId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BrokerStaff");

            migrationBuilder.DropTable(
                name: "FactoryStaff");

            migrationBuilder.DropTable(
                name: "LoadDataRelationships");

            migrationBuilder.DropTable(
                name: "Loads");

            migrationBuilder.AlterColumn<decimal>(
                name: "PurchasePrice",
                table: "Trucks",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<decimal>(
                name: "PurchasePrice",
                table: "Trailers",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int));
        }
    }
}
