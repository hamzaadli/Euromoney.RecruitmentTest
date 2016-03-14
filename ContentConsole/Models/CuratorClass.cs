using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContentConsole.Models;

namespace ContentConsole
{
    public class CuratorClass : MainClass
    {
        public override void DoTheProcess()
        {
            Console.WriteLine("\n\n\nThe Content Curator Story (Story 4)");
            
            CheckNegativeWords();

            Console.WriteLine("Total Number of negative words: " + negativeWordsCount + "\n");
            Console.WriteLine("This is the original text:");
            Console.WriteLine(GetOriginalText());
        }

        public string GetOriginalText()
        {
            return Context.data;
        }
    }
}
