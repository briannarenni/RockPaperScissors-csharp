using System;

namespace RPSGame {

    class Program {
        public static void Main(String[] args) {
            Game play = new Game();
            bool playAgain = false;

            // Loop start for playAgain()
            do {
                // Get computer choice
                var compThrow = play.getCompThrow();

                // Get user Input
                var userThrow = play.getUserThrow();

                // Get Result
                string result = play.getResult(compThrow, userThrow);
                Console.WriteLine(result);

                // ! Play again prompt
                Console.WriteLine("Game over! To play again, press y, OR press any key to exit: ");
                ConsoleKeyInfo userInput = Console.ReadKey();

                if (userInput.Key == ConsoleKey.Y) {
                    playAgain = true;
                } else {
                    Console.WriteLine("Exiting game...");
                    playAgain = false;
                }
                Console.WriteLine();
            } while (playAgain);
        }
    }
}