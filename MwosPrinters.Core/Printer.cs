using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MwosPrinters.Core
{
    public class Printer
    {
        public int Id { get; set; }
        public string MakeAndModel { get; set; }
        public string SerialNumber { get; set; }
        public int BranchId { get; set; }

        public virtual Branch Branch { get; set; }

        
    }
}
