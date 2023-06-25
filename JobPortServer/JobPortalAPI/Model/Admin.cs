using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace JobPortalAPI.Model
{
    public class Admin
    {


        [Key]
        public int AdminId { get; set; }

        public string Name { get; set; }

        public string ProfileImg { get; set; }

        public string Address { get; set; }

        public string DocumentURL { get; set; }


        [ForeignKey("RegAccount")]
        public int RegAccountId { get; set; }
        public RegAccount? RegAccount { get; set; }
     
    }
}
