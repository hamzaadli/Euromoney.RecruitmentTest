using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using ContentConsole.Models;

namespace ContentConsole
{
    public class ReaderClass : MainClass
    {
        public override void DoTheProcess()
        {
            Console.WriteLine("The Reader Story (Story 3)");
            Console.WriteLine("Text is : \n" + FilterNegativeWords() + "\n");
        }

        public string FilterNegativeWords()
        {
            string filteredText = Context.data;
            CheckNegativeWords();
            IEnumerable<string> badWordsList = badWordsFromText.Distinct();

            foreach (string word in badWordsList)
            {
                filteredText = filteredText.Replace(word, Regex.Replace(word, @"(?<=[a-z])([a-z]+?)(?=[a-z])", "*"));
            }

            return filteredText;
        }
    }
}