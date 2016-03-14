using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace ContentConsole.Test.Unit
{
    internal class ContentTest
    {
        [TestFixture]
        public class UserTests
        {
            [Test]
            public void TestAdminReturnNegativeWords()
            {

                AdminClass admin = new AdminClass();

                string negativeWords = admin.negativeWords.GetNegativeWordListAsString();


                //Assert
                Assert.IsTrue(negativeWords.Contains("nasty"));
            }

            [Test]
            public void TestAdminAddNegativeWord()
            {

                AdminClass admin = new AdminClass();


                admin.AddNegativeWords("sad");
                List<string> words = admin.negativeWords.GetNegativeWordList();
                
                //Assert
                Assert.IsTrue(words.Contains("sad"));
                Assert.AreEqual(5, admin.negativeWords.GetNegativeWordList().Count);
            }

            [Test]
            public void UserReturnNegativeWordsCount()
            {
                
                UserClass user = new UserClass();

                user.CheckNegativeWords();
                int count = user.negativeWordsCount;


                //Assert
                Assert.AreEqual(2, count);
            }

            [Test]
            public void ReaderReturnNegativeWords()
            {

                ReaderClass reader = new ReaderClass();

                string words = reader.FilterNegativeWords();

                //Assert
                Assert.IsTrue(words.Contains("h******e"));
            }


            [Test]
            public void ContenturatorUserTestReturnOriginalcontent()
            {

                CuratorClass curator = new CuratorClass();

                string words = curator.GetOriginalText();

                //Assert
                Assert.IsTrue(words.Contains("bad"));
            }

        }
    }
}