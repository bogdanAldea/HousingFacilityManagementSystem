using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HousingFacilityManagementSystem.Infrastructure.Migrations
{
    public partial class MasterUtilBuildingRelationshipConfigFixMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MasterConsumableUtilities_Buildings_BuildingId1",
                table: "MasterConsumableUtilities");

            migrationBuilder.DropIndex(
                name: "IX_MasterConsumableUtilities_BuildingId1",
                table: "MasterConsumableUtilities");

            migrationBuilder.DropColumn(
                name: "BuildingId1",
                table: "MasterConsumableUtilities");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BuildingId1",
                table: "MasterConsumableUtilities",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MasterConsumableUtilities_BuildingId1",
                table: "MasterConsumableUtilities",
                column: "BuildingId1");

            migrationBuilder.AddForeignKey(
                name: "FK_MasterConsumableUtilities_Buildings_BuildingId1",
                table: "MasterConsumableUtilities",
                column: "BuildingId1",
                principalTable: "Buildings",
                principalColumn: "Id");
        }
    }
}
