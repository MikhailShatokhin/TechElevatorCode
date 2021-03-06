using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class SameFirstLastTest
    {
        [TestMethod]
        public void IsItTheSameTest()
        {
            /*
       Given an array of ints, return true if the array is length 1 or more, and the first element and
       the last element are equal.
       IsItTheSame([1, 2, 3]) → false
       IsItTheSame([1, 2, 3, 1]) → true
       IsItTheSame([1, 2, 1]) → true
       */


            //Arange
            SameFirstLast testObject = new SameFirstLast();

            //Act
            int[] input = new int[3] { 1, 2, 3 };
            bool result = testObject.IsItTheSame(input);

            //Assert
            Assert.IsFalse(result);

        }
    }
}
