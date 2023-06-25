using System.ComponentModel.DataAnnotations;

namespace JobPortalAPI.Model
{
    public class RegAccount
    {
        [Key]
        public int RegAccountID { get; set; }   
        public string UserEmail { get; set; }

        [MaxLength(10)]
        public string PhoneNumber { get; set; }
        
        public string Password { get; set; }   
        
        public string Role { get; set; }

    }
}
