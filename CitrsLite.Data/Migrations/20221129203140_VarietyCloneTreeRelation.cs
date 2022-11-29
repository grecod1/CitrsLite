using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CitrsLite.Data.Migrations
{
    /// <inheritdoc />
    public partial class VarietyCloneTreeRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "VarietyCloneId",
                table: "Trees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Trees_VarietyCloneId",
                table: "Trees",
                column: "VarietyCloneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trees_VarietyClones_VarietyCloneId",
                table: "Trees",
                column: "VarietyCloneId",
                principalTable: "VarietyClones",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trees_VarietyClones_VarietyCloneId",
                table: "Trees");

            migrationBuilder.DropIndex(
                name: "IX_Trees_VarietyCloneId",
                table: "Trees");

            migrationBuilder.DropColumn(
                name: "VarietyCloneId",
                table: "Trees");
        }
    }
}
