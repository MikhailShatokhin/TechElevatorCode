using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Exercises.Tests
{
    [TestClass]
    public class WordCountTest
    {
        [TestMethod]
        public void GetCountTest()
        {
            /*
        * Given an array of strings, return a Dictionary<string, int> with a key for each different string, with the value the
        * number of times that string appears in the array.
        *
        * ** A CLASSIC **
        *
        * GetCount(["ba", "ba", "black", "sheep"]) → {"ba" : 2, "black": 1, "sheep": 1 }
        * GetCount(["a", "b", "a", "c", "b"]) → {"a": 2, "b": 2, "c": 1}
        * GetCount([]) → {}
        * GetCount(["c", "b", "a"]) → {"c": 1, "b": 1, "a": 1}
        *
        */

            //Arange
            WordCount testObject = new WordCount();


            //Act
            string[] words = new string[3] { "c", "b", "a" };
            Dictionary<string, int> input = new Dictionary<string, int>();
            foreach(string word in words)
            {
                input.Add(word, 1);
            }
            Dictionary<string, int> result = testObject.GetCount(words);


            //Assert
            CollectionAssert.AreEqual(result, input);
        }
    }
}
