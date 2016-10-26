using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {
        private static string getCarType ()
            {
               int input = 0;
               
               Console.WriteLine("What kind of car do you want?");
               Console.WriteLine("Please choose one of the following values");
               Console.WriteLine("1. Corvette");
               Console.WriteLine("2. Camaro");
               Console.WriteLine("3. Charger");
               Console.WriteLine("4. Challenger\n");
               input = int.Parse(Console.ReadLine());
               string carType = ""; 
               switch (input)
               {
                   case 1:
                         Console.WriteLine("\nYou chose a Corvette\n");
                         carType = "Corvette";
                         break;
                   case 2:
                         Console.WriteLine("\nYou chose a Camaro\n");
                         carType = "Camaro";
                         break;
                   case 3:
                         Console.WriteLine("\nYou chose a Charger\n");
                         carType = "Charger";
                         break;
                   case 4:
                         Console.WriteLine("\nYou chose a Challenger\n");
                         carType = "Challenger";
                         break;
                   default :
                         Console.WriteLine("You chose an invalid car\n");
                         carType = "Invalid";
                         break;
                }
            return carType;
            }

        private static string getCarColor ()
        {
            int input = 0;
            string carColor = "";
            Console.WriteLine("What color car do you want?");
            Console.WriteLine("Please choose one of the following values");
            Console.WriteLine("1. Red");
            Console.WriteLine("2. Blue");
            Console.WriteLine("3. Yellow");
            Console.WriteLine("4. Orange\n");
            input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("\nYou chose Red\n");
                    carColor = "Red";
                    break;
                case 2:
                    Console.WriteLine("\nYou chose Blue\n");
                    carColor = "Blue";
                    break;
                case 3:
                    Console.WriteLine("\nYou chose Yellow\n");
                    carColor = "Yellow";
                    break;
                case 4:
                    Console.WriteLine("\nYou chose Orange\n");
                    carColor = "Orange";
                    break;
                default:
                    Console.WriteLine("You chose an invalid color\n");
                    carColor = "Invalid";
                   break;
            }
            return carColor;
        }

        private static string getLocation()
        {
            int input = 0;
            string location = "";
            Console.WriteLine("Where do you want to go?");
            Console.WriteLine("Please choose one of the following values");
            Console.WriteLine("1. Waterworks Park");
            Console.WriteLine("2. Duck Park");
            
            input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("\nYou chose Waterworks Park\n");
                    location = "Waterworks Park";
                    break;
                case 2:
                    Console.WriteLine("\nYou chose Duck Park\n");
                    location = "Duck Park";
                    break;
                default:
                    Console.WriteLine("You chose an invalid location\n");
                    location = "Invalid";
                    break;
            }
            return location;
        }

        private static string getWaterOptions()
        {
            int input = 0;
            string location = "";
            Console.WriteLine("Where do you want to go?");
            Console.WriteLine("Please choose one of the following values");
            Console.WriteLine("1. Bulldozer");
            Console.WriteLine("2. Dinosaur");
            Console.WriteLine("3. Swings");
            


            input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("\nYou chose the Bulldozer\n");
                    location = "Bulldozer";
                    break;
                case 2:
                    Console.WriteLine("\nYou chose the Dinosaur\n");
                    location = "Dinosaur";
                    break;
                case 3:
                    Console.WriteLine("\nYou chose the Swings\n");
                    location = "Swings";
                    break;
                default:
                    Console.WriteLine("You chose an invalid location\n");
                    location = "Invalid";
                    break;
            }
            return location;
        }

        private static string getDuckOptions()
        {
            int input = 0;
            string location = "";
            Console.WriteLine("Where do you want to go?");
            Console.WriteLine("Please choose one of the following values");
            Console.WriteLine("1. Duck Pond");
            Console.WriteLine("2. Play Ground");
            Console.WriteLine("3. Sled Hill");


            input = int.Parse(Console.ReadLine());
            switch (input)
            {
                case 1:
                    Console.WriteLine("\nYou chose the Duck Pond\n");
                    location = "Duck Pond";
                    break;
                case 2:
                    Console.WriteLine("\nYou chose the Play Ground\n");
                    location = "Play Ground";
                    break;
                case 3:
                    Console.WriteLine("\nYou chose the Sled Hill\n");
                    location = "Sled Hill";
                    break;
                default:
                    Console.WriteLine("You chose an invalid location\n");
                    location = "Invalid";
                    break;
            }
            return location;
        }

        private static bool keepGoing()
        {
            /* Name: keepGoing
            * Description:  This method implements a loop to determine if users wants to continue
            * Input:  None
            * Output: Returns 0 if user doesn't want to continue.  Otherwise returns 1.
            *         Outputs values to Console
            */


            // If user enters "q", execute exit procedure
            Console.WriteLine("Continue? (y/n):");
            string input = Console.ReadLine();

            if (input == "n")
            {
                Console.WriteLine("You entered n\n");
                Console.WriteLine("Are you sure you want to exit? (Type y to confirm)");
                input = Console.ReadLine();

                if (input == "y")
                {
                    return false;
                }

            }

            return true;
        }

        static void Main(string[] args)
        {
       
            do {
                
                Console.WriteLine("Do you want to go somewhere? (y or n)");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "y" :
                        string car = getCarType();
                        string color = getCarColor();
                        string location = getLocation();
                        Console.WriteLine(car);
                        Console.WriteLine(color);
                        Console.WriteLine(location);

                        if (car != "Invalid" && color != "Invalid" && location != "Invalid")
                        {
                            switch (location)
                            {
                                case "Waterworks Park":
                                    Console.WriteLine("We are driving your " + color + " " + car + " " + "to the " + location);
                                    Console.WriteLine("Congratulations, you made it to" +location+"Where do you want to go now?");
                                    getWaterOptions();
                                    break;
                                case "Duck Park":
                                    Console.WriteLine("You made it to the Duck Park.  Where do you want to go now?");
                                    getDuckOptions();
                                    break;
                                default:
                                    break;
                            }
                            Console.WriteLine("We are driving your " + color + " " + car + " " + "to the " + location);

                        }
                        else
                        {
                            Console.WriteLine("Invalid Option Selected.  Please try again.");
                            
                        }
                        
                        break;

                    case "n":
                        Console.WriteLine("Thanks for coming");
                        return;
                        

                    default :
                        Console.WriteLine("You chose an invalid value.\n");
                        break;
                }
                
            } while (keepGoing());
            
        }
    }
}
