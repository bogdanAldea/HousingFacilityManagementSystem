using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HousingFacilityManagementSystem.Infrastructure.Migrations
{
    public partial class OneToManyRelationshipConfigMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Apartments_ApartmentId",
                table: "Invoices");

            migrationBuilder.AddColumn<int>(
                name: "BuildingId1",
                table: "MasterConsumableUtilities",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "ApartmentId",
                table: "Invoices",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ApartmentId1",
                table: "BranchedConsumableUtilities",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "BuildingId",
                table: "Apartments",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MasterConsumableUtilities_BuildingId1",
                table: "MasterConsumableUtilities",
                column: "BuildingId1");

            migrationBuilder.CreateIndex(
                name: "IX_BranchedConsumableUtilities_ApartmentId1",
                table: "BranchedConsumableUtilities",
                column: "ApartmentId1");

            migrationBuilder.AddForeignKey(
                name: "FK_BranchedConsumableUtilities_Apartments_ApartmentId1",
                table: "BranchedConsumableUtilities",
                column: "ApartmentId1",
                principalTable: "Apartments",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Apartments_ApartmentId",
                table: "Invoices",
                column: "ApartmentId",
                principalTable: "Apartments",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MasterConsumableUtilities_Buildings_BuildingId1",
                table: "MasterConsumableUtilities",
                column: "BuildingId1",
                principalTable: "Buildings",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BranchedConsumableUtilities_Apartments_ApartmentId1",
                table: "BranchedConsumableUtilities");

            migrationBuilder.DropForeignKey(
                name: "FK_Invoices_Apartments_ApartmentId",
                table: "Invoices");

            migrationBuilder.DropForeignKey(
                name: "FK_MasterConsumableUtilities_Buildings_BuildingId1",
                table: "MasterConsumableUtilities");

            migrationBuilder.DropIndex(
                name: "IX_MasterConsumableUtilities_BuildingId1",
                table: "MasterConsumableUtilities");

            migrationBuilder.DropIndex(
                name: "IX_BranchedConsumableUtilities_ApartmentId1",
                table: "BranchedConsumableUtilities");

            migrationBuilder.DropColumn(
                name: "BuildingId1",
                table: "MasterConsumableUtilities");

            migrationBuilder.DropColumn(
                name: "ApartmentId1",
                table: "BranchedConsumableUtilities");

            migrationBuilder.AlterColumn<int>(
                name: "ApartmentId",
                table: "Invoices",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "BuildingId",
                table: "Apartments",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Invoices_Apartments_ApartmentId",
                table: "Invoices",
                column: "ApartmentId",
                principalTable: "Apartments",
                principalColumn: "Id");
        }
    }
}
