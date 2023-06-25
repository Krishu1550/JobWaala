using JobPortalAPI.Model;
using JobPortalAPI.Repository.Interface;
using JobPortalAPI.Repository.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobPortalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplyJobController : ControllerBase
    {
        IApplicantJobService _applicantjobService;
        public ApplyJobController(IApplicantJobService applicantJobService)
        {
            _applicantjobService = applicantJobService; 
        }

        [HttpPost]
        [Route("applyjob")]
        public async Task<bool> ApplyJob([FromBody] ApplicantJob applicantJob)
        {

            return await _applicantjobService.ApplyJobAsync(applicantJob);
        }
        [HttpPost]
        [Route("rollbackjob")]
        public async Task<bool> RollBackJob([FromBody] ApplicantJob applicantJob)
        {
            return await _applicantjobService.RoleBackJobAsync(applicantJob);
        }
        [Route("getjobbyapplicantid/{applicantid}")]
        [HttpGet]
       
        public async Task<IEnumerable<Job>> GetJobBbyApplicantId(int applicantid)
        {
                return await _applicantjobService.GetJobByApplicantId(applicantid);

        }
        [HttpGet]
        [Route("getapplicantbyjobid/{jobid}")]
        public async Task<IEnumerable<Applicant>> GetApplicantByJobId(int jobid)
        {
            return await _applicantjobService.GetApplicantByJobId(jobid);
        }

        
    }
}
