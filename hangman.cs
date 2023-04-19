using System;
using hangman.chooser;

namespace hangman{
    public class Prog:hangman.chooser{
        public static void Main()
        {
            string[] wordsArr = {"the", "a", "there", "answer",
                            "any", "by", "bye", "their"};


            Console.WriteLine("Would you like to be the the player or the one how chosses the word?(P-player, C- Chosser) ");
            char choice = Convert.ToChar(Console.ReadLine());
            if(choice.ToUpper = "C"){
                var obje = new hangman.chooser();
                //string Word = obje.wordChoose();
                string currDashes = obje.dasheDraw(wordsArr);
                Console.WriteLine(currDashes);

                var play = new hangman.chooser();
            }
            else if(choice.ToUpper = "Y"){
                Console.WriteLine("You choose to be the chooser, the program will play as the guesser");
                string random; 
                Console.WriteLine("Enter a random string: ");
                random = Console.ReadLine();
                Console.WriteLine("The random string entered is : " +random);    
                Console.ReadLine();
            }
            else{
                Console.WriteLine("Please enter a valid answer");

            }
        }  
    }     
}   