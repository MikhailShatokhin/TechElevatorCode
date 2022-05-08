using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class FrontTimesTest
    {
        [TestMethod]
        public void GenerateStringTest()
        {
            /*
       Given a string and a non-negative int n, we'll say that the front of the string is the first 3 chars, or
       whatever is there if the string is less than length 3. Return n copies of the front;
       frontTimes("Chocolate", 2) → "ChoCho"
       frontTimes("Chocolate", 3) → "ChoChoCho"
       frontTimes("Abc", 3) → "AbcAbcAbc"
       */

            //Arange
            FrontTimes testObject = new FrontTimes();

            //Act
            string result = testObject.GenerateString("Chocolate", 2);

            //Assert
            Assert.AreEqual("ChoCho", result);

        }
    }
}
