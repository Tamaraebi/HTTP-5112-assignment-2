using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HTTP_5112_assignment_2.Controllers
{
    public class J1Controller : ApiController
    {

        /// <summary>
        /// This calculates the total calories of the meal by adding the total of the selected arrays
        /// </summary>
        /// <param> This is the number of the item on the menu which the consumer chooses one item from each menu</param>
        /// <returns>1 is deducted from the user input and they are then added together to give the total amount of calories</returns>
        /// <example>GET api/J1/Menu/{1}/{2}/{3}/{4} = 691 calories</example>
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{drink}/{side}/{dessert}")]
        public string Menu (int burger, int drink, int side, int dessert)
        {
            int[] burgerArr = { 461, 431, 420, 0 };

            int[] drinkArr = { 130, 160, 118, 0 };

            int[] sideArr = { 100, 57, 70, 0 };

            int[] dessertArr = { 167, 266, 75, 0 };

            burger = burgerArr[burger - 1];
            drink = drinkArr[drink - 1];
            side = sideArr[side - 1];
            dessert = dessertArr[dessert - 1];

            int totalCalo = burger + drink + side + dessert;

            return "Your total calorie count is: " + totalCalo;
        }
    }
}
