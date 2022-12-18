using System.Threading.Channels;
namespace High_And_Low_Number_Guessing_RM
{
    public class Program
    {
        public static void Main()
        {
            // Secret number
            var MySecretNumber = new Random().Next(0, 100);
            // our maximum value
            int MaxValue = MySecretNumber + 5;
            // our minimum value
            int MinValue = MySecretNumber - 5;
            // our guess as string
            string MyGuess;
            // our parsebool
            bool IsParsable;
            // our guess when parsed to an integer
            int MyGuessasInt;
            // our chance integer
            int Chances = 5;
            // chance do while loop, do while chances are not 0
            do
            {
                if (Chances == 0)
                {
                    Chances = 5;
                }
                // Chance loop
                do
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Your Current amount of chances: {Chances}");
                    Chances--;
                    // Parse Loop
                    do
                    {
                        Console.WriteLine("Write your guess");
                        MyGuess = Console.ReadLine();
                        Console.WriteLine(MyGuess);
                        IsParsable = Int32.TryParse(MyGuess, out MyGuessasInt);
                        Console.WriteLine("our max value is: " + MaxValue);
                        Console.WriteLine("our min value is : " + MinValue);
                        // if my guess is below the max value AND above the secret number, do this
                        if (MyGuessasInt < MaxValue && MyGuessasInt > MySecretNumber)
                        {
                            Console.WriteLine("Too high!");
                            Console.WriteLine("You were Above the secret number, within 5 of the target");
                            // if the number is more then 5 off
                            if (MyGuessasInt > MaxValue)
                            {
                                Console.WriteLine("Way off... too high.");
                            }
                        }
                        // if my guess is below the minvalue AND below mysecretnumber
                        if (MyGuessasInt > MinValue && MyGuessasInt < MySecretNumber)
                        {
                            Console.WriteLine("Too low!");
                            Console.WriteLine("You were Below the secret number, within 5 of the target");
                            // if the number is more then 5 off
                            if (MyGuessasInt < MinValue)
                            {
                                Console.WriteLine("Way off..too low!");
                            }
                        }
                        // if you run out of chances
                        if (Chances == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("You Lose!");
                            // Kills the Game
                            Chances = -1;
                        }
                        // if you win
                        if (MyGuessasInt == MySecretNumber)
                        {
                            Console.WriteLine("Amazing. You Win The Prize!111");
                            Console.WriteLine("Game restarting.");
                            // sets chances to 0, And restarts the game
                            Chances = 0;
                        }
                    }
                    while (IsParsable == false);
                } while (Chances > 0);
            } while (Chances > -1);
        }
    }
}