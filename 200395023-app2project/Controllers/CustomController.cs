using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _200395023_app2project.Controllers
{
    public class CustomController : Controller
    {
        // GET: Custom
        public String Index()
        {
            return "Hello from Custom.Index()";
        }
        // GET: Custom/Browse
        public String Browse(string param)
        {
            string message = HttpUtility.HtmlEncode("Custom.Browse, Param = " + param);
            return message;
        }
        // GET: Custom/details
        public String Details()
        {
            return "Hello from Custom.Details()";
        }
    }
}