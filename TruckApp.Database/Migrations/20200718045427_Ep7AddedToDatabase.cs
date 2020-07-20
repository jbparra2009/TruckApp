using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace TruckApp.Database.Migrations
{
    public partial class Ep7AddedToDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "BodyType",
                table: "Trucks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Trucks",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EfectiveDate",
                table: "Trucks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "ExpiresDate",
                table: "Trucks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "IssueDate",
                table: "Trucks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "Lenght",
                table: "Trucks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "OwnerLessorName",
                table: "Trucks",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PurchaseDate",
                table: "Trucks",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "PurchasePrice",
                table: "Trucks",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "RegistrantName",
                table: "Trucks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleState",
                table: "Trucks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Type",
                table: "Trucks",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BodyType",
                table: "Trailers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Class",
                table: "Trailers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Lenght",
                table: "Trailers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "PurchaseDate",
                table: "Trailers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<decimal>(
                name: "PurchasePrice",
                table: "Trailers",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<DateTime>(
                name: "TitleIssueDate",
                table: "Trailers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "TitleNumber",
                table: "Trailers",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TitleState",
                table: "Trailers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Factories",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CDLClass",
                table: "Drivers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "CDLExpires",
                table: "Drivers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CDLIssued",
                table: "Drivers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "CDLState",
                table: "Drivers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Drivers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DOB",
                table: "Drivers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "SS",
                table: "Drivers",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Dispatches",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "Created",
                table: "Brokers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "BodyType",
                table: "Trucks");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "Trucks");

            migrationBuilder.DropColumn(
                name: "EfectiveDate",
                table: "Trucks");

            migrationBuilder.DropColumn(
                name: "ExpiresDate",
                table: "Trucks");

            migrationBuilder.DropColumn(
                name: "IssueDate",
                table: "Trucks");

            migrationBuilder.DropColumn(
                name: "Lenght",
                table: "Trucks");

            migrationBuilder.DropColumn(
                name: "OwnerLessorName",
                table: "Trucks");

            migrationBuilder.DropColumn(
                name: "PurchaseDate",
                table: "Trucks");

            migrationBuilder.DropColumn(
                name: "PurchasePrice",
                table: "Trucks");

            migrationBuilder.DropColumn(
                name: "RegistrantName",
                table: "Trucks");

            migrationBuilder.DropColumn(
                name: "TitleState",
                table: "Trucks");

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Trucks");

            migrationBuilder.DropColumn(
                name: "BodyType",
                table: "Trailers");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "Trailers");

            migrationBuilder.DropColumn(
                name: "Lenght",
                table: "Trailers");

            migrationBuilder.DropColumn(
                name: "PurchaseDate",
                table: "Trailers");

            migrationBuilder.DropColumn(
                name: "PurchasePrice",
                table: "Trailers");

            migrationBuilder.DropColumn(
                name: "TitleIssueDate",
                table: "Trailers");

            migrationBuilder.DropColumn(
                name: "TitleNumber",
                table: "Trailers");

            migrationBuilder.DropColumn(
                name: "TitleState",
                table: "Trailers");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Factories");

            migrationBuilder.DropColumn(
                name: "CDLClass",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "CDLExpires",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "CDLIssued",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "CDLState",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "DOB",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "SS",
                table: "Drivers");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Dispatches");

            migrationBuilder.DropColumn(
                name: "Created",
                table: "Brokers");
        }
    }
}
