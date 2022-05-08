using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PetElevator.CRM;

namespace PetElevator.Tests
{
    [TestClass]
    public class CustomerTests
    {
        [TestMethod]
        public void GetBalanceDueTest()
        {

            //Arrange
            Customer testObject = new Customer("John", "Fult");
            Dictionary<string, double> actual = new Dictionary<string, double>();
            actual.Add("Grooming",10.0);
            actual.Add("Walking",10.0);
            actual.Add("Sitting",10.0);

            //Act
            double result = testObject.GetBalanceDue(actual);

            //Assert
            Assert.AreEqual(30.0, result);
        }
    }
}
