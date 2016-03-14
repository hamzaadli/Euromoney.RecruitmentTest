using System;
using ContentConsole.Models;

namespace ContentConsole
{
    public class AdminClass : MainClass
    {
        public override void DoTheProcess()
        {
            Console.WriteLine("\nThe Admin Story (Story 2)");

            Console.WriteLine("list of negative words are : " + negativeWords.GetNegativeWordListAsString());
            Console.WriteLine("Do You Want to add a new negative word ? (Yes/No)");
            string answer = Console.ReadLine();
            if (!String.IsNullOrEmpty(answer) && (answer.ToLower().Equals("yes") || answer.ToLower().Equals("y")))
            {
                Console.WriteLine("Please enter the new negative word :");
                string newWord = Console.ReadLine();
                negativeWords.AddNegativeWords(newWord);
            }

            Console.WriteLine("\nlist of negative words are : " + negativeWords.GetNegativeWordListAsString());

            CheckNegativeWords();

            if (negativeWordsCount > 0)
                Console.WriteLine(" Total number of negative words is : " + negativeWordsCount+"\n");
            else
            {
                Console.WriteLine(" No Negative Words\n");
            }
        }

        public void AddNegativeWords(string word)
        {
            negativeWords.AddNegativeWords(word);
        }
    }
}
