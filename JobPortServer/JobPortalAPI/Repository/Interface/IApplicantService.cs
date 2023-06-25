using JobPortalAPI.Model;

namespace JobPortalAPI.Repository.Interface
{
    public interface IApplicantService
    {
        public Task<IEnumerable<Applicant>> GetApplicantAll();    
        public  Task<Applicant> GetApplicant(int RegAccountId);
        public Task<bool> UpdateApplicant(Applicant applicant);   
    }
}
