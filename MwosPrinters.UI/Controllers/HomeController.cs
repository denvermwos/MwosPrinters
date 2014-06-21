using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MwosPrinters.Models;

namespace MwosPrinters.Controllers
{
    public class HomeController : Controller
    {
        private IMessageGetter _messageGetter;
        //
        // GET: /Home/
        public HomeController(IMessageGetter messageGetter)
        {
            _messageGetter = messageGetter;
        }
        public string Index()
        {
            return "testmerge branch edit";
            
        }

    }
}
