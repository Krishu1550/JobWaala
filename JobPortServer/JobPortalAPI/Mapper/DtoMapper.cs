using AutoMapper;
using JobPortalAPI.Model;

namespace JobPortalAPI.Mapper
{
    public class DtoMapper:Profile
    {

        public DtoMapper() 
        { 
            CreateMap<RegAccount, RegAccountDto>().ReverseMap();
        
        }
    }
}
