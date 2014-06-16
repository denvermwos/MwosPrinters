using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MwosPrinters.Core
{
    public class NashuaContact : Contact
    {
        public NashuaContact()
        {
            TonerContactTo = new HashSet<NashuaBranch>();
            ServiceContactTo = new HashSet<NashuaBranch>();
        }

                
        [InverseProperty("TonerContacts")]
        public ICollection<NashuaBranch> TonerContactTo { get; set; }
        [InverseProperty("ServiceContacts")]
        public ICollection<NashuaBranch> ServiceContactTo { get; set; }
        
    }
}
