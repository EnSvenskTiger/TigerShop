using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TigerShop.Models
{
    public class Product
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }

        [MaxLength(100)]
        public string ProductName { get; set; }

        [MaxLength(200)]
        public string Description { get; set; }

        [MaxLength(8)]
        public int ProductPrice { get; set; }
        public int ArticleNumber { get; set; }

        [MaxLength(20)]
        public string Color { get; set; }

        [MaxLength(7)]
        public string Size { get; set; }
        public int AmountInStock { get; set; }
        public string ImageUrl { get; set; }
    }
}
