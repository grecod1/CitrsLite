using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CitrsLite.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddBudwoodRegistrationRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RegistrationId",
                table: "Budwoods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Budwoods_RegistrationId",
                table: "Budwoods",
                column: "RegistrationId");

            migrationBuilder.AddForeignKey(
                name: "FK_Budwoods_Registrations_RegistrationId",
                table: "Budwoods",
                column: "RegistrationId",
                principalTable: "Registrations",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Budwoods_Registrations_RegistrationId",
                table: "Budwoods");

            migrationBuilder.DropIndex(
                name: "IX_Budwoods_RegistrationId",
                table: "Budwoods");

            migrationBuilder.DropColumn(
                name: "RegistrationId",
                table: "Budwoods");
        }
    }
}
