using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace MVCDemo.Models
{
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public decimal Balance { get; set; }

        public DateTime Birthday { get; set; }

        public int NumberOfChildren { get; set; }

        public virtual IEnumerable<Invoice> Invoices { get; set; }
    }
}