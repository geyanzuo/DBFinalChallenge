using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPI.Models
{
    public class Perform
    {
        public string RecrodID { get; set; }
        public string Title { get; set; }
        public string Performer { get; set; }

        public IEnumerable<Order> Orders { get; set; }
    }
}