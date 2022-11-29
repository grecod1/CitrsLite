using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CitrsLite.Data.Migrations
{
    /// <inheritdoc />
    public partial class RecieverRegistrationRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "RecieverId",
                table: "Registrations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Registrations_RecieverId",
                table: "Registrations",
                column: "RecieverId");

            migrationBuilder.AddForeignKey(
                name: "FK_Registrations_Participants_RecieverId",
                table: "Registrations",
                column: "RecieverId",
                principalTable: "Participants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Registrations_Participants_RecieverId",
                table: "Registrations");

            migrationBuilder.DropIndex(
                name: "IX_Registrations_RecieverId",
                table: "Registrations");

            migrationBuilder.DropColumn(
                name: "RecieverId",
                table: "Registrations");
        }
    }
}
