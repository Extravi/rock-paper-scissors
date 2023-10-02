using System;

class Program
{
    static void Main(string[] args)
    {
        string[] choices = { "Rock", "Paper", "Scissors" };
        const int RockChoice = 1;
        const int PaperChoice = 2;
        const int ScissorsChoice = 3;

        string rock =
            @"
    _______
---'   ____)
      (_____)
      (_____)
      (____)
---.__(___)
";

        string paper =
            @"
     _______
---'    ____)____
           ______)
          _______)
         _______)
---.__________)
";

        string scissors =
            @"
    _______
---'   ____)____
          ______)
       __________)
      (____)
---.__(___)
";

        bool validInput = false;

        Random random = new Random();
        int randomIndex = random.Next(choices.Length);
        string randomChoice = choices[randomIndex];

        for (int i = 1; i <= choices.Length; i++)
        {
            Console.WriteLine($"{i}) {choices[i - 1]}");
        }

        string strippedChoice = GetUserChoice();

        while (!validInput)
        {
            if (
                strippedChoice != RockChoice.ToString()
                && strippedChoice != PaperChoice.ToString()
                && strippedChoice != ScissorsChoice.ToString()
            )
            {
                strippedChoice = GetUserChoice();
            }
            else
            {
                switch (strippedChoice)
                {
                    case "1":
                        Console.WriteLine("\nYou selected: Rock!");
                        Console.WriteLine(rock);
                        Console.WriteLine("The bot selected: " + randomChoice + "!");
                        if (randomChoice == "Rock")
                        {
                            Console.WriteLine(rock);
                        }
                        else if (randomChoice == "Paper")
                        {
                            Console.WriteLine(paper);
                        }
                        else
                        {
                            Console.WriteLine(scissors);
                        }
                        if (strippedChoice == "1" && randomChoice == "Scissors")
                        {
                            Console.WriteLine("You won!\n");
                        }
                        else if (randomChoice == "Rock")
                        {
                            Console.WriteLine("It's a tie!\n");
                        }
                        else
                        {
                            Console.WriteLine("The bot wins!\n");
                        }
                        break;
                    case "2":
                        Console.WriteLine("\nYou selected: Paper!");
                        Console.WriteLine(paper);
                        Console.WriteLine("The bot selected: " + randomChoice + "!");
                        if (randomChoice == "Rock")
                        {
                            Console.WriteLine(rock);
                        }
                        else if (randomChoice == "Paper")
                        {
                            Console.WriteLine(paper);
                        }
                        else
                        {
                            Console.WriteLine(scissors);
                        }
                        if (strippedChoice == "2" && randomChoice == "Rock")
                        {
                            Console.WriteLine("You won!\n");
                        }
                        else if (randomChoice == "Paper")
                        {
                            Console.WriteLine("It's a tie!\n");
                        }
                        else
                        {
                            Console.WriteLine("The bot wins!\n");
                        }
                        break;
                    case "3":
                        Console.WriteLine("\nYou selected: Scissors!");
                        Console.WriteLine(scissors);
                        Console.WriteLine("The bot selected: " + randomChoice + "!");
                        if (randomChoice == "Rock")
                        {
                            Console.WriteLine(rock);
                        }
                        else if (randomChoice == "Paper")
                        {
                            Console.WriteLine(paper);
                        }
                        else
                        {
                            Console.WriteLine(scissors);
                        }
                        if (strippedChoice == "3" && randomChoice == "Paper")
                        {
                            Console.WriteLine("You won!\n");
                        }
                        else if (randomChoice == "Scissors")
                        {
                            Console.WriteLine("It's a tie!\n");
                        }
                        else
                        {
                            Console.WriteLine("The bot wins!\n");
                        }
                        break;
                    default:
                        break;
                }
                validInput = true;
            }
        }
    }

    static string GetUserChoice()
    {
        Console.Write("Rock, Paper, or Scissors: ");
        string choice = Console.ReadLine();
        string strippedChoice = choice.Replace(" ", "");
        return strippedChoice;
    }
}
