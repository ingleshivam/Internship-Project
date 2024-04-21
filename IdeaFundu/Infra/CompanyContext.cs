using Core;
using Microsoft.EntityFrameworkCore;

namespace Infra
{
    public class CompanyContext:DbContext
    {
        public CompanyContext(DbContextOptions<CompanyContext> cc):base(cc)
        {

        }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Admin>().HasData(
                new Admin() { AdminID=1, FirstName="Shivam", LastName = "Ingle", EmailID = "ingleshivam@gmail.com", MobileNumber = "9146721757", Password="Shivam@2001" }
                );
        }
        public DbSet<Admin> Admins { set; get; }
        public DbSet<Country> Countries { set; get; }
        public DbSet<State> States { set; get; }
        public DbSet<City> Cities { set; get; }


    }
}