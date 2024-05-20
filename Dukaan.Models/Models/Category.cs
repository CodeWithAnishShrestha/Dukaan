using System.ComponentModel.DataAnnotations;

namespace Dukaan.Models.Models
{
    public class Category
    {
        [Key]
        [Required]
        public int CategoryId { get; set; }

        [Required]
        public string CategoryName { get; set; }

        [Required]
        [StringLength(255)]
        public string ImageUrl { get; set; }
    }
}