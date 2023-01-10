#region usings

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#endregion

namespace WebApplication3.Models
{
    public class Mark
    {
        [Key]
        public int Id { get; set; }
 
        public int StudentId { get; set; }

        [ForeignKey("StudentId")]
        public virtual Student Students { get; set; }

        public int SubjectId { get; set; }

        [ForeignKey("SubjectId")]
        public virtual Subject Subjects { get; set; }

        [Required]
        public int Marks { get; set; }
    }

}