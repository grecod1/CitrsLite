using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CitrsLite.Data.Migrations
{
    /// <inheritdoc />
    public partial class SupplierRegistrationRealtion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "SupplierId",
                table: "Registrations",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_SupplierId",
                table: "Registrations",
                column: "SupplierId");

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Participants_SupplierId",
                table: "Registrations",
                column: "SupplierId",
                principalTable: "Participants",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Participants_SupplierId",
                table: "Registrations");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_SupplierId",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "SupplierId",
                table: "Registrations");
        }
    }
}
