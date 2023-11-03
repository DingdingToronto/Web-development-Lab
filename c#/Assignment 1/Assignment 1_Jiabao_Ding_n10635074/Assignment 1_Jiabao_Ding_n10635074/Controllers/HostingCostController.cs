using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_1_Jiabao_Ding_n10635074.Controllers
{
    public class HostingCostController : ApiController
    {
        /// <summary>
        /// Calculates the hosting cost for a specified number of fortnights.
        /// </summary>
        /// <param name="id">The number of fortnights for which to calculate the hosting cost.</param>
        /// 
        /// 
        /// <example>
        /// Sample request:
        /// Get http://localhost/api/HostingCost/5
        /// 
        /// Sample response:
        /// - 1.00 fortnight at $5.50 CAD
        /// - HST 13% = $0.72CAD
        /// - Total = $6.22CAD
        /// </example>
        /// 
        /// 
        /// 
        /// 
        /// 
        /// <returns>
        /// An array of strings containing:
        /// - Hosting cost per fortnight in CAD
        /// - HST amount in CAD
        /// - Total cost in CAD
        /// </returns>
        public IEnumerable<string> Get(int id)
        {
         
            int fortnights = (id / 13) + 1;
            string fortnightsString = fortnights.ToString("#0.00");

            double HST = fortnights*5.5 * 0.13;
            string HSTString = HST.ToString("#0.00");


            double total = fortnights*5.5 + HST;
            string totalString = total.ToString("#0.00");
           
            string[] result = new string[]
            {
            fortnightsString + " fortnight at $5.50 CAD","HST 13% = $"+HSTString+"CAD","Total = $"+totalString+"CAD",
            };

            return result;
        }
    }
}
