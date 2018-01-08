using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guessing
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int number = rnd.Next(1, 10);
            Console.WriteLine("Guess the number I am thinking of between one and ten.");
            while (true)
            {
                var entry = Console.ReadLine();
                try
                {
                    int guess = int.Parse(entry);
                    if (number == guess)
                    {
                        Console.WriteLine("Correct!");
                        Console.WriteLine("Play again?");
                        var answer = Console.ReadLine();
                        continue;
                        //TODO implement play again
                    }
                    if (guess < 1 || guess > 10)
                    {
                        Console.WriteLine("I said between one and ten!");
                        continue;
                    }
                    if (number > guess)
                    {
                        Console.WriteLine("Higher!");
                        continue;
                    }
                    if (number < guess)
                    {
                        Console.WriteLine("Lower!");
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("That is not a valid answer");
                }
            }
        }
    }
}
