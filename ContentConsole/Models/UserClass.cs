using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContentConsole.Models;

namespace ContentConsole
{
    public  class UserClass : MainClass
    { 
        public override void DoTheProcess()
        {
            Console.WriteLine("The User Story (Story 1)");
            Console.WriteLine("Text is : ");

            Console.WriteLine(Context.data);
            CheckNegativeWords();

            if (negativeWordsCount > 0)
                Console.WriteLine(" Total number of negative words is : " + negativeWordsCount + "\n");
            else
            {
                Console.WriteLine(" No Negative Words" + "\n"); 
            }
        }
    }
}
