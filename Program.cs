namespace High_And_Low_Number_Guessing_RM
{
    public class Program
    {
        public static int Winner;
        public static void Main()
        {
            var go = new HighLowRandom();
            bool loop = true;

            Winner = go.MySecretNumber;
            
            
                go.WelcomeMessage();

                do
            { 
                int input = InputHandler.TakeInput();
                go.CalculateGuess(input);
                
                if (input == go.MySecretNumber)
                {
                    loop = false;
                }
                

               
                
                
            }
                while (loop == true);




            Console.WriteLine($"You won with:{go.MySecretNumber}");



        }

        
    }
}