using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MwosPrinters.Core
{
    public abstract class Request
    {
        public int Id { get; set; }
        public DateTime MadeOn { get; set; }
        public int PrinterId { get; set; }
        public Boolean Supplied { get; set; }
        public virtual Printer Printer { get; set; }

        public abstract Email CreateEmailMessage();
        

    }
}
