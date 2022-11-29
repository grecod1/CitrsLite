using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CitrsLite.Data.Migrations
{
    /// <inheritdoc />
    public partial class TreeLocationParticipantRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParticipantId",
                table: "TreeLocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TreeLocations_ParticipantId",
                table: "TreeLocations",
                column: "ParticipantId");

            migrationBuilder.AddForeignKey(
                name: "FK_TreeLocations_Participants_ParticipantId",
                table: "TreeLocations",
                column: "ParticipantId",
                principalTable: "Participants",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TreeLocations_Participants_ParticipantId",
                table: "TreeLocations");

            migrationBuilder.DropIndex(
                name: "IX_TreeLocations_ParticipantId",
                table: "TreeLocations");

            migrationBuilder.DropColumn(
                name: "ParticipantId",
                table: "TreeLocations");
        }
    }
}
