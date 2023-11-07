using System.ComponentModel.DataAnnotations.Schema;

namespace Al_Iman.Models
{
    public class PatientReport
    {
        public int Id { get; set; }
        public string Diagnose { get; set; }

        public ApplicationUser Doctor { get; set; }
        public ApplicationUser Patient { get; set; }
        [NotMapped]
        public ICollection<PrescribedMedicine> PrescribedMedicine { get; set; }
    }
}