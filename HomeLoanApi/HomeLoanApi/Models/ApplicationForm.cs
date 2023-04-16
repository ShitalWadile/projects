using System;
using System.ComponentModel.DataAnnotations;

namespace HomeLoanApi.Models
{
    public class ApplicationForm
    {
        [Key]
        public int Application_Id { get; set; }
        [Required]
        public int User_Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string  Phone_No { get; set; }
        [Required] 
        public  int DOB { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public int Bank_Account_No { get; set; }
        [Required]
        public string Employeement_Type { get; set; }
        [Required]
        public string Organization_Name { get; set; }
        [Required]
        public string Property_Location { get; set; }
        [Required]
        public double Property_Value { get; set; }
        [Required]
        [RegularExpression(@"^(\d{12}|\d{16})$", ErrorMessage = "enter Integers only")]
        [Display(Name = "Adhar ID:")]
        public string  Aadharcard { get; set; }
        [Required]
        [RegularExpression(@"^[A-Z]{5}\d{4}[A-Z]{1}", ErrorMessage = "enter Valid Pan No")]
        [Display(Name = "Pan No:")]
        public string PanCard { get; set; }
        [Required]
        public string SalarySlip { get; set; }

       

    }
}

    

