using System;

namespace Zork
{
    class Program
    { 
    static void Main(string [] args)
        {
            const string defaultGameFilename = "Zork.json";
            string gameFilename = (args.Length > 0 ? args[(int)CommandLineArguments.GameFileName] : defaultGameFilename);

            ConsoleOutputService output = new ConsoleOutputService();
            ConsoleInputService input = new ConsoleInputService();

            Game.Player.LocationChanged += Player_LocationChanged;

            Game game = Game.Load(gameFilename);
            Console.WriteLine("Welcome to Zork!");
            game.Run(input, output);
            Console.WriteLine("Thank you for playing!");
        }

        private enum CommandLineArguments
        {
            GameFileName = 0
        }
    }
}
        
