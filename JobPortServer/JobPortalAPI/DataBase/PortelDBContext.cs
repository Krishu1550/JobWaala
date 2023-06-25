using JobPortalAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace JobPortalAPI.DataBase
{
    public class PortelDBContext:DbContext
    {
        public PortelDBContext(DbContextOptions<PortelDBContext> options):base(options)
        {
            
        }



        public DbSet<RegAccount> Accounts { get; set; }
        public DbSet<Applicant> Applicants { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<HumanResourse> HumanResourses { get; set; }
        public DbSet<ApplicantJob> ApplicantJobs { get; set; }  

        public DbSet<Admin> Admins { get; set; }    
    }
}
