using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContentConsole
{
    public class NegativeWords
    {
      
        List<string> NegativeWordList = new List<string>
        { "swine","bad","nasty","horrible" };

        string negativeWordS = String.Empty;

        public void AddNegativeWords(string word)
        {
            if (!NegativeWordList.Contains(word))
                NegativeWordList.Add(word);
            else
                Console.WriteLine(word + " is already added");
        }

        public List<string> GetNegativeWordList()
        {
            return NegativeWordList.ToList();
        }

        public string GetNegativeWordListAsString()
        {
            negativeWordS ="\n";
            for (int index=0;index < NegativeWordList.Count;index++)
            {

                negativeWordS += NegativeWordList[index]+"\n";
            }
            return negativeWordS;
        }
    } 

    public static class Context
    {
        public static string data =
           "The weather in Manchester in winter is bad. It rains all the time - it must be horrible for people visiting.";

    }
    
}
