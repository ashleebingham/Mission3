using System.Reflection.Metadata.Ecma335;
using Mission3;

internal class Program
{
    private static void Main(string[] args)
    {
        // parameters
        string userInput = "";
        Boolean runMenu = true;
        List<FoodItem> foodItemList = new List<FoodItem>();
        string foodName, foodCategory, foodExpiration;
        int foodQuantity;
        int itemNum;

        // welcome
        Console.WriteLine("Welcome to the Food Bank Inventory System!\n");

        while (runMenu)
        {

            // Menu:
            Console.WriteLine("Choose one of the options below. \n\n" +
                "Add Food Items (a)\n" +
                "Delete Food Items (d)\n" +
                "Print List of Current Food Items (p)\n" +
                "Exit the Program (e)\n");

            userInput = Console.ReadLine().ToLower();


            // add
            if (userInput == "a")
            {
                // get name
                Console.WriteLine("Enter the name of your food item: ");
                foodName = Console.ReadLine();

                // get category
                Console.WriteLine("Enter the category of your food item: ");
                foodCategory = Console.ReadLine();

                // get quantity
                Console.WriteLine("Enter the quantity of your food item: ");
                // checks to see if input is valid
                while (!int.TryParse(Console.ReadLine(), out foodQuantity) || foodQuantity < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid positive number for quantity: ");
                }

                // get expiration date
                Console.WriteLine("Enter the expiration date of your food item: ");
                foodExpiration = Console.ReadLine();

                // calls class to create new food object
                FoodItem oFood = new FoodItem(foodName, foodCategory, foodQuantity, foodExpiration);
                foodItemList.Add(oFood);

                Console.WriteLine("\nFood item added successfully!");
            }
            // delete
            else if (userInput == "d")
            {
                PrintFood.DisplayFood(foodItemList);

                Console.WriteLine("\nType the number next to the food item you want to delete.\n");

                // checks that the user input is valid
                while (!int.TryParse(Console.ReadLine(), out itemNum) || itemNum < 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid positive number: ");
                }
                
                foodItemList.RemoveAt(itemNum - 1);

                Console.WriteLine("\nFood item deleted successfully!");
            }
            // print
            else if (userInput == "p")
            {
                // print out array of food items
                PrintFood.DisplayFood(foodItemList);

                Console.WriteLine("\nFood items printed successfully!");
            }
            // exit
            else if (userInput == "e")
            {
                // ends program
                runMenu = false;
            }
            else
            {
                Console.WriteLine("Invalid input. Please choose one of the options by typing the letter in parentheses.");
            }
        }

    }
}

