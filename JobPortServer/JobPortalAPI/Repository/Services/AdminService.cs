using JobPortalAPI.DataBase;
using JobPortalAPI.Model;
using JobPortalAPI.Repository.Interface;
using Microsoft.EntityFrameworkCore;

namespace JobPortalAPI.Repository.Services
{
    public class AdminService : IAdminService
    {
        PortelDBContext _db;
        public AdminService(PortelDBContext portelDBContext) 
        { 
        
            _db = portelDBContext;
        
        }
        public async Task<Admin> GetAdmin(int regAccountId)
        {
            Admin admin = await _db.Admins.FirstOrDefaultAsync(a => a.RegAccountId == regAccountId);
            if (admin == null)
            {
                Admin newAdmin= new Admin()
                {
                    RegAccountId = regAccountId
                };
                _db.Admins.Add(newAdmin);
                _db.SaveChanges();  
            }

            return await _db.Admins.FirstOrDefaultAsync(a=>a.RegAccountId==regAccountId);
            
        }

        public async Task<bool> UpdateAdmin(Admin admin)
        {
            Admin oldAdmin= await _db.Admins.FirstOrDefaultAsync(a=>a.AdminId==admin.AdminId);

            if(oldAdmin==null)
            {
                return false;
            }
            oldAdmin.Name = admin.Name;
            oldAdmin.Address = admin.Address;
            oldAdmin.DocumentURL = admin.DocumentURL;
            oldAdmin.ProfileImg= admin.ProfileImg;
            await _db.SaveChangesAsync();

            return true;
        }
    }
}
