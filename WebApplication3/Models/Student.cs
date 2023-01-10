#region usings

using System.ComponentModel.DataAnnotations;

#endregion

namespace WebApplication3.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required(ErrorMessage = "First Name is Required")]
        public string FirstName { get; set; }

        [Required(ErrorMessage = "Last Name is Required")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Email id is required")]     
        public string Email { get; set; }

        [MaxLength(10)]
        public string MobileNumber { get; set; }      


    }
}