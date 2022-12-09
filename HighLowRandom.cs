using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_And_Low_Number_Guessing_RM
{
    public class HighLowRandom
    {
        
        public int MySecretNumber = new Random().Next(0,100);
        
        public void WelcomeMessage()
        { Console.WriteLine("Welcome to our guessing game.");
            Console.WriteLine("input a number between 0 and 100");
            Console.BackgroundColor= ConsoleColor.Green;
            Console.WriteLine("if you guess within 5 of the Secret Number, you will be told");

        }
        

        public void CalculateGuess(int Guess)
        {
            int guess = Int32.Parse(Console.ReadLine());

        }

    }
}
