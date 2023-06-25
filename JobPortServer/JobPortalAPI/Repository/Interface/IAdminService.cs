using JobPortalAPI.Model;

namespace JobPortalAPI.Repository.Interface
{
    public interface IAdminService
    {


        public Task<Admin> GetAdmin(int regAccountId);
        public Task<bool> UpdateAdmin(Admin admin); 


    }
}
