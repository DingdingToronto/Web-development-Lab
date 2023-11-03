using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1_Jiabao_Ding_n10635074.Controllers
{
    /// <summary>
    /// Performs mathematical operations on the given number.
    /// </summary>
    /// <param name="id">The input number on which operations will be performed.</param>
    /// 
    /// <example>
    /// Sample request:
    /// Get http://localhost/api/NumberMaschine/5
    /// 
    /// Sample response:
    /// "10,-5,25,0"
    /// </example>
    /// 
    /// 
    /// 
    /// 
    /// <returns>An array of integers containing the result of addition, subtraction, multiplication, and division on the input number.</returns>
    public class NumberMaschineController : ApiController
    {
        public IEnumerable<int> Get(int id)
        {
            return new int[]
            {
               id+id,id-10,id*id,id/10
            };
         }
    }
}
