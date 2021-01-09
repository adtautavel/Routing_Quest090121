using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Routing_Quest090121.Controllers
{

   
    public class HelloController : Controller
    {
       
        [Route("")]
        [Route("Hello")]        
        public string HomePage()
        {
            return "Welcome Home Page";
        }
        [Route("Hello/say")]
        public string SayHello()
        {
            return "SayHello!!";
        }

    }
}
