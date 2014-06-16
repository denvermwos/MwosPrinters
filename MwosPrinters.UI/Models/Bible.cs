using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MwosPrinters.Models
{
    public class Bible : IMessageGetter
    {


        public string GetTheMessage()
        {
            return "I am the way the truth and the life John 14:6";
        }

        
    }
}