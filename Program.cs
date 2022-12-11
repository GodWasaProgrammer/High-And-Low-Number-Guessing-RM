using System.Threading.Channels;
namespace High_And_Low_Number_Guessing_RM
{
    public class Program
    {
        public static void Main()
        {
            // instantiated the game logic
            var go = new HighLowRandom();
            // loop controller 
            // declared true until game is done
            bool loop = true;
            int chances = 0;
            // sets winner as the secret number
            // calls our welcomemessage method
            go.WelcomeMessage();
            // do while loop to loop our game until we done
            do
            {
                // sets the returned value from takeinput to our local int variable input to be evaluated against the instantiated mysecretnumber
                Chances();
                int input = InputHandler.TakeInput();
                go.CalculateGuess(input);
                if (InputHandler._ParseState == true)
                { 
                chances++;
                }
            }
            // keeps loop going while loop equals true
            while (loop == true);
            // chance method
             void Chances()
            {
                if (chances < 5)
                {
                    Console.WriteLine($"Your Current amount of chances spent:{chances} out of 5");
                }
                if (chances == 5)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Your Current amount of chances spent:{chances} out of 5 ");
                    Console.WriteLine("You have lost!");
                    chances = 0;
                    go.NewSecretNumber();
                    go.WelcomeMessage();
                }
            }
            // prints the winning number
            Console.WriteLine($"You won with:{go.MySecretNumber}");
        }
    }
}