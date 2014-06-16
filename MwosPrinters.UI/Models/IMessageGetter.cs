using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MwosPrinters.Models
{
    public interface IMessageGetter
    {
        string GetTheMessage();
    }
}