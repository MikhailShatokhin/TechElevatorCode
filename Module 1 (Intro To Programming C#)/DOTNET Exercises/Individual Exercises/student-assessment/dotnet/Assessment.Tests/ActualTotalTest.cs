using Microsoft.VisualStudio.TestTools.UnitTesting;
using Assessment.Models;

namespace Assessment.Tests
{
    [TestClass]
    public class ActualTotalTest
    {
        [TestMethod]
        public void ActualTotalTests()
        {
            //Arrange
            WorkOrder testObject = new WorkOrder("Fred", 10, 10);

            //Act
            double actual = testObject.ActualTotal(true,true);
            double test = (16.98*2)+4.99;

            //Assert
            Assert.AreEqual(actual, test);

            // There should be a test class to test the new class.
            // the UnitTest1 class can server as a template for what's inside of
            // the test class
        }
    }
}
