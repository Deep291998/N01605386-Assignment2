using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webapi_ass2.Controllers
{
   
    public class DiceGameController : ApiController
    {

        /// <summary>
        /// In this API we will calculate the total number of times the sum of 2 dice is equal to 10
        /// </summary>
        /// <param name="m">positive integer representing the number of sides on the first die  </param>
        /// <param name="n">positive integer representing the number of sides on the second</param>
        /// <returns>
        /// GET --> api/DiceGame/6/8 --> 5
        /// GET --> api/DiceGame/12/4 --> 4
        /// GET --> api/DiceGame/3/3 --> 0
        /// </returns>

        [Route("api/DiceGame/{m}/{n}")]
        [HttpGet]
        public int CalculateScore(int m , int n)
            {
            int ways = 0;

            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (i + j == 10)
                    {
                        ways++;
                    }
                }
            }

            return ways;
        }

            // Function to count the number of ways to roll a total of 10 with two dice
            
        }
    }


