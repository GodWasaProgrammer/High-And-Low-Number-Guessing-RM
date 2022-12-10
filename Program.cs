namespace High_And_Low_Number_Guessing_RM
{
    internal class Program
    {
        static void Main()
        {
            var go = new HighLowRandom();
            bool loop = true;
            
            
                go.WelcomeMessage();

                do
            { 
                go.CalculateGuess(InputHandler.TakeInput());

                if (go.MySecretNumber == InputHandler.TakeInput())
                {
                    loop= false;
                }
            }
                while (loop == true);






        }
    }
}