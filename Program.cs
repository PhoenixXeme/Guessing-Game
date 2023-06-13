using System;

namespace GuessingGame
{
    class Game
    {
        static void Main()
        {

            int min = 0;
            int max = 20;
            int attempts = 6;
            int attempt = 0;
            Random rand = new Random();
            int num = rand.Next(min, max);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Hello welcome to my guessing game");
            Console.WriteLine("a random number has been generated between " + max + " and " + min);
            Console.Write("Enter your guess: ");
            int guess = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");

            while (attempt < attempts) 
            {
                if (guess == num)
                {
                    Console.WriteLine("Congrats You Win. The number was " + num);
                    Console.ReadLine();
                }
                else if (guess < num) 
                {
                    attempt++;
                    Console.WriteLine("Higher. Attempts left: " + attempt + "/" + attempts);
                }
                else if (guess > num)
                {
                    attempt++;
                    Console.WriteLine("Lower. Attempts left: " + attempt + "/" + attempts);
                }


                Console.Write("Enter your guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");
            }
            
            Console.WriteLine("Sorry you ran out of attempts");
            Console.ReadLine();
        }
    }
}
