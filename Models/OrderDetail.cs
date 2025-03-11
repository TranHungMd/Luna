using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace Luna.Models
{
    public class OrderDetail
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        public int OrderId { get; set; }

        [ForeignKey("OrderId")]
        public Order Order { get; set; }

        [Required]
        public int ProductId { get; set; }

        [ForeignKey("ProductId")]
        public Product Product { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Quantity price cannot be negative.")]
        public int Quantity { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")] // Định dạng DECIMAL(18,2)
        [Range(0, double.MaxValue, ErrorMessage = "Price At Order Time cannot be negative.")]
        public decimal PriceAtOrderTime { get; set; }
    }
}
