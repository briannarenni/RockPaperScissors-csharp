using System;

// Refactoring Game.cs

public class GameV2 {

    // constructor
    public GameV2() { }

    // enum refactor
    // ! MAKE NEW BRANCH FIRST


    // OG If then
    public string getResult(string compOption, string userOption) {
        string result;
        Console.WriteLine($"You threw {userOption}...\n");

        if ((compOption == "rock") && (userOption == "scissors")) {
            result = "You lost...rock beats scissors!";

        } else if ((compOption == "paper") && (userOption == "rock")) {
            result = "You lost...paper beats rock!";

        } else if ((compOption == "scissors") && (userOption == "paper")) {
            result = "You lost...scissors beats paper!";

        } else if ((userOption == "rock") && (compOption == "scissors")) {
            result = "You win! Rock beats scissors!";

        } else if ((userOption == "paper") && (compOption == "rock")) {
            result = "You win! Paper beats rock!";

        } else if ((userOption == "scissors") && (compOption == "paper")) {
            result = "You win! Scissors beats paper!";

        } else if (compOption == userOption) {
            result = "It's a draw!";

        } else {
            return "Something went wrong.";
        }
        Console.WriteLine($"The computer threw {compOption}!");
        return result;

    }



}
