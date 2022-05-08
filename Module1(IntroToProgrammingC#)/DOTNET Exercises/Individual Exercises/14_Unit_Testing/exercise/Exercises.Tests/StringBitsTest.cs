using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class StringBitsTest
    {
        [TestMethod]
        public void GetBitsTest()
        {
            /*
       Given a string, return a new string made of every other char starting with the first, so "Hello" yields "Hlo".
       GetBits("Hello") → "Hlo"
       GetBits("Hi") → "H"
       GetBits("Heeololeo") → "Hello"
       */

            //Arange
            StringBits testObject = new StringBits();

            //Act
            string result = testObject.GetBits("Hello");

            //Assert
            Assert.AreEqual("Hlo",result);
        }
    }
}
