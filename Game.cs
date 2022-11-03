using System;

namespace RPSGame {
    public class Game {
        // TODO:


        // Field
        Dictionary<int, string> options = new Dictionary<int, string> {
                {1, "Rock"},
                {2, "Paper"},
                {3, "Scissors"}
            };

        public Game() { }

        public int getCompChoice() {
            var rand = new Random();
            int compChoice = rand.Next(1, 4);
            return compChoice;
        }

        public int getUserChoice() {
            Console.WriteLine("Choose 1: rock, 2: paper, or 3: scissors: ");
            string userInput = Console.ReadLine();
            int userChoice = inputValidation(userInput);
            return userChoice;
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

        // Convert both choices to option str
        public string getOption(int givenChoice) {
            // Should take int and return str choice from dict
            return options[givenChoice];
        }

        // Returns game result
        public string getResult(int compOption, int userOption) {
            string result;
            Console.WriteLine($"You threw {options[userOption]}...");
            Console.WriteLine();

            // if (compOption == userOption)
            //     result = "DRAW";
            // else if (userOption == ((compOption + 1) % 3))
            //     result = "WIN";
            // else
            //     result = "LOOSE";

            if (compOption == userOption) {
                result = "It's a draw!";
            } else if (compOption > userOption) {
                if ((userOption == 1) && (compOption == 3)) {
                    result = $"You win! {options[userOption]} beats {options[compOption]}!";
                } else {
                    result = $"You lost...{options[compOption]} beats {options[userOption]}";
                }
            } else {
                if ((userOption == 3) && (compOption == 1)) {
                    result = $"You lost...{options[compOption]} beats {options[userOption]}";
                } else {
                    result = $"You win! {options[userOption]} beats {options[compOption]}!";
                }
            }
            Console.WriteLine($"The computer threw {options[compOption]}!");
            return result;


        }

        // TODO: Add loop for draw
        // TODO: Refactor options and results to enum



    }
}
