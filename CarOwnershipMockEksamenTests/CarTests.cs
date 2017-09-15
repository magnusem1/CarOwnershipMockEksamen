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
        [ExpectedException(typeof(ArgumentException))]
        public void CarTestDoors1()
        {
            //Arrange
            Car car = new Car(1, "Audi", "1234567");
            //Act
            //Assert
        }

        [TestMethod()]
        public void CarTestDoors2()
        {
            //Arrange
            Car car = new Car(2, "Audi", "1234567");
            //Act
            int Doors = car.Doors;
            //Assert
            Assert.AreEqual(2, Doors);
        }
    }
}