using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentConsole.Models
{
    public abstract class MainClass
    {
       public NegativeWords negativeWords = new NegativeWords();
        public int negativeWordsCount = 0;
        public IEnumerable<string> badWordsFromText = new List<string>();

        public void CheckNegativeWords()
        {
            string[] sentences = Context.data.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' },
                StringSplitOptions.RemoveEmptyEntries);
             badWordsFromText = from sentence in sentences
                                join words in negativeWords.GetNegativeWordList() on sentence.ToLower() equals words.ToLower()
                                select sentence;

            negativeWordsCount = badWordsFromText.Count();

        }
        public abstract void DoTheProcess();
    }
}
