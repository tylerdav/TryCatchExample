using System;

namespace TryCatchIntro
{
    class Program
    {
        static void Main (string[] args)
        {
            int difficulty = 0;

            while (true)
            {
                try
                {
                    Console.Write ("What is the bank difficulty? ");
                    var userInput = Console.ReadLine ();
                    difficulty = int.Parse (userInput);
                    var taco = 100 / difficulty;
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine ("Oops something went wrong");
                }
            }

            Console.WriteLine ($"The difficulty is {difficulty}");
        }
    }
}