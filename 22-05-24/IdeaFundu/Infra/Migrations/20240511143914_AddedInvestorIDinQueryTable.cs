using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddedInvestorIDinQueryTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "InvestorID",
                table: "QueryTbl",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_QueryTbl_InvestorID",
                table: "QueryTbl",
                column: "InvestorID");

            migrationBuilder.AddForeignKey(
                name: "FK_QueryTbl_InvestorTbl_InvestorID",
                table: "QueryTbl",
                column: "InvestorID",
                principalTable: "InvestorTbl",
                principalColumn: "InvestorID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QueryTbl_InvestorTbl_InvestorID",
                table: "QueryTbl");

            migrationBuilder.DropIndex(
                name: "IX_QueryTbl_InvestorID",
                table: "QueryTbl");

            migrationBuilder.DropColumn(
                name: "InvestorID",
                table: "QueryTbl");
        }
    }
}
