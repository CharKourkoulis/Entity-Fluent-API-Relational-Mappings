using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RelationalMappings.Models
{
    public class Contact
    {
        public int ContactId { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public string ImageURL { get; set; }


        public virtual Mobile Mobile { get; set; }
    }
}