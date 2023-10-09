using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OrderManagementSystem.Models
{
    public class Order
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        [Required]
        public decimal OrderTotal { get; set; }

        [ForeignKey("User")]
        public string? UserId { get; set; }
        public System.DateTime OrderDateTime { get; set; }
    }
}
