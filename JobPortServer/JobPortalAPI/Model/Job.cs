using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortalAPI.Model
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }
        public string Title { get; set; }
        public bool IsAvailiabe { get; set; } = true; 
        public string Description { get; set; } 
        public string Position {get; set; }

        public string CompanyName { get; set; }
        public string DocumentURL { get; set; }
        public string Location { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public  List<Skill>? SkillList { get; set;}=new List<Skill>();

        public List<ApplicantJob> ApplicantsJobList { get; set;} =new List<ApplicantJob>(); 
      


    }
}
