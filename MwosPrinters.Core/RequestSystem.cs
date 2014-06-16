using MwosPrinters.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MwosPrinters.Core
{
    public class RequestSystem
    {
        private IEmailer _emailer;

        public RequestSystem(IEmailer emailer)
        {
            _emailer = emailer;

        }
        public void ProcessRequest(Request request)
        {
            Email email = request.CreateEmailMessage();
            _emailer.SendEmail(email);
        }
    }
}
