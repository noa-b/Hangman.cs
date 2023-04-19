namespace hangman{
    public class chooser{

        //Will randomly "pick" a num between 0 and the number of wards present in the arr named words.    
        public string wordChoose(string[] wordsArr){
            int wordNum = wordsArr.Length;
            Random rnd = new Random();
            int indx = rnd.Next(wordNum);
            
            string theWord = wordsArr[indx];
            Console.WriteLine(theWord);
            return theWord;
        }

        //The visual representation of how many letters the word has
        public string dasheDraw(string[] wordsArr){
            string word = wordChoose(wordsArr);
            string dashes = "_";
            for(int i=1; i<wordsArr.Length;i++){ 
                dashes += " _" ;
            }
            return dashes;
        }         
    }
}