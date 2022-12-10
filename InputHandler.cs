namespace High_And_Low_Number_Guessing_RM
{
    public class InputHandler


    {
        public static bool Parsestate = false;

        // method for taking input and returning that parsed input
        public static int TakeInput()

        {

            Console.WriteLine("Take your shot!");
            // string YourGuess;

            // should Parse your input
            bool IsParsable = Int32.TryParse(Console.ReadLine(), out int NumberGuess);


            // if parse succeed, set the public parsestate to true

            if (IsParsable == true)
            {
                Parsestate = IsParsable;
            }

            else
            {
                Console.WriteLine("Could not be parsed");
                Console.WriteLine("Try again");
            }


            //  YourGuess = Console.ReadLine();

            //   NumberGuess = int.Parse(YourGuess);







            //if (string.IsNullOrEmpty(YourGuess))
            //{
            //    Console.WriteLine("You have to put a number in or you wont be be in the game.");
            //}

            return NumberGuess;


            
        }
    }
}
