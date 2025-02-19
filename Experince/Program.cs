// See https://aka.ms/new-console-template for more informati
using System.ComponentModel.Design;

bool GameState = true;
Random GameChoice = new Random();
int CC = GameChoice.Next(1, 4);
String PlayerChoice;
String ComputerChoise;
int PlayerScore = 0;
int ComputerScore = 0;
char i;
Console.ForegroundColor = ConsoleColor.Blue;
while (GameState)
{
    ComputerChoise = "";
    CC = GameChoice.Next(1, 4);
    if (CC == 1)
    {
        ComputerChoise = "ROCK";
    }
    else if (CC == 2)
    {
        ComputerChoise = "PAPER";
    }
    else if (CC == 3)
    {
        ComputerChoise = "SCISSORS";
    }
    Console.WriteLine("ROCK, PAPER, SCISSORS:");
    PlayerChoice = Console.ReadLine().ToUpper();
    if (PlayerChoice != "ROCK" && PlayerChoice != "PAPER" && PlayerChoice != "SCISSORS")
    {
        Console.WriteLine("Enter a correct choice\n");
    }
    else
    {
        Console.WriteLine($"The player choice was {PlayerChoice} the computer choisc was {ComputerChoise}");
        if (PlayerChoice == "ROCK" && ComputerChoise == "PAPER")
        {
            Console.WriteLine("The computer won");
            ComputerScore = ComputerScore + 1;
            Console.WriteLine($"The Player score is {PlayerScore} the Computer score is {ComputerScore}");
        }
        else if (PlayerChoice == "ROCK" && ComputerChoise == "ROCK")
        {
            Console.WriteLine("The resulte was a draw");
            Console.WriteLine($"The Player score is {PlayerScore} the Computer score is {ComputerScore}");
        }
        else if (PlayerChoice == "ROCK" && ComputerChoise == "SCISSORS")
        {
            Console.WriteLine("The Player won");
            PlayerScore = PlayerScore + 1;
            Console.WriteLine($"The Player score is {PlayerScore} the Computer score is {ComputerScore}");
        }
        else if (PlayerChoice == "PAPER" && ComputerChoise == "SCISSORS")
        {
            Console.WriteLine("The computer won");
            ComputerScore = ComputerScore + 1;
            Console.WriteLine($"The Player score is {PlayerScore} the Computer score is {ComputerScore}");
        }
        else if (PlayerChoice == "PAPER" && ComputerChoise == "PAPER")
        {
            Console.WriteLine("The resulte was a draw");
            Console.WriteLine($"The Player score is {PlayerScore} the Computer score is {ComputerScore}");
        }
        else if (PlayerChoice == "PAPER" && ComputerChoise == "ROCK")
        {
            Console.WriteLine("The Player won");
            PlayerScore = PlayerScore + 1;
            Console.WriteLine($"The Player score is {PlayerScore} the Computer score is {ComputerScore}");
        }
        else if (PlayerChoice == "SCISSORS" && ComputerChoise == "ROCK")
        {
            Console.WriteLine("The computer won");
            ComputerScore = ComputerScore + 1;
            Console.WriteLine($"The Player score is {PlayerScore} the Computer score is {ComputerScore}");
        }
        else if (PlayerChoice == "SCISSORS" && ComputerChoise == "SCISSORS")
        {
            Console.WriteLine("The resulte was a draw");
            Console.WriteLine($"The Player score is {PlayerScore} the Computer score is {ComputerScore}");
        }
        else if (PlayerChoice == "SCISSORS" && ComputerChoise == "PAPER")
        {
            Console.WriteLine("The Player won");
            PlayerScore = PlayerScore + 1;
            Console.WriteLine($"The Player score is {PlayerScore}\n the Computer score is {ComputerScore}");
        }
        while (ComputerScore == 3)
        {
            Console.WriteLine("The Computer won GG\n Do you want to play again (Y/N)");
            i = Convert.ToChar(Console.ReadLine().ToUpper());
            if (i == 'Y')
            {
                GameState = true;
                PlayerScore = 0;
                ComputerScore = 0;
            }
            else if (i == 'N')
            {
                GameState = false;
                PlayerScore = 0;
                ComputerScore = 0;
                Console.Clear();
            }
        }
        while (PlayerScore == 3)
        {


            Console.WriteLine("The Player won GG\n Do you want to play again (Y/N)");
            i = Convert.ToChar(Console.ReadLine().ToUpper());
            if (i == 'Y')
            {
                GameState = true;
                PlayerScore = 0;
                ComputerScore = 0;
            }
            else if (i == 'N')
            {
                GameState = false;
                PlayerScore = 0;
                ComputerScore = 0;
            }
        }
    }
}