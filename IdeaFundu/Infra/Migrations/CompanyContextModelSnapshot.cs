﻿// <auto-generated />
using System;
using Infra;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infra.Migrations
{
    [DbContext(typeof(CompanyContext))]
    partial class CompanyContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.18")
                .HasAnnotation("Proxies:ChangeTracking", false)
                .HasAnnotation("Proxies:CheckEquality", false)
                .HasAnnotation("Proxies:LazyLoading", true)
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.AcceptInvestment", b =>
                {
                    b.Property<long>("AcceptIVID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("AcceptIVID"));

                    b.Property<string>("AcceptIVDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("AmountAccepted")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("CloseBeforeDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("IVRequestID")
                        .HasColumnType("bigint");

                    b.HasKey("AcceptIVID");

                    b.HasIndex("IVRequestID");

                    b.ToTable("AcceptInvestmentTbl");
                });

            modelBuilder.Entity("Core.Admin", b =>
                {
                    b.Property<long>("AdminID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("AdminID"));

                    b.Property<string>("EmailID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("AdminID");

                    b.ToTable("AdminTbl");

                    b.HasData(
                        new
                        {
                            AdminID = 1L,
                            EmailID = "ingleshivam@gmail.com",
                            FirstName = "Shivam",
                            LastName = "Ingle",
                            MobileNumber = "9146721757",
                            Password = "Shivam@2001"
                        });
                });

            modelBuilder.Entity("Core.Budget", b =>
                {
                    b.Property<long>("BudgetID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("BudgetID"));

                    b.Property<decimal>("BudgetAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("IdeaID")
                        .HasColumnType("bigint");

                    b.Property<decimal>("MaximumInvestmentLimit")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("MinimumInvestmentLimit")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("BudgetID");

                    b.HasIndex("IdeaID");

                    b.ToTable("BudgetTbl");
                });

            modelBuilder.Entity("Core.Category", b =>
                {
                    b.Property<long>("CategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CategoryID"));

                    b.Property<string>("CategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CategoryID");

                    b.ToTable("CategoryTbl");
                });

            modelBuilder.Entity("Core.City", b =>
                {
                    b.Property<long>("CityID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CityID"));

                    b.Property<string>("CityName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("StateID")
                        .HasColumnType("bigint");

                    b.HasKey("CityID");

                    b.HasIndex("StateID");

                    b.ToTable("CityTbl");
                });

            modelBuilder.Entity("Core.Country", b =>
                {
                    b.Property<long>("CountryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CountryID"));

                    b.Property<string>("CountryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CountryID");

                    b.ToTable("CountryTbl");
                });

            modelBuilder.Entity("Core.DocumentType", b =>
                {
                    b.Property<long>("DocumentTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("DocumentTypeId"));

                    b.Property<string>("DocumentTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DocumentTypeId");

                    b.ToTable("DocumentTypeTbl");
                });

            modelBuilder.Entity("Core.IVRequest", b =>
                {
                    b.Property<long>("IVRequestID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IVRequestID"));

                    b.Property<decimal>("AmountToBeInvested")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("IVRequestDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("InvestorID")
                        .HasColumnType("bigint");

                    b.HasKey("IVRequestID");

                    b.HasIndex("InvestorID");

                    b.ToTable("IVRequestTbl");
                });

            modelBuilder.Entity("Core.Idea", b =>
                {
                    b.Property<long>("IdeaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdeaID"));

                    b.Property<string>("IdeaDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdeaName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoFilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("RiskID")
                        .HasColumnType("bigint");

                    b.Property<long>("SubCategoryID")
                        .HasColumnType("bigint");

                    b.Property<long>("UserID")
                        .HasColumnType("bigint");

                    b.HasKey("IdeaID");

                    b.HasIndex("RiskID")
                        .IsUnique();

                    b.HasIndex("SubCategoryID");

                    b.HasIndex("UserID");

                    b.ToTable("IdeaTbl");
                });

            modelBuilder.Entity("Core.IdeaDocuments", b =>
                {
                    b.Property<long>("IdeaDocumentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("IdeaDocumentID"));

                    b.Property<string>("Attachments")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("DocumentTypeID")
                        .HasColumnType("bigint");

                    b.Property<long>("IdeaID")
                        .HasColumnType("bigint");

                    b.HasKey("IdeaDocumentID");

                    b.HasIndex("DocumentTypeID");

                    b.HasIndex("IdeaID");

                    b.ToTable("IdeaDocumentsTbl");
                });

            modelBuilder.Entity("Core.IdeaRisk", b =>
                {
                    b.Property<long>("RiskID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("RiskID"));

                    b.Property<long>("IdeaID")
                        .HasColumnType("bigint");

                    b.Property<string>("RiskDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RiskLevel")
                        .HasColumnType("int");

                    b.Property<string>("RiskTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RiskID");

                    b.HasIndex("IdeaID");

                    b.ToTable("IdeaRiskTbl");
                });

            modelBuilder.Entity("Core.InvestmentPayment", b =>
                {
                    b.Property<long>("PaymentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("PaymentID"));

                    b.Property<long>("AcceptIVID")
                        .HasColumnType("bigint");

                    b.Property<decimal>("PaymentAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("PaymentMode")
                        .HasColumnType("int");

                    b.HasKey("PaymentID");

                    b.HasIndex("AcceptIVID");

                    b.ToTable("InvestmentPaymentTbl");
                });

            modelBuilder.Entity("Core.Investor", b =>
                {
                    b.Property<long>("InvestorID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("InvestorID"));

                    b.Property<long>("CityID")
                        .HasColumnType("bigint");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InvestorAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InvestorEmail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InvestorMobile")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortProfileDesc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InvestorID");

                    b.HasIndex("CityID");

                    b.ToTable("InvestorTbl");
                });

            modelBuilder.Entity("Core.InvestorDocument", b =>
                {
                    b.Property<long>("InvestorDocumentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("InvestorDocumentID"));

                    b.Property<string>("CIN")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("InvestorID")
                        .HasColumnType("bigint");

                    b.Property<bool>("isNRI")
                        .HasColumnType("bit");

                    b.Property<bool>("isOrganization")
                        .HasColumnType("bit");

                    b.HasKey("InvestorDocumentID");

                    b.HasIndex("InvestorID");

                    b.ToTable("InvestorDocumentTbl");
                });

            modelBuilder.Entity("Core.InvestorTC", b =>
                {
                    b.Property<long>("InvestorTCID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("InvestorTCID"));

                    b.Property<string>("InvestorTCDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InvestorTCTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("InvestorTCID");

                    b.ToTable("InvestorTCTbl");
                });

            modelBuilder.Entity("Core.Member", b =>
                {
                    b.Property<long>("MemberID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("MemberID"));

                    b.Property<long>("IdeaID")
                        .HasColumnType("bigint");

                    b.Property<string>("MemberName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MemberRole")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortProfileDesc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MemberID");

                    b.HasIndex("IdeaID");

                    b.ToTable("MemberTbl");
                });

            modelBuilder.Entity("Core.PreviousWork", b =>
                {
                    b.Property<long>("PreviousWorkID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("PreviousWorkID"));

                    b.Property<long>("Duration")
                        .HasColumnType("bigint");

                    b.Property<decimal>("TentativeBudget")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("UserID")
                        .HasColumnType("bigint");

                    b.Property<string>("WorkDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PreviousWorkID");

                    b.HasIndex("UserID");

                    b.ToTable("PreviousWorkTbl");
                });

            modelBuilder.Entity("Core.Query", b =>
                {
                    b.Property<long>("QueryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("QueryID"));

                    b.Property<long>("IdeaID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("QueryDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("QueryDescription")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("QueryID");

                    b.HasIndex("IdeaID");

                    b.ToTable("QueryTbl");
                });

            modelBuilder.Entity("Core.Solution", b =>
                {
                    b.Property<long>("SolutionID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("SolutionID"));

                    b.Property<long>("QueryID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("SolutionDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("SolutionDesc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SolutionID");

                    b.HasIndex("QueryID");

                    b.ToTable("SolutionTbl");
                });

            modelBuilder.Entity("Core.Stages", b =>
                {
                    b.Property<long>("StageID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("StageID"));

                    b.Property<long>("IdeaID")
                        .HasColumnType("bigint");

                    b.Property<string>("StageDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StageName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StageID");

                    b.HasIndex("IdeaID");

                    b.ToTable("StagesTbl");
                });

            modelBuilder.Entity("Core.State", b =>
                {
                    b.Property<long>("StateID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("StateID"));

                    b.Property<long>("CountryID")
                        .HasColumnType("bigint");

                    b.Property<string>("StateName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("StateID");

                    b.HasIndex("CountryID");

                    b.ToTable("States");
                });

            modelBuilder.Entity("Core.SubCategory", b =>
                {
                    b.Property<long>("SubCategoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("SubCategoryID"));

                    b.Property<long>("CategoryID")
                        .HasColumnType("bigint");

                    b.Property<string>("SubCategoryName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SubCategoryID");

                    b.HasIndex("CategoryID");

                    b.ToTable("SubCategoryTbl");
                });

            modelBuilder.Entity("Core.User", b =>
                {
                    b.Property<long>("UserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("UserID"));

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CityID")
                        .HasColumnType("bigint");

                    b.Property<string>("EducationDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailID")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MobileNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pincode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ShortProfileDesc")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserID");

                    b.HasIndex("CityID");

                    b.ToTable("UserTbl");
                });

            modelBuilder.Entity("Core.UserTC", b =>
                {
                    b.Property<long>("UserTCID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("UserTCID"));

                    b.Property<string>("USerTCDesc")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserTCTitle")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserTCID");

                    b.ToTable("UserTCTbl");
                });

            modelBuilder.Entity("Core.WorkClosure", b =>
                {
                    b.Property<long>("WorkClosureID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("WorkClosureID"));

                    b.Property<DateTime>("ClosureDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ClosureStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("IdeaID")
                        .HasColumnType("bigint");

                    b.HasKey("WorkClosureID");

                    b.HasIndex("IdeaID");

                    b.ToTable("WorkClosureTbl");
                });

            modelBuilder.Entity("Core.WorkProgress", b =>
                {
                    b.Property<long>("WorkProgressID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("WorkProgressID"));

                    b.Property<string>("CurrentStatus")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ExpectedCompletionDate")
                        .HasColumnType("datetime2");

                    b.Property<long>("IdeaID")
                        .HasColumnType("bigint");

                    b.Property<string>("Remarks")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("WorkProgressID");

                    b.HasIndex("IdeaID");

                    b.ToTable("WorkProgressTbl");
                });

            modelBuilder.Entity("Core.AcceptInvestment", b =>
                {
                    b.HasOne("Core.IVRequest", "IVRequest")
                        .WithMany()
                        .HasForeignKey("IVRequestID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("IVRequest");
                });

            modelBuilder.Entity("Core.Budget", b =>
                {
                    b.HasOne("Core.Idea", "Idea")
                        .WithMany()
                        .HasForeignKey("IdeaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Idea");
                });

            modelBuilder.Entity("Core.City", b =>
                {
                    b.HasOne("Core.State", "State")
                        .WithMany()
                        .HasForeignKey("StateID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("State");
                });

            modelBuilder.Entity("Core.IVRequest", b =>
                {
                    b.HasOne("Core.Investor", "Investor")
                        .WithMany()
                        .HasForeignKey("InvestorID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Investor");
                });

            modelBuilder.Entity("Core.Idea", b =>
                {
                    b.HasOne("Core.IdeaRisk", "IdeaRisk")
                        .WithOne()
                        .HasForeignKey("Core.Idea", "RiskID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Core.SubCategory", "SubCategory")
                        .WithMany()
                        .HasForeignKey("SubCategoryID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Core.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("IdeaRisk");

                    b.Navigation("SubCategory");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.IdeaDocuments", b =>
                {
                    b.HasOne("Core.DocumentType", "DocumentType")
                        .WithMany()
                        .HasForeignKey("DocumentTypeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Core.Idea", "Idea")
                        .WithMany()
                        .HasForeignKey("IdeaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("DocumentType");

                    b.Navigation("Idea");
                });

            modelBuilder.Entity("Core.IdeaRisk", b =>
                {
                    b.HasOne("Core.Idea", "Idea")
                        .WithMany()
                        .HasForeignKey("IdeaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Idea");
                });

            modelBuilder.Entity("Core.InvestmentPayment", b =>
                {
                    b.HasOne("Core.AcceptInvestment", "AcceptInvestment")
                        .WithMany()
                        .HasForeignKey("AcceptIVID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("AcceptInvestment");
                });

            modelBuilder.Entity("Core.Investor", b =>
                {
                    b.HasOne("Core.City", "City")
                        .WithMany()
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Core.InvestorDocument", b =>
                {
                    b.HasOne("Core.Investor", "Investor")
                        .WithMany()
                        .HasForeignKey("InvestorID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Investor");
                });

            modelBuilder.Entity("Core.Member", b =>
                {
                    b.HasOne("Core.Idea", "Idea")
                        .WithMany()
                        .HasForeignKey("IdeaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Idea");
                });

            modelBuilder.Entity("Core.PreviousWork", b =>
                {
                    b.HasOne("Core.User", "User")
                        .WithMany()
                        .HasForeignKey("UserID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("Core.Query", b =>
                {
                    b.HasOne("Core.Idea", "Idea")
                        .WithMany()
                        .HasForeignKey("IdeaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Idea");
                });

            modelBuilder.Entity("Core.Solution", b =>
                {
                    b.HasOne("Core.Query", "Query")
                        .WithMany()
                        .HasForeignKey("QueryID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Query");
                });

            modelBuilder.Entity("Core.Stages", b =>
                {
                    b.HasOne("Core.Idea", "Idea")
                        .WithMany()
                        .HasForeignKey("IdeaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Idea");
                });

            modelBuilder.Entity("Core.State", b =>
                {
                    b.HasOne("Core.Country", "Country")
                        .WithMany("States")
                        .HasForeignKey("CountryID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Country");
                });

            modelBuilder.Entity("Core.SubCategory", b =>
                {
                    b.HasOne("Core.Category", "Category")
                        .WithMany("SubCategories")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Category");
                });

            modelBuilder.Entity("Core.User", b =>
                {
                    b.HasOne("Core.City", "City")
                        .WithMany()
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("City");
                });

            modelBuilder.Entity("Core.WorkClosure", b =>
                {
                    b.HasOne("Core.Idea", "Idea")
                        .WithMany()
                        .HasForeignKey("IdeaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Idea");
                });

            modelBuilder.Entity("Core.WorkProgress", b =>
                {
                    b.HasOne("Core.Idea", "Idea")
                        .WithMany()
                        .HasForeignKey("IdeaID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Idea");
                });

            modelBuilder.Entity("Core.Category", b =>
                {
                    b.Navigation("SubCategories");
                });

            modelBuilder.Entity("Core.Country", b =>
                {
                    b.Navigation("States");
                });
#pragma warning restore 612, 618
        }
    }
}
