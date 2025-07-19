using System.Collections;
namespace QuizGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to second project Quiz Game");
            Console.WriteLine("You have 3 tries enjoy the game");
            bool repeat = true;
            List<string> Questions = new List<String>() 
            {
                "What is the capital of France?",
                "What is 2 + 2?",
                "What is the boiling point of water in Celsius?"
            };
            List<string> Answers = new List<string>()
            {
                "Paris",
                "4",
                "100"
            };
            while(repeat) 
            {
                for (int i = 0; i < Questions.Count; i++)
                {
                    Console.WriteLine(Questions[i]);
                    string userinpt = Console.ReadLine();
                    bool result = CorrectOrNot(userinpt, Answers[i]);
                    int tries = 2;
                    try
                    {
                        if(result == true)
                        {
                            Console.WriteLine("Correct Answer (: ");
                        }
                        else
                        {
                            Console.WriteLine("Try Again ");
                            while (tries > 0 )
                            {
                                Console.WriteLine($"You have : {tries} Tries");
                                userinpt = Console.ReadLine();
                                if (result == true)
                                {
                                    Console.WriteLine("Correct Answer (: ");
                                }
                                else
                                {
                                    Console.WriteLine("Try Again");
                                }
                                tries--;
                            }
                        }
                    }
                    catch(Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }
                Console.WriteLine("Play Again ? (y/n) or E to Exit");
                string userinput = Console.ReadLine();
                switch (userinput)
                {
                    case "y":
                        repeat = true;
                        break;
                    case "n":
                        repeat = false;
                        break;
                    case "E":
                        Environment.Exit(0); // This will exit automatically
                        break;
                    default:
                        break;
                }
            }
        
        }
        static private bool CorrectOrNot(string userinput, string answer)
        {
            if(String.IsNullOrEmpty(userinput))
            {
                throw new Exception("answer can't be empty");
            }
            /* 
               Note : we can use return like this below but try catch will not work well as
               it check for the input if it was empty or null !
               ==> return String.Equals(userinput, answer, StringComparison.OrdinalIgnoreCase);
               why using this ? if the user for ex: input pAriS it will be correct !
            */
            if(userinput == answer)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
