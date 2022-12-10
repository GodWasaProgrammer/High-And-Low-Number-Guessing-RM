namespace High_And_Low_Number_Guessing_RM
{
    public class Program
    {
        public static int Winner;
        public static void Main()
        {
            var go = new HighLowRandom();
            bool loop = true;

            go.MySecretNumber = Winner;
            
            
                go.WelcomeMessage();

                do
            { 
                go.CalculateGuess(InputHandler.TakeInput());
                

                

               
                
                
            }
                while (loop == true);




            Console.WriteLine($"You won with:{go.MySecretNumber}");



        }

        
    }
}