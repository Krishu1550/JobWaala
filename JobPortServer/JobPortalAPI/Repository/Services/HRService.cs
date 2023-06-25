using JobPortalAPI.DataBase;
using JobPortalAPI.Model;
using JobPortalAPI.Repository.Interface;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics.Contracts;

namespace JobPortalAPI.Repository.Services
{
    public class HRService : IHRServices
    {
        PortelDBContext _db;
        public HRService(PortelDBContext portelDBContext) 
        { 
            _db = portelDBContext;
        
        }

        public async Task<IEnumerable<HumanResourse>> GetHumanAll()
        {
            return await _db.HumanResourses.ToListAsync();
        }

        public async Task<HumanResourse> GetHumanResource(int RegAcountid)

        {
            HumanResourse humanResource= await _db.HumanResourses.FirstOrDefaultAsync(a => a.RegAccountId == RegAcountid);
            if(humanResource == null) 
            { 
            
                    HumanResourse newhumanResource = new HumanResourse()
                    {
                        RegAccountId = RegAcountid,
                    };

               await  _db.HumanResourses.AddAsync(newhumanResource);
                await _db.SaveChangesAsync();
            }
            return humanResource;
        }

        public async Task<bool> UpdateHumanResource(HumanResourse newHumanResourse)
        {
            HumanResourse humanResourse= await _db.HumanResourses
                .FirstOrDefaultAsync(a=>a.HrId==newHumanResourse.HrId);
            if(humanResourse == null) 
            { 
            
                return false;
            
            
            }

            humanResourse.Address=newHumanResourse.Address;
            humanResourse.Email=newHumanResourse.Email;
            humanResourse.Name=newHumanResourse.Name;
            humanResourse.ProfileImg=newHumanResourse.ProfileImg;
            humanResourse.Organization=newHumanResourse.Organization;

           await  _db.SaveChangesAsync();


            return true;    
        }
    }
}
