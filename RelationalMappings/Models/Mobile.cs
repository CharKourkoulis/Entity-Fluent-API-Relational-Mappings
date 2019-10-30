using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RelationalMappings.Models
{
    public class Mobile
    {
        public int MobileId { get; set; }
        public string ModelName { get; set; }

        public virtual ICollection<Contact> Contacts { get; set; }

        public virtual Manufacturer Manufacturer { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICosmicMammal Owner { get; set; }


        public Mobile()
        {
            Contacts = new List<Contact>();
        }
    }
}