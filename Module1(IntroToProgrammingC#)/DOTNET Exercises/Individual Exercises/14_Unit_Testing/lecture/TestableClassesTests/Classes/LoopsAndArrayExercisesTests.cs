using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestableClasses.Classes.Tests
{
    [TestClass()]
    public class LoopsAndArrayExercisesTests
    {
        [TestMethod]
        public void MaxEnd3Test()
        {
            //Given an array of ints length 3, figure out which is larger between the first and last elements
            //in the array, and set all the other elements to be that value. Return the changed array.
            //maxEnd3([1, 2, 3]) → [3, 3, 3]
            //maxEnd3([11, 5, 9]) → [11, 11, 11]
            //maxEnd3([2, 11, 3]) → [3, 3, 3]

            //Arrange
            LoopsAndArrayExercises testObject = new LoopsAndArrayExercises();

            //Act
            int[] result = testObject.MaxEnd3(new int[] { 1, 5, 9 });

            //Assert
            CollectionAssert.AreEqual(new int[] { 9, 9, 9 },result);

        }
        //CollectionAssert
        //.AllItemsAreNotNull() - Looks at each item in actual collection for not null
        //.AllItemsAreUnique() - Checks for uniqueness among actual collection
        //.AreEqual() - Checks to see if two collections are equal (same order and quantity)
        //.AreEquilavent() - Checks to see if two collections have same element in same quantity, any order
        //.AreNotEqual() - Opposite of AreEqual
        //.AreNotEquilavent() - Opposite or AreEqualivent
        //.Contains() - Checks to see if collection contains a value/object


    }
}
