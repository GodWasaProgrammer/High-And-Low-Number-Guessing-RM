using System.Threading.Channels;
namespace High_And_Low_Number_Guessing_RM
{
    public class Program
    {
        public static void Main()
        {
            // Secret number
            var MySecretNumber = new Random().Next(0, 100);
            int MaxValue = MySecretNumber + 5;
            int MinValue = MySecretNumber - 5;
            string MyGuess;
            bool IsParsable;
            int MyGuessasInt;
            int Chances = 5;
            // chance do while loop, do while chances are not 0
            do
            {
                if (Chances == 0)
                {
                    Chances = 5;
                }
                do
                {
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.WriteLine($"Your Current amount of chances: {Chances}");
                    Chances--;
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
                        if (MyGuessasInt > MinValue && MyGuessasInt < MySecretNumber)
                        {
                            Console.WriteLine("Too low!");
                            Console.WriteLine("You were Below the secret number, within 5 of the target");

                            if (MyGuessasInt < MinValue)
                            {
                                Console.WriteLine("Way off..too low!");
                            }
                        }
                        if (Chances == 0)
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine("You Lose!");
                            Chances = -1;
                        }
                        if (MyGuessasInt == MySecretNumber)
                        {
                            Console.WriteLine("Amazing. You Win The Prize!111");
                            Console.WriteLine("Game restarting.");
                            Chances = 0;
                        }
                    }
                    while (IsParsable == false);

                    
                } while (Chances > 0);
            } while (Chances > -1);
        }
    }
}