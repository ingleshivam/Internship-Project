using Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Infra
{
    public class CompanyContext : DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> cc) : base(cc)
        {

        }

        protected override void OnModelCreating(ModelBuilder mb)
        {

            foreach(var relationship in mb.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }

            mb.Entity<Admin>().HasData(
                new Admin() { AdminID = 1, FirstName = "Shivam", LastName = "Ingle", EmailID = "ingleshivam@gmail.com", MobileNumber = "9146721757", Password = "Shivam@2001" }
                );
        }
        public DbSet<Admin> Admins { set; get; }
        public DbSet<Country> Countries { set; get; }
        public DbSet<State> States { set; get; }
        public DbSet<City> Cities { set; get; }
        public DbSet<AcceptInvestment> AcceptInvestments { set; get; }
        public DbSet<Budget> Budgets { set; get; }
        public DbSet<Category> Categories { set; get; }
        public DbSet<DocumentType> DocumentTypes { set; get; }
        public DbSet<Idea> Ideas { set; get; }
        public DbSet<IdeaDocuments> IdeaDocuments { set; get; }
        public DbSet<IdeaRisk> IdeaRisks { set; get; }
        public DbSet<InvestmentPayment> InvestmentPayments { set; get; }
        public DbSet<Investor> Investors { set; get; }
        public DbSet<InvestorDocument> InvestorDocuments { set; get; }
        public DbSet<InvestorTC> InvestorTCs { set; get; }
        public DbSet<IVRequest> IVRequests { set; get; }
        public DbSet<Member> Members { set; get; }
        public DbSet<PreviousWork> PreviousWorks { set; get; }
        public DbSet<Query> Queries { set; get; }
        public DbSet<Solution> Solutions { set; get; }
        public DbSet<Stages> Stages { set; get; }
        public DbSet<SubCategory> SubCategories { set; get; }
        public DbSet<User> Users { set; get; }
        public DbSet<UserTC> UserTCs { set; get; }
        public DbSet<WorkClosure> WorkClosures { set; get; }
        public DbSet<WorkProgress> WorkProgresses { set; get; }

    }
}