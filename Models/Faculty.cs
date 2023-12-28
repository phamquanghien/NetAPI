using System.ComponentModel.DataAnnotations;

namespace NetAPI.Models
{
    public class Faculty
    {
        [Key]
        public Guid FacultyID { get; set; }
        public required string FacultyCode { get; set; }
        public required string FacultyName { get; set; }
    }
}