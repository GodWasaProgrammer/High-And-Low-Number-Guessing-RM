namespace High_And_Low_Number_Guessing_RM
{
    public class HighLowRandom
    {

        public int MySecretNumber = new Random().Next(0, 100);

        public void WelcomeMessage()
        {
            Console.WriteLine("Welcome to our guessing game.");
            Console.WriteLine("input a number between 0 and 100");
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("if you guess within 5 of the Secret Number, you will be told");

        }


        public void CalculateGuess(int Guess)
        {
           

            if(InputHandler.Parsestate == false)
            {
                Console.WriteLine("No calculation was made because you did not put in a correct number");

            }
            if(InputHandler.Parsestate == true) 
            {
                if (Guess == MySecretNumber)
                {
                    Console.WriteLine("You Guessed the secret number!");
                    Console.WriteLine("Thats one in a hundred! Amazing!");

                }
                if (Guess != MySecretNumber)
                {
                    Console.WriteLine("Your guess was not correct");

                    if (Guess == MySecretNumber + 1 || Guess == MySecretNumber + 2 || Guess == MySecretNumber + 3 || Guess == MySecretNumber + 4 || Guess == MySecretNumber + 5 ||
                        Guess == MySecretNumber - 1 || Guess == MySecretNumber - 2 || Guess == MySecretNumber - 3 || Guess == MySecretNumber - 4 || Guess == MySecretNumber - 5)
                    {
                        Console.WriteLine("You were 5 or less number away!");
                        Console.WriteLine($"Your guess was: {Guess}");

                    }
                    if (Guess < MySecretNumber)
                    {
                        Console.WriteLine("Your Guess was too low!");
                    }

                    if (Guess > MySecretNumber)
                    {
                        Console.WriteLine("Your number was too high!");
                    }
                }
           

            }




        }

    }
}
