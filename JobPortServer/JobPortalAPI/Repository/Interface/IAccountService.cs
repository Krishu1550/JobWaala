using JobPortalAPI.Model;
using JobPortalAPI.Model.DTO;

namespace JobPortalAPI.Repository.Interface
{
    public interface IAccountService
    {

        public RegAccount Login(AuthAccount Account);
        public bool Registration(RegAccount Account);

        public bool ForgetPassword(ForgetPasswordDto Account);
        
 


    }
}
