using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1_Jiabao_Ding_n10635074.Controllers
{
    public class AddTenController : ApiController
    {
        /// <summary>
        /// Adds ten to the given integer input.
        /// 
        /// <example>
        /// Sample request:
        /// GET http://localhost/api/AddTen/5
        /// 
        /// Sample response:
        /// 15
        /// </example>
        /// 
        /// 
        /// </summary>
        /// <param name="id">The integer input to which ten will be added.</param>
        /// <returns>
        /// Returns the result of adding ten to the input integer.
        /// </returns>

        public int Get(int id)
        {
            return id+10;
        }
    }
}
