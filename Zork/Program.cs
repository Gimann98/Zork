using System;

namespace Zork
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");
            string inputstring = Console.ReadLine();
            inputstring = inputstring.ToUpper();
            if (inputstring == "QUIT")
            {
                Console.WriteLine("Thank you for playing.");
            }
            else if (inputstring == "LOOK")
            {
                Console.WriteLine("This is an open field west of the white house, with a boarded front door. \nA rubber mat saying 'Welcome to Zork!' lies by the door.");
            }
            else
            {
                Console.WriteLine("Unrecognized command.");
            }
        }
    }
}
