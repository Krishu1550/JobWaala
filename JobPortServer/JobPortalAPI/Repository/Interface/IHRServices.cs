using JobPortalAPI.Model;

namespace JobPortalAPI.Repository.Interface
{
    public interface IHRServices
    {
        public Task<IEnumerable<HumanResourse>> GetHumanAll();

        public Task<HumanResourse> GetHumanResource(int id);
        public Task<bool> UpdateHumanResource(HumanResourse newHumanResourse);
    }
}
