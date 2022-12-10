namespace High_And_Low_Number_Guessing_RM
{
    public class InputHandler


    {


        public static int TakeInput()

        {
            Console.WriteLine("Take your shot!");
            int NumberGuess;
            string YourGuess;

            
                YourGuess = Console.ReadLine();
                NumberGuess = int.Parse(YourGuess);
            
            


                


                if (string.IsNullOrEmpty(YourGuess))
                {
                    Console.WriteLine("You have to put a number in or you wont be be in the game.");
                }

                return NumberGuess;


            
        }
    }
}
