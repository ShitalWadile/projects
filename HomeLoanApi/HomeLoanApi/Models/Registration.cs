using System.ComponentModel.DataAnnotations;

namespace HomeLoanApi.Models
{
    public class Registration
    {
        [Key]
        public int User_Id { get; set; }

        public string Name { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public string Gender { get; set; }
        public string PWD { get; set; }

        


    }
}
//https://localhost:7026/