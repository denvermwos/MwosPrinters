using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MwosPrinters.Core.Interfaces
{
    public interface IEmailer
    {
        void SendEmail(Email email);
    }
}
