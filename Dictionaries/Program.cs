using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionaries
{
    class Program
    {
        static void Main(string[] args)
        {

            //syntax for dictionary

            Dictionary<string, string> snackMachine = new Dictionary<string, string>()
            {
                {"A1", "Twix" },
                {"A2", "Twizzlers" },
                {"A3", "Reese's" },
                {"A4", "Sour Patch Kids" }
            };

            foreach(KeyValuePair<string, string>item in snackMachine)
            {
                Console.WriteLine(item);
            }


            Dictionary<int, string> drinkMachine = new Dictionary<int, string>();
            
                drinkMachine.Add(10, "Ginger Ale");
                drinkMachine.Add(11, "Bottle Water");
                drinkMachine.Add(12, "Orange Juice");
                drinkMachine.Add(13, "Fruit Punch");
                drinkMachine.Add(14, "Mountain Dew Code Red");
            
            //Number of drinks in the machine
            Console.WriteLine(drinkMachine.Count);

            foreach (KeyValuePair<int,string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Key);
                Console.WriteLine(drink.Value);
            }



           
        }
    }
}
