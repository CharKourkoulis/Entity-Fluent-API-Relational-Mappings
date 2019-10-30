using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RelationalMappings.Models
{
    public class ICosmicMammal
    {
         public int Id { get; set; }
         public string FirstName { get; set; }
         public string LastName { get; set; }
         public string SpeakingLanguage { get; set; }

        public virtual ICollection<Mobile> Mobiles { get; set; }

        public ICosmicMammal()
        {
            Mobiles = new List<Mobile>();
        }
    }
}