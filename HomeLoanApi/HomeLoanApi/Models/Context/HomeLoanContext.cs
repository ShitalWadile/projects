using Microsoft.EntityFrameworkCore;

namespace HomeLoanApi.Models.Context
{
    public class HomeLoanContext:DbContext
    {
        public HomeLoanContext(DbContextOptions<HomeLoanContext>options):base(options) 
        { 
        
        }
        public DbSet<User> Users { get; set; }
        public DbSet<ApplicationForm> ApplicationForms { get; set; }

        public DbSet<LoanDetails> Loans { get; set; }

        public DbSet<Registration> Register { get; set; }
    }
}
