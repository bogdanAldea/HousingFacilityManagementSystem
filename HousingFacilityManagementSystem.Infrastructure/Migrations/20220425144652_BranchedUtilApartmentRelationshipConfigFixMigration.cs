using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HousingFacilityManagementSystem.Infrastructure.Migrations
{
    public partial class BranchedUtilApartmentRelationshipConfigFixMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BranchedConsumableUtilities_Apartments_ApartmentId1",
                table: "BranchedConsumableUtilities");

            migrationBuilder.DropIndex(
                name: "IX_BranchedConsumableUtilities_ApartmentId1",
                table: "BranchedConsumableUtilities");

            migrationBuilder.DropColumn(
                name: "ApartmentId1",
                table: "BranchedConsumableUtilities");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ApartmentId1",
                table: "BranchedConsumableUtilities",
                type: "int",
                nullable: true);

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
        }
    }
}
