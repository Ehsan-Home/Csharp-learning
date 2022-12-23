using System;

namespace GuessNumberChallenge
{
    class Program
    {
        static void Main(string[] args)
        {
            string numStr = "";
            int guesses = 0;
            // int guess = 15;
            Random random = new Random();
            int guess = random.Next(0, 20);
            while (true)
            {
                numStr = Console.ReadLine();
                try
                {
                    int guessedNum = int.Parse(numStr);
                    guesses++;
                    if (guessedNum == -1)
                    {
                        Console.WriteLine($"Oh. Well my number was {guess}");
                        break;
                    }
                    else if (guessedNum == guess)
                    {
                        Console.WriteLine($"You got it in {guesses}  guesses.");
                        break;
                    }
                    Console.WriteLine("Nope. {0} than that.", guessedNum > guess ? "Lower" : "Higher");
                }
                catch (System.Exception)
                {
                    Console.WriteLine("That doesn't look like number.try again");
                }
            }
        }
    }
}