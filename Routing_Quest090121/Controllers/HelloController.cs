using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Routing_Quest090121.Controllers
{

   [Route("/{action}")]
    public class HelloController : Controller
    {

        public string Hello() 
        { 
            return "Something to say to start!"; 
        }
        
        public string HomePage()
        {
            return "Welcome Home Page";
        }

        public string SayHello()
        {
            return "SayHello!!";
        }

    }
}
