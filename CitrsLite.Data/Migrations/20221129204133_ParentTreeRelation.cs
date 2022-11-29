using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CitrsLite.Data.Migrations
{
    /// <inheritdoc />
    public partial class ParentTreeRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ParentTreeId",
                table: "Trees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Trees_ParentTreeId",
                table: "Trees",
                column: "ParentTreeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Trees_Trees_ParentTreeId",
                table: "Trees",
                column: "ParentTreeId",
                principalTable: "Trees",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Trees_Trees_ParentTreeId",
                table: "Trees");

            migrationBuilder.DropIndex(
                name: "IX_Trees_ParentTreeId",
                table: "Trees");

            migrationBuilder.DropColumn(
                name: "ParentTreeId",
                table: "Trees");
        }
    }
}
