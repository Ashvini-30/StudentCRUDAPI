#region usings

using System.ComponentModel.DataAnnotations;

#endregion

namespace WebApplication3.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }

        [Required]
        public string SubjectName { get; set; } 
    }
}