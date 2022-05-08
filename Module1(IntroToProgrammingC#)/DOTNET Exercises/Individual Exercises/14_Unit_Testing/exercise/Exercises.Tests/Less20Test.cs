using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Exercises.Tests
{
    [TestClass]
    public class Less20Test
    {

        [TestMethod]
        public void IslessThanMultipleOf20Test()
        {
            /*
        Return true if the given non-negative number is 1 or 2 less than a multiple of 20. So for example 38
        and 39 return true, but 40 returns false.
        (Hint: Think "mod".)
        less20(18) → true
        less20(19) → true
        less20(20) → false
        */

            //Arange
            Less20 testObject = new Less20();

            //Act
            bool result = testObject.IsLessThanMultipleOf20(18);

            //Assert
            Assert.IsTrue(result);
        }
    }
}
