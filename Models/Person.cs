using System.ComponentModel.DataAnnotations;

namespace NetAPI.Models
{
    public class Student
    {
        [Key]
        public Guid StudentID { get; set; }
        public required string StudentCode { get; set; }
        public required string FullName { get; set; }
        public int Age { get; set; }
        public string? Address { get; set; }
        [DataType(DataType.EmailAddress)]
        public required string Email { get; set; }
    }
}