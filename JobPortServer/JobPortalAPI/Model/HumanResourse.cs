using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortalAPI.Model
{
    public class HumanResourse
    {
        [Key]
        public int HrId { get; set; }
        public string Name { get; set; }

        public string ProfileImg { set; get; }
        public string Organization { get; set; }

        public string Email { get; set; }

        [ForeignKey("RegAccount")]
        public int RegAccountId { get; set; }

        public RegAccount? RegAccount { get; set; }
        public string Address { get; set; }




    }
}
