class Program
{
    static void Main(string[] args)
    {
        int score = 0;
        bool menuRunning = true;
        int level = 1;
        while (menuRunning)
        {
           
            Console.ForegroundColor = ConsoleColor.White;
            bool gameRunning = true;
            Random randomNumber = new Random();
            int multiplier;
            multiplier = 1 + (level * 100);

            int numberToGuess = randomNumber.Next(1, multiplier);


            Console.Clear();
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
                        score -= 20;
                        Console.WriteLine($"YOUR GUESS IS TOO LOW!\nYour score now is: {score}");
                    }
                    else if (userInputInt > numberToGuess)
                    {
                        Console.Clear();
                        Console.WriteLine($"YOUR GUESS IS TOO HIGH!\nYour score now is: {score}");
                    }
                    else if (userInputInt == numberToGuess)
                    {
                        Console.Clear();
                        score += 200;
                        Console.WriteLine($"YOU GUESSED IT RIGHT!\nYour score now is: {score}");
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
