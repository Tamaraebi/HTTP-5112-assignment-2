using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5112_assignment_2.Controllers
{
    public class J3Controller : ApiController
    {

        /// <summary>
        /// This subtracts two integer inputs and produces a third integer which is the difference between the preceding two terms. The 3rd and 4th are then subtracted from each other and this process continues till a negative integer is produced
        /// </summary>
        /// <param name="x"> This is the number selected by the user and is greater than y</param>
        /// <param name="y">This is any number selected by the user</param>
        /// <returns>The purpose of the loop is to check how many numbers are in the sequence until a negative final result is gotten</returns>
        /// <example>GET api/J3/SumacSequence/{120}/{71} = 5 </example>

        [HttpGet]
        [Route("api/J3/SumacSequence/{x}/{y}")]

        public int SumacSequence (int x, int y)
        {
            int SumacOutput;
            int EachTerm;

            if ((x>=0) && (y>=0))
            {
                EachTerm = x-y;
                SumacOutput = 3;

            while (EachTerm >=0)
                {
                    x = y;
                    y = EachTerm;
                    EachTerm = x - y;
                    SumacOutput++;
                }

            } else
            {
                SumacOutput = 0;
            }
            return SumacOutput;
        }
    }
}
