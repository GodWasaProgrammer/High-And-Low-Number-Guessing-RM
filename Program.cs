namespace High_And_Low_Number_Guessing_RM
{
    public class Program
    {
         
       
        public static void Main()
        {

            // instantiated the game logic

            var go = new HighLowRandom();

            // loop controller 
            // declared true until game is done
            
            bool loop = true;

            // sets winner as the secret number

           
            
            // calls our welcomemessage method

                go.WelcomeMessage();

            // do while loop to loop our game until we done
                do
            { 
                // sets the returned value from takeinput to our local int variable input to be evaluated against the instantiated mysecretnumber

                int input = InputHandler.TakeInput();
                
                go.CalculateGuess(input);
                
                // if input equals secret number, game is won and loop is set to false and the game stops
                
                if (input == go.MySecretNumber)
                {
                    loop = false;
                }
                

               
                
                
            }
                // keeps loop going while loop equals true
                while (loop == true);



            // prints the winning number
            Console.WriteLine($"You won with:{go.MySecretNumber}");



        }

        
    }
}