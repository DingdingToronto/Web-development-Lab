using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1_Jiabao_Ding_n10635074.Controllers
{
    /// <summary>
    /// Responds to a POST request with a greeting message.
    /// 
    /// <example>
    /// Sample request:
    /// Post http://localhost/api/Greeting
    /// 
    /// Sample response:
    /// "Hello World"
    /// </example>
    /// 
    /// </summary>
    /// <returns>A string containing a greeting message.</returns>
    public class GreetingController : ApiController
    {
        // This method responds to POST requests
        public string Post()
        {
            return "Hello World!";
        }
    }
}