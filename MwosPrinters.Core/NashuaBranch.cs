using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace MwosPrinters.Core
{
    public class NashuaBranch
    {
        public NashuaBranch()
        {
            Branches = new HashSet<Branch>();
            TonerContacts = new HashSet<NashuaContact>();
            ServiceContacts = new HashSet<NashuaContact>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Branch> Branches;
        [InverseProperty("TonerContactTo")]
        public ICollection<NashuaContact> TonerContacts { get; set; }
        [InverseProperty("ServiceContactTo")]
        public ICollection<NashuaContact> ServiceContacts { get; set; }

       
    }
}
