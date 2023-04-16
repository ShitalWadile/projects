using System.ComponentModel.DataAnnotations;

namespace HomeLoanApi.Models
{
    public class LoanDetails
    {
        [Key]
        public int Application_Id { get; set; }
        public string Name { get; set; }
        [Required]
        public double LoanAmount { get; set; }
        [Required]
        public double InterestRate { get; set; }
        [Required]
        public string LoanStatus { get; set; }
        [Required]
        public double Tenure { get; set; }

       
    }
}
