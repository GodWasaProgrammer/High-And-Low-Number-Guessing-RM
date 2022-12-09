using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace High_And_Low_Number_Guessing_RM
{
    public class InputHandler


    {
        
        
        public static int TakeInput()

        {

            string YourGuess = Console.ReadLine();
            
            int NumberGuess;

            NumberGuess = Int32.Parse(YourGuess);


            if (string.IsNullOrEmpty(YourGuess))
            {
                Console.WriteLine("You have to put a number in or you wont be be in the game.");
            }

            return NumberGuess;


            
        }
    }
}
