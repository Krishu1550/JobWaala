using JobPortalAPI.Model;

namespace JobPortalAPI.Repository.Interface
{
    public interface IApplicantJobService
    {

        public Task<bool> ApplyJobAsync(ApplicantJob job);
        public Task<bool> RoleBackJobAsync(ApplicantJob job);

        public Task<IEnumerable<Job>>GetJobByApplicantId(int id );

        public Task<IEnumerable<Applicant>> GetApplicantByJobId(int id);
        
        


    }
}
