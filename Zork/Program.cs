using System;

namespace Zork
{
    class Program
    {
        private string location
        {
            get
            {
                return Rooms[LocationColumn];
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Zork!");

            while (true)
            {
                Console.Write($"{ Rooms[LocationColumn]}\n> ");
                Commands command = ToCommand(Console.ReadLine().Trim());
                if (command == Commands.QUIT)
                {
                    break;
                }
           
                string outputString;
                switch (command)

                {
                    case Commands.QUIT:
                        outputString = "Thank you for playing!";
                        break;

                    case Commands.LOOK:
                        outputString = "This is an open field west, with a boarded front door. \nA rubber mat saying 'Welcome to Zork!' lies by the door.";
                        break;

                    case Commands.NORTH:
                    case Commands.SOUTH:
                    case Commands.EAST:
                    case Commands.WEST:


                    default:
                        outputString = "Unknown command";
                        break;
                }

                Console.WriteLine(outputString);
            }
        }

        private static bool Move(Commands command)
        {
            bool didMove = false;

            switch (command)
            {
                case Commands.NORTH:
                case Commands.SOUTH:
                    break;

                case Commands.EAST when LocationColumn < Rooms.Length - 1:
                    LocationColumn++;
                    didMove = true;
                    break;

                case Commands.WEST when LocationColumn > 0:
                    LocationColumn--;
                    didMove = true;
                    break;
            }

            return didMove;
        }

        private static int LocationColumn = 1;
        private static int LocationRow = 1;
        private static readonly string[,] Rooms = {
            {"Dense Woods, North of House, Clearing"},
            {"Forest, West of House, Behind House" },
            {"Rocky Trail, South of House, Canyon View" },
        };
        private static Commands ToCommand(string commandString) => Enum.TryParse(commandString, true, out Commands result) ? result : Commands.UNKNOWN;
    }
}
        
