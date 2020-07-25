using DipTestingExercises;
using System;
using System.Collections.Generic;
using System.Text;
using NUnit.Framework;

namespace DipTestingExercisesTests
{
    class PassengerTests
    {
        public Passenger passenger;

        [SetUp]
        public void Setup()
        {
            passenger = new Passenger("John", "Smith", "M", "daily");
        }

        [Test]
        public void Constructor()
        {
            Assert.AreEqual("John", passenger.fname);
            Assert.AreEqual("Smith", passenger.lname);
        }

        [Test]
        public void GetLicenceType()
        {
            Assert.AreEqual("daily", passenger.getTicketType());
        }
    }
}
