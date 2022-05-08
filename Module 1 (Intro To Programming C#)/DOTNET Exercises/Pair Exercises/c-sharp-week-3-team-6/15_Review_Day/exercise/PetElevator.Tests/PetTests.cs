using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PetElevator.CRM;


namespace PetElevator.Tests
{
    [TestClass]
    public class PetTests
    {
        [TestMethod]
        public void ListVaccinationsTest()
        {
            Pet testingPet = new Pet("Gabriel", "GSD");

            //Arrange
            testingPet.Vaccinations.Add("Rabies");
            testingPet.Vaccinations.Add("Distemper");
            testingPet.Vaccinations.Add("Parvo");

            //Act
            string result = testingPet.ListVaccinations();

            //Assert
            
            Assert.AreEqual("Rabies, Distemper, Parvo", result);




            //Person person = new Person("Test", "Testerson");

            //string fullName = person.FullName;

            //Assert.AreEqual("Test Testerson", fullName);
        }
    }
}
