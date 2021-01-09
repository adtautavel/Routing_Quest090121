using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Routing_Quest090121.Controllers
{

    public class HelloController 
    {
       
        public string Index()
        {
            return "Welcome Home Page";
        }
        
        public string SayHello()
        {
            return "SayHello!!";
        }

    }
}
