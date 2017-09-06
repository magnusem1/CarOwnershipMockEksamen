using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarOwnershipMockEksamen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOwnershipMockEksamen.Tests
{
    [TestClass()]
    public class CarTests
    {
        [TestMethod()]
        public void CheckValidDoorsTest2Doors()
        {
            Car c1 = new Car(2, "audi", "9999999");

        }

        [TestMethod()]

        //Den er ville fejle, hvis en exception bliver kastet. Fortæller den tilat kaste en exception og griben den igen.

        public void CheckValidDoorsTest5Doors()
        {
            Car c1 = new Car(5, "audi", "9999999");
            try
            {
                int vd = c1.CheckValidDoors();
            }
            //Assert
            catch (Exception ex)
            {
                Assert.Fail("Ingen exception kastet" + ex);
            }
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void RegistrationNoCheckTest12345678()
        {
            //Arrange
            Car c1 = new Car(4, "Audi", "12345678");
            string regnotest = c1.RegistrationNoCheck();

        }

        [TestMethod()]
        public void RegistrationNoCheckTest1234567()
        {
            Car c1 = new Car(4, "Audi", "1234567");
            string regnotest = c1.RegistrationNoCheck();
        }
    }
}
