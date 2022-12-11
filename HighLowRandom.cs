namespace High_And_Low_Number_Guessing_RM
{
    public class HighLowRandom
    {
        // our secret number to calculate against
        public int MySecretNumber = new Random().Next(0, 100);

        public void NewSecretNumber()
        {
            MySecretNumber = new Random().Next(0, 100);
        }
        
        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to our guessing game.");
            Console.WriteLine("input a number between 0 and 100");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("if you guess within 5 of the Secret Number, you will be told");
        }
        // takes an int for your Guess
        public void CalculateGuess(int Guess)
        {
            
            
            if (InputHandler._ParseState == false)
            {
                Console.WriteLine("No calculation was made because you did not put in a correct number");
            }
            // if parse was successful, run calculations
            if (InputHandler._ParseState == true)
            {
                // if your guess is our secret number
                if (Guess == MySecretNumber)
                {
                    Console.WriteLine("You Guessed the secret number!");
                    Console.WriteLine("Thats one in a hundred! Amazing!");
                    NewSecretNumber();
                    WelcomeMessage();

                }
                // if your guess is not our secret number
                if (Guess != MySecretNumber)
                {
                    Console.WriteLine("Your guess was not correct");
                    // The mother of all if's
                    if (Guess == MySecretNumber + 1 || Guess == MySecretNumber + 2 || Guess == MySecretNumber + 3 || Guess == MySecretNumber + 4 || Guess == MySecretNumber + 5 ||
                        Guess == MySecretNumber - 1 || Guess == MySecretNumber - 2 || Guess == MySecretNumber - 3 || Guess == MySecretNumber - 4 || Guess == MySecretNumber - 5)
                    {
                        Console.WriteLine("You were 5 or less number away!");
                        Console.WriteLine($"Your guess was: {Guess}");
                    }
                    // if guess is under our secret number
                    if (Guess < MySecretNumber)
                    {
                        Console.WriteLine("Your Guess was too low!");
                    }
                    // if guess is over our secret number
                    if (Guess > MySecretNumber)
                    {
                        Console.WriteLine("Your number was too high!");
                    }


                }
            }
            
        }
    }
}
