using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace NetAPI.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        public Guid CustomerID { get; set; }
        public required string CustomerCode { get; set; }
        public required string CustomerName { get; set; }
    }
}