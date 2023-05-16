using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace TigerShop.Models
{
    public class Customer
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public int CustomerId { get; set; }

        [Required]
        [MaxLength(20)]
        public string FirstMidName { get; set; }


        [Required]
        [MaxLength(25)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(35)]
        public string Address { get; set; }


        [Required]
        [MaxLength(12)]
        public string PostalNumber { get; set; }

        [Required]
        [MaxLength(20)]
        public string City { get; set; }

        [Required]
        [EmailAddress]
        [MaxLength(50)]
        public string Email { get; set; }

        [Required]
        [MaxLength(15)]
        public string PhoneNumber { get; set; }
    }
}

//Kanske blev lite många Required, men lämnar de här så kan vi tala om det imorgon./Robin
