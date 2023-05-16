using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TigerShop.Models
{
    public class Cart
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CartId { get; set; }
        public double TotalSum { get; set; }
        public int NumberOfProducts { get; set; }

        [ForeignKey("Product")]
        public int FK_ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}
