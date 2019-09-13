using System;

namespace NumGuessingGame
{
    class Program
    {
        //string question = "Enter the MAX amount of Numbers to Guess from: ";

        static int GetIntegerFromUser(string question)
        {
            int integerFromUser;
            bool success;

            do
            {
                Console.WriteLine(question);
                string userResponse = Console.ReadLine();
                success = int.TryParse(userResponse, out integerFromUser);
            } while (success == false);

            return integerFromUser;

        }


        static void Main(string[] args)
        {
            Console.WriteLine("Lets Play GUESS MY NUMBER!!!");
            int max = GetIntegerFromUser("What max range would you like: ");
            Random rnd = new Random();

            int secretNumber = rnd.Next(1, max + 1); //FIND THIS NUMBER
            int close = 0;

            int i = 1;

            do
            {
                int guessNum = GetIntegerFromUser("Guess a number: ");
                if (guessNum < secretNumber)
                {
                    Console.WriteLine("WRONG, Guess a Higher Number: ");
                    i += 1;
                }
                else if (guessNum > secretNumber)
                {
                    Console.WriteLine("WRONG, Guess a Lower Number: ");
                    i += 1;
                }
                else if (guessNum == secretNumber)
                {
                    Console.WriteLine($"You Win!!! it only took {i} number of guesses!");
                    close = 1;
                }
            } while (close != 1);

        }
    }
}