using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1_Jiabao_Ding_n10635074.Controllers
{
    /// <summary>
    /// Generates a greeting message based on the number of people.
    /// 
    /// <example>
    /// Sample request:
    /// Get http://localhost/api/GreetingId/5
    /// 
    /// Sample response:
    /// "Greetings to 5 people!"
    /// </example>
    /// 
    /// 
    /// </summary>
    /// <param name="id">The number of people to greet.</param>
    /// <returns>A string containing a greeting message customized for the specified number of people.</returns>
    public class GreetingIdController : ApiController
    {
        public string Get(int id)
        {
            return "Greetings to "+ id + " people!";
        }
    }
}
