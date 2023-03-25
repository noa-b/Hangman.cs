using System;

namespace Hangman{
    
    protected class defanition{
        


        protected static void Main()
        {
            list<string> words = new list<string> {"the", "a", "there", "answer",
                            "any", "by", "bye", "their"};
        
            Console.WriteLine("Would you like to be the the player or the one how chosses the word?(P-player, C- Chosser)");
            string choice = Console.readLine();
        }  
    } 

}      