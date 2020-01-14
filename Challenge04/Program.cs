using System;
using System.Collections;

namespace Challenge
{
    public class Subtitute
    {
        
        static void Main(string[] args)
        {
            // We have some word collection ...
            var censoredWords = new ArrayList();
            censoredWords.Add("imperdiet");
            censoredWords.Add("dolor");
            censoredWords.Add("duo");

            var paragraph = "Lorem ipsum dolor sit amet, imperdiet vituperata duo in, nonumy.";
            paragraph = replace(paragraph, censoredWords);

            Console.Write(paragraph);
        }

        public static string replace(string str, ArrayList censor)
        {
            foreach(string wrd in censor){
                string censorer = "";
                for(int i=0; i<wrd.Length; i++)
                    censorer += '*';

                str = str.Replace(wrd, censorer);
            }

            return str;
        }
    }
}
