using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHelloWorld.DataModel
{
    public class Meal
    {
        public int MealId { get; set; }

        public string MealName { get; set; }

        public DateTime DateOfMeal { get; set; }

        public string CustomerName { get; set; }
        public string CustomerPhone { get; set; }

        public decimal MealCost { get; set; }
    }
}
