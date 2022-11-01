using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5112_assignment_2.Controllers
{
    public class J2Controller : ApiController

    ///<summary>This calculates the total number of ways to get the sum of 10 with two dices</summary>
    ///<param name="m" name="n"> M represents the number of sides for the first die and n is the number of sides of the second die</param>
    ///<returns>The total number of ways the woman can roll the value of 10 is returned</returns>
    ///<example>/api/J2/DiceGame/2/8</example>
    {
        [HttpGet]
        [Route("api/J2/DiceGame/{m}/{n}")]

        public string DiceGame (int m, int n)
        {
            //default ways set as 0

            int ways = 0;

            for (int i=1; i<=m; i++)
            {

                for (int j=1; j<=n; j++)
                {
                    int total = i + j;

                    if (total == 10)
                    {
                        ways++;
                    }
                }

            }
            string finalResult = "There are" + " " + ways + " " + "total ways to get the sum of 10.";

            return finalResult;
        }
    }
}
