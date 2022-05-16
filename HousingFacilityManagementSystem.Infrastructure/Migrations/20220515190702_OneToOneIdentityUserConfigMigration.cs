using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HousingFacilityManagementSystem.Infrastructure.Migrations
{
    public partial class OneToOneIdentityUserConfigMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Administrators_IdentityId",
                table: "Administrators");

            migrationBuilder.CreateIndex(
                name: "IX_Administrators_IdentityId",
                table: "Administrators",
                column: "IdentityId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Administrators_IdentityId",
                table: "Administrators");

            migrationBuilder.CreateIndex(
                name: "IX_Administrators_IdentityId",
                table: "Administrators",
                column: "IdentityId");
        }
    }
}
