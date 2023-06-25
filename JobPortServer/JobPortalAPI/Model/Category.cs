using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;

namespace JobPortalAPI.Model
{
    public class Category
    {
        [Key]
        public int CategoryId { get; set; }
        [JsonConverter(typeof(StringEnumConverter))]
        public CategoryType CategoryName { get; set; }

        public List <Job>? jobs { get; set; }= new List<Job> ();
       
        
    }

    public enum CategoryType
    {
        it,
        managment,
        finicial,
        researchdevelopment

    }
}
