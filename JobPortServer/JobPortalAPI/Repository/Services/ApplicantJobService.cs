using JobPortalAPI.DataBase;
using JobPortalAPI.Model;
using JobPortalAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace JobPortalAPI.Repository.Services
{
    public class ApplicantJobService : IApplicantJobService
    {
        PortelDBContext _db;
        public ApplicantJobService(PortelDBContext db)
        {
            _db = db;
        }

        public async Task<bool> ApplyJobAsync(ApplicantJob job)
        {
           if(job == null)
            {
                return false;
            }
           _db.ApplicantJobs.Add(job);
            _db.SaveChanges();
            return true;
        }

        public async Task<IEnumerable<Job>> GetJobByApplicantId(int id)
        {
           List<ApplicantJob> applicantJobs= await 
                _db.ApplicantJobs.Where(aj=>aj.ApplicantId
           ==id).ToListAsync();
            List<Job> jobs= applicantJobs.Select(aj=>aj.Job).ToList();

            return  jobs;

        }

        public async Task<IEnumerable<Applicant>> GetApplicantByJobId(int id)
        {
           List<ApplicantJob> applicantJob= await 
                _db.ApplicantJobs.Where(aj=>aj.JobId 
           == id).Include(a=>a.Applicant).ToListAsync();

            List<Applicant> applicants= applicantJob.Select(a=>a.Applicant).ToList();

            return applicants;
        }

        public async Task<bool> RoleBackJobAsync(ApplicantJob job)
        {
            ApplicantJob applicantJob= await 
                _db.ApplicantJobs.Where(aj=>aj.ApplicantJobId==
            job.JobId).FirstOrDefaultAsync();

            if(applicantJob==null) 
            {
                return false;
            
            }
            _db.ApplicantJobs.Remove(job);
            await _db.SaveChangesAsync();

            return true;
        }

       
    }
}
