using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class RiskID_Removed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_IdeaTbl_IdeaRiskTbl_RiskID",
                table: "IdeaTbl");

            migrationBuilder.DropIndex(
                name: "IX_IdeaTbl_RiskID",
                table: "IdeaTbl");

            migrationBuilder.DropIndex(
                name: "IX_BudgetTbl_IdeaID",
                table: "BudgetTbl");

            migrationBuilder.DropColumn(
                name: "RiskID",
                table: "IdeaTbl");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "UserTbl",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "UserTbl",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "UserTbl",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "EmailID",
                table: "UserTbl",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetTbl_IdeaID",
                table: "BudgetTbl",
                column: "IdeaID",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_BudgetTbl_IdeaID",
                table: "BudgetTbl");

            migrationBuilder.AlterColumn<string>(
                name: "Password",
                table: "UserTbl",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "LastName",
                table: "UserTbl",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "FirstName",
                table: "UserTbl",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "EmailID",
                table: "UserTbl",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RiskID",
                table: "IdeaTbl",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.CreateIndex(
                name: "IX_IdeaTbl_RiskID",
                table: "IdeaTbl",
                column: "RiskID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_BudgetTbl_IdeaID",
                table: "BudgetTbl",
                column: "IdeaID");

            migrationBuilder.AddForeignKey(
                name: "FK_IdeaTbl_IdeaRiskTbl_RiskID",
                table: "IdeaTbl",
                column: "RiskID",
                principalTable: "IdeaRiskTbl",
                principalColumn: "RiskID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
