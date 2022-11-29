using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CitrsLite.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddTreeTypeAndTreeRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TreeTypeId",
                table: "Trees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Trees_TreeTypeId",
                table: "Trees",
                column: "TreeTypeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trees_TreeTypes_TreeTypeId",
                table: "Trees",
                column: "TreeTypeId",
                principalTable: "TreeTypes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trees_TreeTypes_TreeTypeId",
                table: "Trees");

            migrationBuilder.DropIndex(
                name: "IX_Trees_TreeTypeId",
                table: "Trees");

            migrationBuilder.DropColumn(
                name: "TreeTypeId",
                table: "Trees");
        }
    }
}
