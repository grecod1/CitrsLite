using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CitrsLite.Data.Migrations
{
    /// <inheritdoc />
    public partial class BudwoodTreeRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TreeId",
                table: "Budwoods",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Budwoods_TreeId",
                table: "Budwoods",
                column: "TreeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Budwoods_Trees_TreeId",
                table: "Budwoods",
                column: "TreeId",
                principalTable: "Trees",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Budwoods_Trees_TreeId",
                table: "Budwoods");

            migrationBuilder.DropIndex(
                name: "IX_Budwoods_TreeId",
                table: "Budwoods");

            migrationBuilder.DropColumn(
                name: "TreeId",
                table: "Budwoods");
        }
    }
}
