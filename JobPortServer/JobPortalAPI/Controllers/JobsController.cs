using JobPortalAPI.Model;
using JobPortalAPI.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace JobPortalAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class JobsController : Controller
    {
        private readonly IJobService _jobservice;

        public JobsController(IJobService jobservice)
        {

            _jobservice = jobservice;
        }
        [HttpPost]
        [Route("createjob")]
        public bool CreateJob([FromBody] Job job)
        {
            return _jobservice.CreateJob(job);
        }
        [HttpGet]
        [Route("getalljob")]
        public IEnumerable<Job> GetJobsAll()
        {
            return _jobservice.GetJobAll();
        }

        [HttpGet]
        [Route("getbycategory/{categoryType}")]
        public IEnumerable<Job> GetJobByCategory(string categoryType)
        {
            return _jobservice.GetJobByCatogery(categoryType);
        }
        [HttpGet]
        [Route("getbyid/{id}")]
        public Job GetJobById(int id) 
        { 
            return _jobservice.GetJobById(id);
        }
        [Route("deletejob/{id}")]
        [HttpDelete]
        public bool DeleteJob(int id ) 
        {
            return _jobservice.DeleteJob(id); 
        }

        [HttpPut]
        public bool UpdateJob([FromBody] Job job) 
        {

            return _jobservice.UpdateJob(job);
        }
    }
}
