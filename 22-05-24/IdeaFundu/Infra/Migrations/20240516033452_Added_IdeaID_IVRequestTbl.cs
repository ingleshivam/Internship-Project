using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class Added_IdeaID_IVRequestTbl : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "IdeaID",
                table: "IVRequestTbl",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_IVRequestTbl_IdeaID",
                table: "IVRequestTbl",
                column: "IdeaID");

            migrationBuilder.AddForeignKey(
                name: "FK_IVRequestTbl_IdeaTbl_IdeaID",
                table: "IVRequestTbl",
                column: "IdeaID",
                principalTable: "IdeaTbl",
                principalColumn: "IdeaID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IVRequestTbl_IdeaTbl_IdeaID",
                table: "IVRequestTbl");

            migrationBuilder.DropIndex(
                name: "IX_IVRequestTbl_IdeaID",
                table: "IVRequestTbl");

            migrationBuilder.DropColumn(
                name: "IdeaID",
                table: "IVRequestTbl");
        }
    }
}
