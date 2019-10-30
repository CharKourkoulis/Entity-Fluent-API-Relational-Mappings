using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RelationalMappings.Models
{
    public class Manufacturer
    {
        public int ManufacturerId { get; set; }
        public string Brand { get; set; }

        public virtual Mobile Mobile { get; set; }


    }
}