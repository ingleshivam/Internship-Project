using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infra.Migrations
{
    /// <inheritdoc />
    public partial class Added_New_Classes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CityTbl_States_StateID",
                table: "CityTbl");

            migrationBuilder.DropForeignKey(
                name: "FK_States_CountryTbl_CountryID",
                table: "States");

            migrationBuilder.CreateTable(
                name: "CategoryTbl",
                columns: table => new
                {
                    CategoryID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryTbl", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTypeTbl",
                columns: table => new
                {
                    DocumentTypeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocumentTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypeTbl", x => x.DocumentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "InvestorTbl",
                columns: table => new
                {
                    InvestorID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvestorAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvestorMobile = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityID = table.Column<long>(type: "bigint", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvestorEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortProfileDesc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvestorTbl", x => x.InvestorID);
                    table.ForeignKey(
                        name: "FK_InvestorTbl_CityTbl_CityID",
                        column: x => x.CityID,
                        principalTable: "CityTbl",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvestorTCTbl",
                columns: table => new
                {
                    InvestorTCID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvestorTCTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvestorTCDesc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvestorTCTbl", x => x.InvestorTCID);
                });

            migrationBuilder.CreateTable(
                name: "UserTbl",
                columns: table => new
                {
                    UserID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CityID = table.Column<long>(type: "bigint", nullable: false),
                    EmailID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MobileNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortProfileDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EducationDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Pincode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTbl", x => x.UserID);
                    table.ForeignKey(
                        name: "FK_UserTbl_CityTbl_CityID",
                        column: x => x.CityID,
                        principalTable: "CityTbl",
                        principalColumn: "CityID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserTCTbl",
                columns: table => new
                {
                    UserTCID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserTCTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    USerTCDesc = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTCTbl", x => x.UserTCID);
                });

            migrationBuilder.CreateTable(
                name: "SubCategoryTbl",
                columns: table => new
                {
                    SubCategoryID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SubCategoryName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CategoryID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategoryTbl", x => x.SubCategoryID);
                    table.ForeignKey(
                        name: "FK_SubCategoryTbl_CategoryTbl_CategoryID",
                        column: x => x.CategoryID,
                        principalTable: "CategoryTbl",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvestorDocumentTbl",
                columns: table => new
                {
                    InvestorDocumentID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    isOrganization = table.Column<bool>(type: "bit", nullable: false),
                    isNRI = table.Column<bool>(type: "bit", nullable: false),
                    CIN = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvestorID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvestorDocumentTbl", x => x.InvestorDocumentID);
                    table.ForeignKey(
                        name: "FK_InvestorDocumentTbl_InvestorTbl_InvestorID",
                        column: x => x.InvestorID,
                        principalTable: "InvestorTbl",
                        principalColumn: "InvestorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IVRequestTbl",
                columns: table => new
                {
                    IVRequestID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IVRequestDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InvestorID = table.Column<long>(type: "bigint", nullable: false),
                    AmountToBeInvested = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IVRequestTbl", x => x.IVRequestID);
                    table.ForeignKey(
                        name: "FK_IVRequestTbl_InvestorTbl_InvestorID",
                        column: x => x.InvestorID,
                        principalTable: "InvestorTbl",
                        principalColumn: "InvestorID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PreviousWorkTbl",
                columns: table => new
                {
                    PreviousWorkID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WorkDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Duration = table.Column<long>(type: "bigint", nullable: false),
                    TentativeBudget = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    UserID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PreviousWorkTbl", x => x.PreviousWorkID);
                    table.ForeignKey(
                        name: "FK_PreviousWorkTbl_UserTbl_UserID",
                        column: x => x.UserID,
                        principalTable: "UserTbl",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AcceptInvestmentTbl",
                columns: table => new
                {
                    AcceptIVID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AcceptIVDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IVRequestID = table.Column<long>(type: "bigint", nullable: false),
                    AmountAccepted = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    CloseBeforeDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcceptInvestmentTbl", x => x.AcceptIVID);
                    table.ForeignKey(
                        name: "FK_AcceptInvestmentTbl_IVRequestTbl_IVRequestID",
                        column: x => x.IVRequestID,
                        principalTable: "IVRequestTbl",
                        principalColumn: "IVRequestID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "InvestmentPaymentTbl",
                columns: table => new
                {
                    PaymentID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PaymentMode = table.Column<int>(type: "int", nullable: false),
                    AcceptIVID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InvestmentPaymentTbl", x => x.PaymentID);
                    table.ForeignKey(
                        name: "FK_InvestmentPaymentTbl_AcceptInvestmentTbl_AcceptIVID",
                        column: x => x.AcceptIVID,
                        principalTable: "AcceptInvestmentTbl",
                        principalColumn: "AcceptIVID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BudgetTbl",
                columns: table => new
                {
                    BudgetID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BudgetAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdeaID = table.Column<long>(type: "bigint", nullable: false),
                    MaximumInvestmentLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MinimumInvestmentLimit = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BudgetTbl", x => x.BudgetID);
                });

            migrationBuilder.CreateTable(
                name: "IdeaDocumentsTbl",
                columns: table => new
                {
                    IdeaDocumentID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Attachments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocumentTypeID = table.Column<long>(type: "bigint", nullable: false),
                    IdeaID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdeaDocumentsTbl", x => x.IdeaDocumentID);
                    table.ForeignKey(
                        name: "FK_IdeaDocumentsTbl_DocumentTypeTbl_DocumentTypeID",
                        column: x => x.DocumentTypeID,
                        principalTable: "DocumentTypeTbl",
                        principalColumn: "DocumentTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "IdeaRiskTbl",
                columns: table => new
                {
                    RiskID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdeaID = table.Column<long>(type: "bigint", nullable: false),
                    RiskTitle = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RiskDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RiskLevel = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdeaRiskTbl", x => x.RiskID);
                });

            migrationBuilder.CreateTable(
                name: "IdeaTbl",
                columns: table => new
                {
                    IdeaID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IdeaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdeaDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RiskID = table.Column<long>(type: "bigint", nullable: false),
                    SubCategoryID = table.Column<long>(type: "bigint", nullable: false),
                    UserID = table.Column<long>(type: "bigint", nullable: false),
                    PhotoFilePath = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IdeaTbl", x => x.IdeaID);
                    table.ForeignKey(
                        name: "FK_IdeaTbl_IdeaRiskTbl_RiskID",
                        column: x => x.RiskID,
                        principalTable: "IdeaRiskTbl",
                        principalColumn: "RiskID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IdeaTbl_SubCategoryTbl_SubCategoryID",
                        column: x => x.SubCategoryID,
                        principalTable: "SubCategoryTbl",
                        principalColumn: "SubCategoryID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_IdeaTbl_UserTbl_UserID",
                        column: x => x.UserID,
                        principalTable: "UserTbl",
                        principalColumn: "UserID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MemberTbl",
                columns: table => new
                {
                    MemberID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MemberName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MemberRole = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortProfileDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdeaID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MemberTbl", x => x.MemberID);
                    table.ForeignKey(
                        name: "FK_MemberTbl_IdeaTbl_IdeaID",
                        column: x => x.IdeaID,
                        principalTable: "IdeaTbl",
                        principalColumn: "IdeaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "QueryTbl",
                columns: table => new
                {
                    QueryID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    QueryDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdeaID = table.Column<long>(type: "bigint", nullable: false),
                    QueryDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QueryTbl", x => x.QueryID);
                    table.ForeignKey(
                        name: "FK_QueryTbl_IdeaTbl_IdeaID",
                        column: x => x.IdeaID,
                        principalTable: "IdeaTbl",
                        principalColumn: "IdeaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "StagesTbl",
                columns: table => new
                {
                    StageID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StageName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StageDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdeaID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StagesTbl", x => x.StageID);
                    table.ForeignKey(
                        name: "FK_StagesTbl_IdeaTbl_IdeaID",
                        column: x => x.IdeaID,
                        principalTable: "IdeaTbl",
                        principalColumn: "IdeaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkClosureTbl",
                columns: table => new
                {
                    WorkClosureID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClosureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClosureStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdeaID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkClosureTbl", x => x.WorkClosureID);
                    table.ForeignKey(
                        name: "FK_WorkClosureTbl_IdeaTbl_IdeaID",
                        column: x => x.IdeaID,
                        principalTable: "IdeaTbl",
                        principalColumn: "IdeaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkProgressTbl",
                columns: table => new
                {
                    WorkProgressID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CurrentStatus = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpectedCompletionDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Remarks = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdeaID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkProgressTbl", x => x.WorkProgressID);
                    table.ForeignKey(
                        name: "FK_WorkProgressTbl_IdeaTbl_IdeaID",
                        column: x => x.IdeaID,
                        principalTable: "IdeaTbl",
                        principalColumn: "IdeaID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SolutionTbl",
                columns: table => new
                {
                    SolutionID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SolutionDesc = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QueryID = table.Column<long>(type: "bigint", nullable: false),
                    SolutionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SolutionTbl", x => x.SolutionID);
                    table.ForeignKey(
                        name: "FK_SolutionTbl_QueryTbl_QueryID",
                        column: x => x.QueryID,
                        principalTable: "QueryTbl",
                        principalColumn: "QueryID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcceptInvestmentTbl_IVRequestID",
                table: "AcceptInvestmentTbl",
                column: "IVRequestID");

            migrationBuilder.CreateIndex(
                name: "IX_BudgetTbl_IdeaID",
                table: "BudgetTbl",
                column: "IdeaID");

            migrationBuilder.CreateIndex(
                name: "IX_IdeaDocumentsTbl_DocumentTypeID",
                table: "IdeaDocumentsTbl",
                column: "DocumentTypeID");

            migrationBuilder.CreateIndex(
                name: "IX_IdeaDocumentsTbl_IdeaID",
                table: "IdeaDocumentsTbl",
                column: "IdeaID");

            migrationBuilder.CreateIndex(
                name: "IX_IdeaRiskTbl_IdeaID",
                table: "IdeaRiskTbl",
                column: "IdeaID");

            migrationBuilder.CreateIndex(
                name: "IX_IdeaTbl_RiskID",
                table: "IdeaTbl",
                column: "RiskID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_IdeaTbl_SubCategoryID",
                table: "IdeaTbl",
                column: "SubCategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_IdeaTbl_UserID",
                table: "IdeaTbl",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_InvestmentPaymentTbl_AcceptIVID",
                table: "InvestmentPaymentTbl",
                column: "AcceptIVID");

            migrationBuilder.CreateIndex(
                name: "IX_InvestorDocumentTbl_InvestorID",
                table: "InvestorDocumentTbl",
                column: "InvestorID");

            migrationBuilder.CreateIndex(
                name: "IX_InvestorTbl_CityID",
                table: "InvestorTbl",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_IVRequestTbl_InvestorID",
                table: "IVRequestTbl",
                column: "InvestorID");

            migrationBuilder.CreateIndex(
                name: "IX_MemberTbl_IdeaID",
                table: "MemberTbl",
                column: "IdeaID");

            migrationBuilder.CreateIndex(
                name: "IX_PreviousWorkTbl_UserID",
                table: "PreviousWorkTbl",
                column: "UserID");

            migrationBuilder.CreateIndex(
                name: "IX_QueryTbl_IdeaID",
                table: "QueryTbl",
                column: "IdeaID");

            migrationBuilder.CreateIndex(
                name: "IX_SolutionTbl_QueryID",
                table: "SolutionTbl",
                column: "QueryID");

            migrationBuilder.CreateIndex(
                name: "IX_StagesTbl_IdeaID",
                table: "StagesTbl",
                column: "IdeaID");

            migrationBuilder.CreateIndex(
                name: "IX_SubCategoryTbl_CategoryID",
                table: "SubCategoryTbl",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_UserTbl_CityID",
                table: "UserTbl",
                column: "CityID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkClosureTbl_IdeaID",
                table: "WorkClosureTbl",
                column: "IdeaID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkProgressTbl_IdeaID",
                table: "WorkProgressTbl",
                column: "IdeaID");

            migrationBuilder.AddForeignKey(
                name: "FK_CityTbl_States_StateID",
                table: "CityTbl",
                column: "StateID",
                principalTable: "States",
                principalColumn: "StateID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_States_CountryTbl_CountryID",
                table: "States",
                column: "CountryID",
                principalTable: "CountryTbl",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_BudgetTbl_IdeaTbl_IdeaID",
                table: "BudgetTbl",
                column: "IdeaID",
                principalTable: "IdeaTbl",
                principalColumn: "IdeaID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IdeaDocumentsTbl_IdeaTbl_IdeaID",
                table: "IdeaDocumentsTbl",
                column: "IdeaID",
                principalTable: "IdeaTbl",
                principalColumn: "IdeaID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_IdeaRiskTbl_IdeaTbl_IdeaID",
                table: "IdeaRiskTbl",
                column: "IdeaID",
                principalTable: "IdeaTbl",
                principalColumn: "IdeaID",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CityTbl_States_StateID",
                table: "CityTbl");

            migrationBuilder.DropForeignKey(
                name: "FK_States_CountryTbl_CountryID",
                table: "States");

            migrationBuilder.DropForeignKey(
                name: "FK_IdeaRiskTbl_IdeaTbl_IdeaID",
                table: "IdeaRiskTbl");

            migrationBuilder.DropTable(
                name: "BudgetTbl");

            migrationBuilder.DropTable(
                name: "IdeaDocumentsTbl");

            migrationBuilder.DropTable(
                name: "InvestmentPaymentTbl");

            migrationBuilder.DropTable(
                name: "InvestorDocumentTbl");

            migrationBuilder.DropTable(
                name: "InvestorTCTbl");

            migrationBuilder.DropTable(
                name: "MemberTbl");

            migrationBuilder.DropTable(
                name: "PreviousWorkTbl");

            migrationBuilder.DropTable(
                name: "SolutionTbl");

            migrationBuilder.DropTable(
                name: "StagesTbl");

            migrationBuilder.DropTable(
                name: "UserTCTbl");

            migrationBuilder.DropTable(
                name: "WorkClosureTbl");

            migrationBuilder.DropTable(
                name: "WorkProgressTbl");

            migrationBuilder.DropTable(
                name: "DocumentTypeTbl");

            migrationBuilder.DropTable(
                name: "AcceptInvestmentTbl");

            migrationBuilder.DropTable(
                name: "QueryTbl");

            migrationBuilder.DropTable(
                name: "IVRequestTbl");

            migrationBuilder.DropTable(
                name: "InvestorTbl");

            migrationBuilder.DropTable(
                name: "IdeaTbl");

            migrationBuilder.DropTable(
                name: "IdeaRiskTbl");

            migrationBuilder.DropTable(
                name: "SubCategoryTbl");

            migrationBuilder.DropTable(
                name: "UserTbl");

            migrationBuilder.DropTable(
                name: "CategoryTbl");

            migrationBuilder.AddForeignKey(
                name: "FK_CityTbl_States_StateID",
                table: "CityTbl",
                column: "StateID",
                principalTable: "States",
                principalColumn: "StateID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_States_CountryTbl_CountryID",
                table: "States",
                column: "CountryID",
                principalTable: "CountryTbl",
                principalColumn: "CountryID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
