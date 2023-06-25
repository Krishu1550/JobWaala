using JobPortalAPI.Model;
using JobPortalAPI.Repository.Interface;
using Microsoft.AspNetCore.Mvc;

namespace JobPortalAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HumanResourceController : Controller
    {
        IHRServices _hrServices;
        public HumanResourceController(IHRServices hrServices) 
        { 
            _hrServices = hrServices;
        
        
        }
        [HttpGet]
        
        public  async Task<IEnumerable<HumanResourse>> GetHumanAll()
        {
             return await _hrServices.GetHumanAll();
        }

        [HttpGet("{id}")]
        public async Task<HumanResourse> GetHumanResource(int id) 
        {
            return await _hrServices.GetHumanResource(id);
        
        }

        [HttpPost]

        public async Task<bool> UpdateHumanResource([FromBody] HumanResourse humanResourse)
        {
            return await _hrServices.UpdateHumanResource(humanResourse);
        }

       

        

  
    }
}
