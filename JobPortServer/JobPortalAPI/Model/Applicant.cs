using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortalAPI.Model
{
    public class Applicant
    {
        [Key]
        public int ApplicantId { get; set; }

        public string Name { get; set; }

        public string ProfileImg { get; set; }

        public string Address { get; set; } 

        public string DocumentURL { get; set; } 


        [ForeignKey("RegAccount")]
        public int RegAccountId { get; set; }
        public RegAccount? RegAccount { get; set; }
        public List<ApplicantJob>?   JobList { get; set; }

    }
}
