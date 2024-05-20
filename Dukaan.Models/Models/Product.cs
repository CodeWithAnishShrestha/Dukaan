using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dukaan.Models.Models
{
    public class Product
    {
        [Key]
        [Required]
        public int ProductId { get; set; }

        [Required]
        [MaxLength(50)]
        public string ProductName { get; set; }

        [Required]
        [MaxLength(300)]
        public string ProductDescription { get; set; }

        [Required]
        public string ProductPrice { get; set; }

        public string DiscountedPrice { get; set; }

        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category Category { get; set; }

        public string ImageUrl { get; set; }

        [Required]
        public int ProductQty { get; set; }
    }
}