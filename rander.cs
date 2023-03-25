
using System;
using math;
using Random;

namespace Hangman{
    protected static string render{

        
        static list<string> get(list<string> words){this.words = words;}

        //Rendering the first word, will search "theNum+add" elements before retunring the final word.
        //The rendering will be inplemented using     
        string word(list<string> words){
            int wordNum = words.count();
            Random rnd = new Random();
            int indx = rnd.Next(wordNum);

            string theWords = words.indx(indx);
        }

        //The visual representation of how many letters the word has
        string dashes(list<string> words){
            theWord = word(words);


        }
        
    }  
} 