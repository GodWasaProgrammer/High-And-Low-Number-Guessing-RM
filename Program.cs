using System.Threading.Channels;
namespace High_And_Low_Number_Guessing_RM
{
    public class Program
    {
        public static void Main()
        {
            // Secret number
            int mySecretNumber = new Random().Next(0, 100);
            // our maximum value
            int maxValue = mySecretNumber + 5;
            // our minimum value
            int minValue = mySecretNumber - 5;
            // our guess as string
            string myGuess;
            // our parsebool
            bool isParsable;
            // our guess when parsed to an integer
            int myGuessasInt;
            // our chance integer
            int chances = 5;
            // chance do while loop, do while chances are not 0
            do
            {
                if (chances == 0)
                {
                    chances = 5;
                }
                // Chance loop
                do
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Your Current amount of chances: {chances}");
                    chances--;
                    // Parse Loop
                    do
                    {
                        Console.WriteLine("Write your guess");
                        myGuess = Console.ReadLine();
                        Console.WriteLine(myGuess);
                        isParsable = Int32.TryParse(myGuess, out myGuessasInt);
                        Console.WriteLine("our max value is: " + maxValue);
                        Console.WriteLine("our min value is : " + minValue);
                        // if my guess is below the max value AND above the secret number, do this
                        if (myGuessasInt < maxValue && myGuessasInt > mySecretNumber)
                        {
                            Console.WriteLine("Too high!");
                            Console.WriteLine("You were Above the secret number, within 5 of the target");
                            // if the number is more then 5 off
                            if (myGuessasInt > maxValue)
                            {
                                Console.WriteLine("Way off... too high.");
                            }

                        }

                        // if my guess is below the minvalue AND below mysecretnumber
                        if (myGuessasInt > minValue && myGuessasInt < mySecretNumber)
                        {
                            Console.WriteLine("Too low!");
                            Console.WriteLine("You were Below the secret number, within 5 of the target");
                            // if the number is more then 5 off
                            if (myGuessasInt < minValue)
                            {
                                Console.WriteLine("Way off..too low!");
                            }

                        }

                        // if you run out of chances
                        if (chances == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("You Lose!");
                            // Kills the Game
                            chances = -1;
                        }

                        // if you win
                        if (myGuessasInt == mySecretNumber)
                        {
                            Console.WriteLine("Amazing. You Win The Prize!111");
                            Console.WriteLine("Game restarting.");
                            // sets chances to 0, And restarts the game
                            chances = 0;
                        }

                    }
                    while (isParsable == false);

                } while (chances > 0);

            } while (chances > -1);
        }
    }
}