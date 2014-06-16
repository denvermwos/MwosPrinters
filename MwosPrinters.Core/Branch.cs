using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MwosPrinters.Core
{
    public class Branch
    {
        public Branch()
        {
            Users = new HashSet<User>();
            Printers = new HashSet<Printer>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public int NashuaBranchId { get; set; }

        public string Address { get; set; }

        public virtual NashuaBranch NashuaBranch { get; set; }
        public virtual ICollection<User> Users { get; set; }
        public virtual ICollection<Printer> Printers { get; set; }

    }
}
