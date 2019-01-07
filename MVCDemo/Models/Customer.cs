using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class Customer
    {
        public string Name { get; set; }

        public decimal Balance { get; set; }

        public DateTime Birthday { get; set; }

        public int NumberOfChildren { get; set; }
    }
}