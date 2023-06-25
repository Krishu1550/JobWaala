using JobPortalAPI.DataBase;
using JobPortalAPI.Model;
using JobPortalAPI.Model.DTO;
using JobPortalAPI.Repository.Interface;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace JobPortalAPI.Repository.Services
{
    public class AccountService : IAccountService
    {
        private readonly PortelDBContext _db;
        public AccountService(PortelDBContext portelDBContext) {
        _db=portelDBContext;    
                }
        public bool ForgetPassword(ForgetPasswordDto Account)
        {
            RegAccount authAccount = _db.Accounts.FirstOrDefault(a => a.UserEmail == Account.UserEmail); 
            if (authAccount != null) 
            {
                return false;
            }
            if(authAccount.PhoneNumber.Equals(Account.PhoneNumber)) 
            {
                authAccount.Password = Account.NewPassword;
                _db.SaveChanges();
                return true;
            }
            return false;

        }

        public RegAccount Login(AuthAccount Account)
        {
            RegAccount regAccount = _db.Accounts.FirstOrDefault(a => a.UserEmail==Account.UserEmail 
            && a.Password==Account.Password);
            if(regAccount != null) {
                return regAccount;
            }
             return null;
            
        }

        public bool Registration(RegAccount Account)
        {
           
                _db.Accounts.Add(Account);
                _db.SaveChanges();
                return true;
           
        }

   
    }
}
