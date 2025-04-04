class Program
{
    static void Main(string[] args)
    {
        int score = 0;
        bool menuRunning = true;
        int level = 1;
        while (menuRunning)
        {
            bool gameRunning = true;
            Random randomNumber = new Random();
            int multiplier;
            multiplier = 1 + (level * 100);

            int numberToGuess = randomNumber.Next(1, multiplier);


            Console.Clear();
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Welcome to the guess the number game!");
            Console.WriteLine($"You are on level {level}!");

            while (gameRunning)
            {
                Console.WriteLine($"\nPlease enter a number between 1 and {multiplier - 1}:");

                try
                {
                    string userInput = Console.ReadLine();
                int userInputInt = int.Parse(userInput);

                
                    if (userInputInt < numberToGuess)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        score -= 20;
                        Console.WriteLine($"YOUR GUESS IS TOO LOW!\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Your score now is: {score}");
                    }
                    else if (userInputInt > numberToGuess)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"YOUR GUESS IS TOO HIGH!\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Your score now is: {score}");
                    }
                    else if (userInputInt == numberToGuess)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Green;
                        score += 200;
                        Console.WriteLine($"YOU GUESSED IT RIGHT!\n");
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine($"Your score now is: {score}");
                        Console.WriteLine($"Do you want to go to level {level + 1}?   (y/n)");
                        string answer = Console.ReadLine();

                        if (answer.Trim().ToLower() == "y")
                        {
                            level++;
                            Console.WriteLine($"You are now on level {level}");
                            gameRunning = false;
                        }
                        else if (answer.Trim().ToLower() == "n")
                        {
                            gameRunning = false;
                        }

                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine("Please try again!");
                    continue;
                }


            }
        }
    }
}
