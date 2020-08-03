using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeveloperTest.Data.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CustomerId { get; set; }
        [Required]
        [MinLength(5)]
        public string Name { get; set; }

        [Required]
        public int CustomerTypeId { get; set; }
        public CustomerType CustomerType { get; set; }
    }
}
