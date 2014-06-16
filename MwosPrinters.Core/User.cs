using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MwosPrinters.Core
{
    public class User : Contact
    {
        public User()
        {
            Branches = new HashSet<Branch>();
        }

        public string Role { get; set; }

        public virtual ICollection<Branch> Branches { get; set; }
        
    }
}
