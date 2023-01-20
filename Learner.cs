using System.ComponentModel.DataAnnotations;

namespace CapenexisLearners22.Models
{
    public class Learner
    {
        public int Id { get; set; }
        public string? SurName { get; set; }
        public string? FirstName { get; set; }
        public string? NationalIdentityNumber { get; set; }
        public string? Course { get; set; }      
        public decimal? Price { get; set; }
    }
}
