using JobPortalAPI.Model;

namespace JobPortalAPI.Repository.Interface
{
    public interface IJobService
    {

        public bool CreateJob(Job job);

        public IEnumerable<Job> GetJobAll();

        public Job GetJobById(int jobId);

        public IEnumerable<Job> GetJobByCatogery(string jobName);

        public bool DeleteJob(int jobId);

        public bool UpdateJob(Job job); 

        


    }
}
