using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TigerShop.Models
{
    public class Order
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }

        public int OrderNumber { get; set; }
        public DateTime OrderPlaced { get; set; }


        //Ska denna vara en FK till Cart? Ska kart vara Main key?
        //Ska denna länkas mot cart och göra en for each add sum funktion? 
        //Ska den ha samma värde som totalsum i kart eller ska den ha en till klass för att spara total sum?
        public decimal TotalSumOrder { get; set; }

        [ForeignKey("Customer")]
        public int FK_CustomerId { get; set; }

        public virtual Customer Customer { get; set; }

        [ForeignKey("Cart")]
        public int? FK_CartId { get; set; }
        public virtual Cart Cart { get; set; }
    }
}
