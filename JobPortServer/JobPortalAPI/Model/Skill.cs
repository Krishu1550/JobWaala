using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace JobPortalAPI.Model
{
    public class Skill
    {
        [Key]
        public int SkillId { get; set; }
           
        public string Name { get; set; }

        [ForeignKey("Job")]
        public int JobId { get; set; }  
        public Job? Job { get; set; }    
    }
}
