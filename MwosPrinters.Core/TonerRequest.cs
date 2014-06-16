using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace MwosPrinters.Core
{
    [Table("TonerRequests")]
    public class TonerRequest : Request
    {
        public int MeterReading { get; set; }

        public override Email CreateEmailMessage()
        {
            throw new NotImplementedException();
        }
    }
}
