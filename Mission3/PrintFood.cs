using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mission3
{
    internal class PrintFood
    {
        public static void DisplayFood(List<FoodItem> foodItemList)
        {
            // Loop through and display all food
            int i = 1;

            Console.WriteLine("\nList of Food:");
                foreach (var item in foodItemList)
                {
                    Console.WriteLine(i + ": " + item.Name);
                    i++;
                }
            Console.Write("\n");
            }
}
}
