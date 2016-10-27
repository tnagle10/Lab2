using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    class Program
    {

        private static string genList(string description,string[] names)
        {
            Boolean valid = false;
            int input = 0;
            while (valid == false)
            {

                Console.WriteLine("Please choose one of the following values for "+description+": ");
                for (int i = 0; i < names.Length; i++)
                {
                    Console.WriteLine(i + ": " + names[i]);
                }

                input = int.Parse(Console.ReadLine());
                int pos = Array.IndexOf(names, names[input]);
                if (pos > -1)
                {
                    Console.WriteLine("You chose " + names[input]+"\n");
                    valid = true;
                }
                else
                {
                    valid = false;
                }


            }
            return names[input];
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

            do
            {

                Console.WriteLine("Do you want to go somewhere? (y or n)");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "y":
                        string[] car_models = { "Corvette", "Challenger" };
                        string[] car_colors = { "Red", "Blue", "Yellow", "Orange" };
                        string[] locations = { "Duck Park", "Waterworks Park" };

                        string car_model = genList("car model", car_models);
                        string car_color = genList("car color",car_colors);
                        string location = genList("location",locations);


                        switch (location)
                        {
                            case "Waterworks Park":
                                Console.WriteLine("We are driving your " + car_color + " " + car_model + " " + "to the " + location);
                                Console.WriteLine("Congratulations, you made it to " + location + ". Where do you want to go now?");
                                string[] waterworks_locations = { "Dinosaur", "Tractor","Sand Box"};
                                string waterworks_location = genList("park location",waterworks_locations);
                                break;
                            case "Duck Park":
                                Console.WriteLine("We are driving your " + car_color + " " + car_model + " " + "to the " + location);
                                Console.WriteLine("Congratulations, you made it to " + location + ". Where do you want to go now?");
                                string[] duck_locations = { "Duck Pond", "Trail", "Large Hill" };
                                string duck_location = genList("park location",duck_locations);
                                break;
                                
                            default:
                                break;
                        }

                        break;

                    case "n":
                        Console.WriteLine("Thanks for coming");
                        return;


                }

            } while (keepGoing());

        }
    }

}
