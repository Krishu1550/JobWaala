using JobPortalAPI.DataBase;
using JobPortalAPI.Model;
using JobPortalAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace JobPortalAPI.Repository.Services
{
    public class JobService : IJobService
    {
        private readonly PortelDBContext _db;
        public JobService(PortelDBContext portelDBContext)
        {
            _db = portelDBContext;  
        }
        public bool CreateJob(Job job)
        {
            _db.Jobs.Add(job);  

            _db.SaveChanges();
            return true;    
        }

        public bool DeleteJob(int jobId)
        {
            Job job = _db.Jobs.FirstOrDefault(j => j.JobId == jobId);
            _db.Jobs.Remove(job);
            _db.SaveChangesAsync();
            return true;    

        }

        public IEnumerable<Job> GetJobAll()
        {

            return _db.Jobs.ToList();   
        }

        public IEnumerable<Job> GetJobByCatogery(string catogeryName)
        {
          bool isCatogery=  Enum.TryParse(catogeryName.ToLower(), true, out CategoryType categoryenumName);
            if(!isCatogery) {
                return null;
            }
           return _db.Jobs.Include(c => c.Category).Where(j => j.Category.CategoryName == categoryenumName);
        }

        public Job GetJobById(int jobId)
        {
            return _db.Jobs.FirstOrDefault(c=>c.JobId==jobId);
        }

        public bool UpdateJob(Job job)
        {
          Job oldJob= _db.Jobs.FirstOrDefault(j=>j.JobId==job.JobId);   

            if(oldJob==null)
            {
                return false;
            }
            
            oldJob.CategoryId = job.CategoryId; 
            oldJob.IsAvailiabe=job.IsAvailiabe;
            oldJob.Description= job.Description;
            oldJob.Position=job.Position;
            oldJob.Location=job.Location;
            oldJob.CompanyName=job.CompanyName;
            oldJob.DocumentURL=job.DocumentURL;
            oldJob.Title=job.Title; 

            _db.SaveChanges();
            return true;

        }
    }
}
