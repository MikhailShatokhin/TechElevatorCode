using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class NonStartTest
    {
        [TestMethod]
        public void MainTest()
        {
            /*
       Given 2 strings, return their concatenation, except omit the first char of each. The strings will
       be at least length 1.
       GetPartialString("Hello", "There") → "ellohere"
       GetPartialString("java", "code") → "avaode"
       GetPartialString("shotl", "java") → "hotlava"
       */

            //Arange
            NonStart testObject = new NonStart();

            //Act
            
            string result = testObject.GetPartialString("Hello","There");

            //Assert
            Assert.AreEqual("ellohere",result);
        }
    }
}
