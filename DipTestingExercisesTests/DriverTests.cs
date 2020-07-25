using DipTestingExercises;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace DipTestingExercisesTests
{
    class DriverTests
    {
        public Driver driver;

        [SetUp]
        public void Setup()
        {
            driver = new Driver("Gleant", "Brives", "F", "car");
        }

        [Test]
        public void Constructor()
        {
            Assert.AreEqual("Gleant", driver.fname);
            Assert.AreEqual("Brives", driver.lname);
        }

        [Test]
        public void GetLicenceType()
        {
            Assert.AreEqual("car", driver.getLicenceType());
        }
    }
}
