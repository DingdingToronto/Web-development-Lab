using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace C__Assignment2_JiabaoDing.Controllers
{
    public class J3_2021Controller : ApiController
    {
        /// <summary>
        /// J3 question of 2021
        /// Decode a series of instructions represented as an array of 5-digit numbers. Each instruction ends with the number 99999, indicating the end of the sequence.
        /// Each 5-digit number is divided into two parts: the sum of the first two digits determines the direction (right or left), and the last three digits represent the remaining steps to follow.
        /// </summary>
        /// <param name="codes">An array containing several 5-digit numbers, ending with 99999.</param>
        /// <returns>A decoded list of instructions, showing the direction and remaining steps for each instruction.</returns>
        /// <example>
        /// Input: 57234, 00907, 34100, 99999
        /// Output: right 234, right 907, left 100
        /// Explanation: The input consists of a sequence of instructions, each represented by a 5-digit number. 
        /// For each instruction, the first two digits are summed, and if the sum is odd, the direction is "left," and if the sum is even, the direction is "right." 
        /// The last three digits of each instruction represent the remaining steps. 
        /// In this example, the first instruction is 57234, where the sum of the first two digits (5+7) is 12, indicating "right," and the remaining steps are 234. 
        /// The second instruction is 00907, with a sum of the first two digits (0+0) being 0, resulting in the same direction as the previous instruction, "right," and the remaining steps are 907.
        /// The third instruction is 34100, with a sum of the first two digits (3+4) being 7, indicating "left," and the remaining steps are 100.
        /// The output provides the decoded instructions with their respective directions and remaining steps.
        /// </example>
        private string lastDirection = "right"; 

        [HttpGet]
        [Route("api/j3_2021/{codes}")]
        public List<string> SecretInstructions(string codes)
        {
            string[] subCodes = codes.Split(',');
            List<string> subSubCodes = new List<string>();

            foreach (string subCode in subCodes)
            {
                if (!subCode.Equals("99999"))
                {
                    string firstTwoChars = subCode.Substring(0, 2);  
                    int sum = 0;
                    foreach (char c in firstTwoChars)
                    {
                            sum += int.Parse(c.ToString());
                    }               
                    string direction;
                    if (sum % 2 == 1)
                    {
                        direction = "left";
                    }
                    else if (sum != 0)
                    {
                        direction = "right";
                    }
                    else
                    {
                        direction = lastDirection;
                    }
                    string lastThreeChars = subCode.Substring(subCode.Length - 3, 3);
                    subSubCodes.Add(direction + ' '+ lastThreeChars);
                    lastDirection = direction;
                }
            }
            return subSubCodes;
        }
    }
}


