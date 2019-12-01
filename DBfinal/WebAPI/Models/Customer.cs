using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Customer
    {
        public int CustomerNo { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public int PostCode { get; set; }

        public IEnumerable<Interest> Interests { get; set; }
        public IEnumerable<Order> Orders { get; set; }

    }
}