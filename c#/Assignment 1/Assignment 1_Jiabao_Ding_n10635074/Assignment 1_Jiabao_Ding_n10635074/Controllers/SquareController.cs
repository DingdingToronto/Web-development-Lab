using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1_Jiabao_Ding_n10635074.Controllers
{
    /// <summary>
    /// Calculates the square of an integer.
    /// <param name="id">The integer to be squared.</param>
    /// 
    /// <example> 
    /// Get http://localhost/api/Square/5
    /// // Response: 25
    /// </example>
    /// 
    /// </summary>
    /// 
    /// <returns>The square of the input integer.</returns>
    /// 
    public class SquareController : ApiController
    {
        public int Get(int id)
        {
            return id * id;
        }
    }
}
