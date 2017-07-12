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

            foreach (KeyValuePair<string, string> item in snackMachine)
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

            foreach (KeyValuePair<int, string> drink in drinkMachine)
            {
                Console.WriteLine(drink.Key);
                Console.WriteLine(drink.Value);
            }



            //Create a dictionary for a theater coat check with 10 elements
            //Print all the elements to the console.

            Dictionary<int, string> coatCheck = new Dictionary<int, string>();
            coatCheck.Add(01, "Black Bomber");
            coatCheck.Add(02, "Camel Trench");
            coatCheck.Add(03, "Denim Jacket");
            coatCheck.Add(04, "Yellow Raincoat");
            coatCheck.Add(05, "Mink Vest");
            coatCheck.Add(06, "Wool Carcoat");
            coatCheck.Add(07, "Leather Varisty Coat");
            coatCheck.Add(08, "Sable Waistcoat");
            coatCheck.Add(09, "Nylon Slicker");
            coatCheck.Add(10, "Waxed Cotton Trucker");

            foreach (KeyValuePair<int, string> item in coatCheck)
            {
                Console.WriteLine(item);
            }




            //Create a dictionary for a car valet with 10 cars to the key will be customers last name...
            //...and the value will be the car make.
            //Print all the elements to the console.
            Dictionary<string, string> carValet = new Dictionary<string, string>()
            {
                { "Smith", "Mercedes Benz" },
                { "Williams", "Ferrari" },
                { "Johnson", "Tesla" },
                { "Green", "Volkswagen" },
                { "James", "Buick" },
                { "Irving", "Jeep" },
                { "Garrett", "Chevy" },
                { "King", "Land Rover" },
                { "Boyle", "Infinity" },
                { "Scott", "Lexus" },
            };

            foreach (KeyValuePair<string, string> item in carValet)
            {
                Console.WriteLine(item);
            }



            //Create a dictionary of 10 zoo animals the key will be the animal type
            //The value will be the number of animals
            //Print the animal with the highest quantity to the console
            //Remove the zoo animal with the lowest count use the remove()

            Dictionary<string, int> zooAnimals = new Dictionary<string, int>();
            zooAnimals.Add("lion", 10);
            zooAnimals.Add("polar bear", 7);
            zooAnimals.Add("howler monkey", 25);
            zooAnimals.Add("red panda", 5);
            zooAnimals.Add("walrus", 3);
            zooAnimals.Add("bengal tiger", 4);
            zooAnimals.Add("emperor penguin", 15);
            zooAnimals.Add("silverback gorilla", 6);
            zooAnimals.Add("giraffe", 2);
            zooAnimals.Add("black puma", 8);



            // Sorted by Value
            Console.WriteLine("Sorted by Number of Animals");
            foreach (KeyValuePair<string, int> animal in zooAnimals.OrderBy(key => key.Value))
            {
                Console.WriteLine("Key: {0}, Value: {1}", animal.Key, animal.Value);
            }
        }

        
        //Console.WriteLine("Value: {animal.Length-1};
        
        











        //var top = zooAnimals.OrderByDescending(pair => pair.Value).Take(1);
        //var bottom5 = zooAnimals.OrderBy(pair => pair.Value).Take(1);

        //{
        //    Console.WriteLine(top);
        //}


        //List<KeyValuePair<string, int>> myList = zooAnimals.ToList();

        //myList.Sort(
        //    delegate (KeyValuePair<string, int> pair1,
        //    KeyValuePair<string, int> pair2)
        //    {
        //        return pair1.Value.CompareTo(pair2.Value);
        //    }
        //);





    
    }
}
