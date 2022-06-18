using System;

namespace SelectionStatementsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var r = new Random();
            var favNumber = r.Next(0, 1001);
            int userInput;

            do
            {

                Console.WriteLine("Welcome to the number guessing game!");
                Console.WriteLine("Pick a number from 1 - 1000");
                userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine($"{userInput} is too low, LOSER!");
                }

                else if (userInput > favNumber)
                {
                    Console.WriteLine($"{userInput} is too high, LOSER");
                }

                else
                {
                    Console.WriteLine("You guessed it!");
                }
            } while (favNumber != userInput);

            //string subject = "c#";

            //Console.WriteLine("Choose a subject");
            //string userSubject = Console.ReadLine();

            //switch (userSubject)
            //    {
            //    case "c#":
            //        Console.WriteLine("You are in the right class!");
            //        break;
            //    case "Java":
            //        Console.WriteLine("c# is better than Java!");
            //        break;

            //    default:
            //        Console.WriteLine("We teach coding here.");
            //        break;
            //}
        }
    }
}
