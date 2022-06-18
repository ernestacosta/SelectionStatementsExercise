using System;

namespace SelectionStatementsExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the number guessing game!");
            Console.WriteLine("Pick a number from 1 to 1000!");
            int favNumber = 200;
            int userGuess = int.Parse(Console.ReadLine());



            if (userGuess == favNumber)
            {
                Console.WriteLine($"Correct!");
            }
            else if (userGuess > favNumber)
            {
                Console.WriteLine($"Too High! Try again!");
            }
            else
            {
                Console.WriteLine($"Too low! Try again");
            }

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
