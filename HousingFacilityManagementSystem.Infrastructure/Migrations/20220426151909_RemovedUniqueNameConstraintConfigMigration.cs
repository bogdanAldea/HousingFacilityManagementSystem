using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HousingFacilityManagementSystem.Infrastructure.Migrations
{
    public partial class RemovedUniqueNameConstraintConfigMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_MasterConsumableUtilities_Name",
                table: "MasterConsumableUtilities");

            migrationBuilder.DropIndex(
                name: "IX_BranchedConsumableUtilities_Name",
                table: "BranchedConsumableUtilities");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MasterConsumableUtilities",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "BranchedConsumableUtilities",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "MasterConsumableUtilities",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "BranchedConsumableUtilities",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_MasterConsumableUtilities_Name",
                table: "MasterConsumableUtilities",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BranchedConsumableUtilities_Name",
                table: "BranchedConsumableUtilities",
                column: "Name",
                unique: true);
        }
    }
}
