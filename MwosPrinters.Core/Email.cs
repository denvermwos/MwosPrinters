using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MwosPrinters.Core.Interfaces;

namespace MwosPrinters.Core
{
    public class Email
    {
        public ICollection<Contact> ToRecipients;
        public ICollection<Contact> CCRecipients;
        public string Subject;
        public string Body;

        
        
    }
}
