using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace C__Assignment2_JiabaoDing.Controllers
{
    public class J1_2023Controller : ApiController
    {
        /// <summary>
        /// Calculates the final score for a game based on the number of packages delivered (P) and the number of collisions with obstacles (C).
        /// For each delivered package, the final score increases by 50 points, and for each collision with an obstacle, the final score decreases by 10 points.
        /// If the number of delivered packages exceeds the number of collisions, a bonus of 500 points is added.
        /// </summary>
        /// <param name="P">The number of packages successfully delivered.</param>
        /// <param name="C">The number of collisions with obstacles during delivery.</param>
        /// <returns>The computed final score of the game.</returns>
        /// <example>
        /// Input: P=5, C=3 (5 packages successfully delivered with 3 collisions during delivery).
        /// Output: 730
        /// Explanation: For 5 successfully delivered packages, the game awards 50 points each, totaling 250 points (5 * 50). However, due to 3 collisions with obstacles, 10 points are deducted for each collision, resulting in a deduction of 30 points (3 * 10). Since the number of delivered packages (5) exceeds the number of collisions (3), an additional bonus of 500 points is added. So, the final score is calculated as follows: 250 (delivered packages) - 30 (collisions) + 500 (bonus) = 720 + 500 = 730 points.
        /// </example>
        [HttpGet]
        [Route("api/J1_2023/{P}/{C}")]
        public int deliv_e_droid(int P, int C)
        {
            int F = 0;
            if (P > C)
            {
                F = 500 + 50 * P - 10 * C;
            }
            else
            {
                F = 50 * P - 10 * C;
            }
            return F;
        }
    }
}