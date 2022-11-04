using System;

namespace RPSGame {
    public class Game {
        // Fields
        Random rnd = new Random();

        public enum Throw {
            Rock,
            Paper,
            Scissors
        }

        Dictionary<Throw, Throw> WinningThrow = new Dictionary<Throw, Throw> {
            {Throw.Rock, Throw.Scissors},
            {Throw.Paper, Throw.Rock},
            {Throw.Scissors, Throw.Paper}
    };

        // Constructor
        public Game() { }

        public Throw getCompThrow() {
            Throw compThrow = (Throw)rnd.Next(0, 3);
            return compThrow;
        }

        public Throw getUserThrow() {
            Console.WriteLine("Choose 1: rock, 2: paper, or 3: scissors: ");
            string userInput = Console.ReadLine();
            int userChoice = inputValidation(userInput);
            Throw userThrow = (Throw)userChoice;
            return userThrow;
        }

        public int inputValidation(string userString) {
            int userChoice = -1;

            while (!Int32.TryParse(userString, out userChoice)) {
                Console.WriteLine("Error! Please enter a number.");
                Console.WriteLine("Choose 1: rock, 2: paper, or 3: scissors: ");
                userString = Console.ReadLine();
            }
            return userChoice;
        }

        // Returns game result
        public string getResult(Throw compThrow, Throw userThrow) {
            string result;
            Console.WriteLine($"You threw {userThrow}...");
            Console.WriteLine();
            Console.WriteLine($"The computer threw {compThrow}!");
            Console.WriteLine();

            if (compThrow == userThrow) {
                result = "It's a draw!";
            } else if (WinningThrow[userThrow - 1] == compThrow) {
                result = $"You win! {userThrow} beats {compThrow}!";
            } else {
                result = $"You lost...{compThrow} beats {userThrow}";
            }
            return result;
        }

    }
}
