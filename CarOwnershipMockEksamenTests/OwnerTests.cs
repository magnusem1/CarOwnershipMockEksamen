using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarOwnershipMockEksamen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarOwnershipMockEksamen.Tests
{
    /// <summary>
    /// TJekker grænseværdierne på Owner.Address
    /// </summary>
    [TestClass()]
    public class OwnerTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckAddressLengthTestRosk()
        {
            //Arrange
            Owner o1 = new Owner("Rosk", "Magnus", "12345678");
            //Act
            string ad = o1.CheckAddressLength();
            //Assert
            //bruger ikke, da jeg tjekker om der bliver kastet en exception
        }

        [TestMethod()]

        public void CheckAddressLengthTestRoskilde()
        {
            //Arrange
            Owner o2 = new Owner("Roskilde", "Magnus", "12345678");
            //Act
            try
            {
                string ad = o2.CheckAddressLength();
            }
            catch (Exception ex)
            {
                Assert.Fail("Ingen exception kastet" + ex);
            }
        }

        [TestMethod()]
        public void CheckNameLenghtTestMagnus()
        {
            //Arrange
            Owner o1 = new Owner("Roskilde", "Magnus", "12345678");
            //Act
            try
            {
                string nl = o1.CheckAddressLength();
            }
            //Assert
            catch (Exception ex)
            {
                Assert.Fail("Ingen exception kastet" + ex);
            }


        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckNameLenghtTestMag()
        {
            //Arrange
            Owner o1 = new Owner("Roskilde", "Mag", "12345678");

            //Act
            string nl = o1.CheckNameLenght();
        }

        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void CheckPhoneLenghtTest1234()
        {
            //Arrange
            Owner o1 = new Owner("Roskilde", "Magnus", "1234");
            //Act
            string pl = o1.CheckPhoneLenght();
        }
        // skal fejle, da jeg ikke bruger TryCatch som før. Og jeg skriver at jeg forventer en exception.
        [TestMethod()]
       
        public void CheckPhoneLenghtTest12345678()
        {
            Owner o1 = new Owner("Roskilde", "Magnus", "12345678");
            try
            {
                string pl = o1.CheckPhoneLenght();
            }
            catch (Exception ex)
            {

                Assert.Fail("ingen exception" + ex);
            }
            
            
        }
    }
}