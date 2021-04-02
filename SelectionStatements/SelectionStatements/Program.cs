using System;

namespace SelectionStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("See if you can guess my favorite number");
            Console.WriteLine("What is the upper limit of the range of your number?");

            var userResponse = Console.ReadLine();
            var upperLimit = int.Parse(userResponse);


            var random = new Random();
            var number = random.Next(1,upperLimit);

            Console.WriteLine("Input your guess:");

            var guess = int.Parse(Console.ReadLine());

            if(guess > number)
            {
                Console.WriteLine("Your guess is to high! Sorry!");
            }
            else if(guess < number)
            {
                Console.WriteLine("Your guess is to low! Sorry!");
            }
            else
            {
                Console.WriteLine("Congrats thats correct!!");
            }    
        }
    }
}
