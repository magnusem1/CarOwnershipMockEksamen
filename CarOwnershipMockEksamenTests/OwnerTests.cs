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
    public class OwnerTests
    {
        [TestMethod()]
        [ExpectedException(typeof(ArgumentException))]
        public void OwnerTestAddressLenght8()
        {
            //Arrange
            Owner owner = new Owner("Rosk", "Magnus", "12345678");
            //Act
            //Assert

        }
    }
}