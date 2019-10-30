using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RelationalMappings.Models
{
    public enum PhoneCategory
    {
        SmartPhone,
        StupidPhone,
        MpaxatelaPhone
    }


    public class Category
    {
        public int CategoryId { get; set; }

        public PhoneCategory PhoneCategory { get; set; }

        public virtual Mobile Mobile { get; set; }

    }
}