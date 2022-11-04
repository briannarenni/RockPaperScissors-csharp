using System;

// Refactoring Game.cs
namespace RPSGame {
    public class GameV2 {
        Random rnd = new Random();

        // constructor
        public GameV2() { }

        // Choices
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

        public Throw getUserThrow() {
            Console.WriteLine("Choose 1: rock, 2: paper, or 3: scissors: ");
            string userInput = Console.ReadLine();
            int userChoice = inputValidation(userInput);
            Throw userThrow = (Throw)userChoice;
            return userThrow;
        }

        public string getResult(Throw userThrow) {
            string result;
            Console.WriteLine($"You threw {userThrow}...");
            Console.WriteLine();
            Throw compThrow = (Throw)rnd.Next(0, 3);


            if (compThrow == userThrow) {
                // return WhoWins.Draw;
            } else if (WinningThrow[userThrow] == compThrow) {
                // return WhoWins.User;
            } else {
                // return WhoWins.Comp;
            }
        }


        // if (compOption == userOption)
        //     result = "DRAW";
        // else if (userOption == ((compOption + 1) % 3))
        //     result = "WIN";
        // else
        //     result = "LOOSE";

    }
}