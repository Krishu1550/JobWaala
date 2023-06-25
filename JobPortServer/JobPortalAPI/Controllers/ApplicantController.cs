using JobPortalAPI.Model;
using JobPortalAPI.Repository.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobPortalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApplicantController : ControllerBase
    {
        private readonly IApplicantService _applicantService;

        public ApplicantController(IApplicantService applicantService)
        {
            _applicantService = applicantService;   
        }

        [HttpGet]
        public async Task<IEnumerable<Applicant>> GetApplicants()
        {
            return await _applicantService.GetApplicantAll();
        }


        [HttpGet("{RegAccountId}")]
        [Authorize]
        public async Task<Applicant> GetApplicant(int RegAccountId)
        {
              return  await _applicantService.GetApplicant(RegAccountId);
        }
        [HttpPost]
        public async Task< bool> UpdateApplicant([FromBody] Applicant applicant)
        {
            return await _applicantService.UpdateApplicant(applicant);    

        }

    }
}
