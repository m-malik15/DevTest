using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DeveloperTest.Data.Models
{
    public class Job
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int JobId { get; set; }

        public int EngineerId { get; set; }

        public int CustomerId { get; set; }
        
        public DateTime When { get; set; }

        public Engineer Engineer { get; set; }
        public Customer Customer { get; set; }
    }
}
