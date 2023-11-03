using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System;
using System.Web.Http;

namespace C__Assignment2_JiabaoDing.Controllers
{
    public class ChilliController : ApiController
    {
        /// <summary>
        /// J2 question of 2023
        /// Determines the total spiciness of Ron's chili after he has finished adding peppers.
        /// Each added pepper has different spiciness.
        /// </summary>
        /// <param name="N">The number of peppers added.</param>
        /// <param name="Names">A comma-separated list that contains the names of the added peppers.</param>
        /// <returns>The calculated total spiciness.</returns>
        /// <example>
        /// Input: N=3, Names="Poblano,Mirasol,Serrano"
        /// Output: 22000
        /// Explanation: Ron added 3 peppers to his chili - Poblano (1500 SHU), Mirasol (6000 SHU), and Serrano (15500 SHU). 
        /// The total spiciness is calculated by adding the SHU (Scoville Heat Units) of these peppers: 1500 + 6000 + 15500 = 22000 SHU.
        /// </example>

        [HttpGet]
        [Route("api/j2_2023/{N}/{Names}")]
        public int chilliPeppers(int N,string Names)
        {
            string[] substrings = Names.Split(',');
            int shu = 0;

            for (int i=0; i<N; i++){
                switch (substrings[i])
                {
                    case "Poblano":
                        shu += 1500;
                        break;
                    case "Mirasol":
                        shu += 6000;
                        break;
                    case "Serrano":
                        shu += 15500;
                        break;
                    case "Cayenne":
                        shu += 40000;
                        break;
                    case "Thai":
                        shu += 75000;
                        break;
                    case "Habanero":
                        shu += 125000;
                        break;
                }

            }
           

            return shu;


        }
    }
}