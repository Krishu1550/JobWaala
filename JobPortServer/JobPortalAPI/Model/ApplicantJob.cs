using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortalAPI.Model
{
    public class ApplicantJob
    {
        [Key]
        public int ApplicantJobId { get; set; }

        [ForeignKey("Job")]
        public int JobId { get; set; }
        public Job?  Job { get; set; }

        [ForeignKey("Applicant")]
        public int ApplicantId { get; set; }
        public Applicant? Applicant { get; set; }    
    }
}
