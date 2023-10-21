using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace webapi_ass2.Controllers
{
   
    public class gameapiController : ApiController
    {
        /// <summary>
        /// Calculate final score for a game based on the number of pakages delivered and collison occured
        /// </summary>
        /// <param name="packagesDelivered">the total number of pakags delivered</param>
        /// <param name="collisionsWithObstacles">The total number of obstacles collided</param>
        /// <returns>
        /// GET --> api/calcuatescore/5/2 --> 730
        ///  GET --> api/calcuatescore/0/10 --> -100
        /// </returns>
        [Route("api/calcuatescore/{packagesDelivered}/{collisionsWithObstacles}")]
        [HttpGet]
        

            public int CalculateFinalScore(int packagesDelivered, int collisionsWithObstacles)
            {
                // Calculate the base score (50 points per package delivered, minus 10 points per collision)
                int baseScore = (packagesDelivered * 50) - (collisionsWithObstacles * 10);

                // Check if a bonus is earned (more packages delivered than collisions)
                int bonus = (packagesDelivered > collisionsWithObstacles) ? 500 : 0;

                // Calculate the final score by adding the base score and the bonus
                int finalScore = baseScore + bonus;

                // Ensure the final score is non-negative
                

                return finalScore;
            }
        }

    }

