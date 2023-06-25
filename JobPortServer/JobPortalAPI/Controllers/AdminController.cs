using JobPortalAPI.Model;
using JobPortalAPI.Repository.Interface;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JobPortalAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AdminController : ControllerBase
    {
        IAdminService _adminService;
        public AdminController(IAdminService adminService) 
        { 
        
            _adminService = adminService;
        
        }

        [HttpGet]
        [Authorize]
        public Task<Admin> GetAdmin(int regAccountId) 
        { 
        
            return _adminService.GetAdmin(regAccountId);    
        }

        [HttpPost]

        public Task<bool> UpdateAdmin([FromBody] Admin admin)
        {
            return _adminService.UpdateAdmin(admin);
        }
    }
}
