using System;
using System.Collections;

namespace Substitution
{
    class Program
    {
        
        static void Main(string[] args)
        {
            // We have some word collection ...
            var censoredWords = new ArrayList();
            censoredWords.Add("imperdiet");
            censoredWords.Add("dolor");
            censoredWords.Add("duo");

            // and a paragraph.
            var paragraph = "Lorem ipsum dolor sit amet, imperdiet vituperata duo in, nonumy.";

            // Censor the words in paragraph by using * symbol.
            // Output example:
            // Lorem ipsum ***** sit amet, ********* vituperata *** in, nonumy.

            foreach(string wrd in censoredWords){
                string censorer = "";
                for(int i=0; i<wrd.Length; i++)
                    censorer += '*';

                paragraph = paragraph.Replace(wrd, censorer);
            }

            Console.Write(paragraph);
        }
    }
}
