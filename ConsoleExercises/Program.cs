using System;

namespace ConsoleExercises
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepAlive = true;

            while (keepAlive)
            {
                
                int userInput = -99999;
                Console.WriteLine("Enter exersice number (or -1 to exit)");
                try
                {
                    userInput = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                catch (Exception)
                {
                    userInput = -99999;
                    Console.ForegroundColor = ConsoleColor.Red;
                }

                switch (userInput)
                {
                    case 1:
                        Exersice01();
                        break;
                    //case 2:
                    // ToDo
                    //    break;
                    //case 3:
                    // ToDo
                    //    break;
                    //case 4:
                    // ToDo
                    //    break;


                    case -1:
                        Console.WriteLine("Thanks for using this program! Bye bye!");
                        keepAlive = false;
                        break;
                    case -99999:
                        Console.WriteLine("That is not a valid input.");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("That is not a valid number.");
                        break;
                }

                Console.ResetColor();
                Console.WriteLine("Press anykey to continue.");
                Console.ReadKey();
                Console.Clear();
            }
        }// End of Main

        static void Exersice01()
        {
            Console.WriteLine("Exersice01 was run");
        }
    }
}
