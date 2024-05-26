using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class AddedCCSTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CountryTbl",
                columns: table => new
                {
                    CountryID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryTbl", x => x.CountryID);
                });

            migrationBuilder.CreateTable(
                name: "States",
                columns: table => new
                {
                    StateID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StateName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CountryID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_States", x => x.StateID);
                    table.ForeignKey(
                        name: "FK_States_CountryTbl_CountryID",
                        column: x => x.CountryID,
                        principalTable: "CountryTbl",
                        principalColumn: "CountryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CityTbl",
                columns: table => new
                {
                    CityID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CityName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StateID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CityTbl", x => x.CityID);
                    table.ForeignKey(
                        name: "FK_CityTbl_States_StateID",
                        column: x => x.StateID,
                        principalTable: "States",
                        principalColumn: "StateID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CityTbl_StateID",
                table: "CityTbl",
                column: "StateID");

            migrationBuilder.CreateIndex(
                name: "IX_States_CountryID",
                table: "States",
                column: "CountryID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CityTbl");

            migrationBuilder.DropTable(
                name: "States");

            migrationBuilder.DropTable(
                name: "CountryTbl");
        }
    }
}
