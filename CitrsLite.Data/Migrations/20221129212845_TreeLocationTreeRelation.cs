using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CitrsLite.Data.Migrations
{
    /// <inheritdoc />
    public partial class TreeLocationTreeRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TreeId",
                table: "TreeLocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TreeLocations_TreeId",
                table: "TreeLocations",
                column: "TreeId");

            migrationBuilder.AddForeignKey(
                name: "FK_TreeLocations_Trees_TreeId",
                table: "TreeLocations",
                column: "TreeId",
                principalTable: "Trees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TreeLocations_Trees_TreeId",
                table: "TreeLocations");

            migrationBuilder.DropIndex(
                name: "IX_TreeLocations_TreeId",
                table: "TreeLocations");

            migrationBuilder.DropColumn(
                name: "TreeId",
                table: "TreeLocations");
        }
    }
}
