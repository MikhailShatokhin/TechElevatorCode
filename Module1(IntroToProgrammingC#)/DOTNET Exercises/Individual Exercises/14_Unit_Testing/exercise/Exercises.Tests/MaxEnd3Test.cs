using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class MaxEnd3Test
    {
        [TestMethod]
        public void MakeArrayTest()
        {
            /*
        Given an array of ints length 3, figure out which is larger between the first and last elements
        in the array, and set all the other elements to be that value. Return the changed array.
        MakeArray([1, 2, 3]) → [3, 3, 3]
        MakeArray([11, 5, 9]) → [11, 11, 11]
        MakeArray([2, 11, 3]) → [3, 3, 3]
        */

            //Arange
            MaxEnd3 testObject = new MaxEnd3();

            //Act
            int[] input = new int[3] {1,2,3};
            int[] output = new int[3] {3,3,3};

            int[] result = testObject.MakeArray(input);

            //Assert
            CollectionAssert.AreEqual(output, result);
        }
    }
}
