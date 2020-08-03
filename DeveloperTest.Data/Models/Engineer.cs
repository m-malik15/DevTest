using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeveloperTest.Data.Models
{
    public class Engineer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int EngineerId { get; set; }
        public string Name { get; set; }
    }
}
