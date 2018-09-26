using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Scribe.Models
{
    public class Customer
    {
        public int id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip { get; set; }
    }
}