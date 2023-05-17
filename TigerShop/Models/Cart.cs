using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TigerShop.Models
{
    public class Cart
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CartId { get; set; }

        [MaxLength(9)]
        public double TotalSum { get; set; }

        [MaxLength(8)]
        public int NumberOfProducts { get; set; }

        [ForeignKey("Product")]
        public int? FK_ProductId { get; set; }

        public virtual Product Product { get; set; }
    }
}
