using JobPortalAPI.DataBase;
using JobPortalAPI.Model;
using JobPortalAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace JobPortalAPI.Repository.Services
{
    public class ApplicantService : IApplicantService
    {
        private readonly PortelDBContext _db;
        public ApplicantService(PortelDBContext portelDBContext) 
        { 
        
            _db = portelDBContext;
        
        }

        

        public async Task<Applicant> GetApplicant(int RegAccountId)
        {

          Applicant applicant= await _db.Applicants.FirstOrDefaultAsync(a=>a.RegAccountId==RegAccountId);

            if(applicant==null)
            {
                Applicant newapplicant = new Applicant()
                {
                    RegAccountId = RegAccountId,
                };

                _db.Applicants.Add(newapplicant);
                await _db.SaveChangesAsync();   
            }
            return applicant;


        }

        public async Task<IEnumerable<Applicant>> GetApplicantAll()
        {
            return await _db.Applicants.ToListAsync(); 
        }

        public async Task<bool> UpdateApplicant(Applicant applicant)
        {
            Applicant oldApplicant = await _db.Applicants.FirstOrDefaultAsync(a => a.RegAccountId == applicant.RegAccountId);

            if (oldApplicant == null)
            {
                return false;   
            }
            
            oldApplicant.Name = applicant.Name;
            oldApplicant.DocumentURL = applicant.DocumentURL;   
            oldApplicant.Address = applicant.Address;
            oldApplicant.ProfileImg = applicant.ProfileImg;
            await _db.SaveChangesAsync();   

            return true;
        }
    }
}
