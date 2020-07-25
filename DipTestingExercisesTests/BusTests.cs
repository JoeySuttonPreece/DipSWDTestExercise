using NUnit.Framework;
using DipTestingExercises;
using System;

namespace DipTestingExercisesTests
{
    public class BusTests
    {
        public Bus bus;

        [SetUp]
        public void Setup()
        {
            bus = new Bus(new SpoofPerson(), 100, 50, 2, 1);
        }

        [Test]
        public void Constructor()
        {
            Assert.AreEqual(1, bus.maxPassengers);
        }

        [Test]
        public void GetPassengerCountNone()
        {
            Assert.AreEqual(0, bus.getPassengerCount());
        }

        [Test]
        public void GetPassengerCountOne()
        {
            bus.passengers.Add(new SpoofPerson());
            Assert.AreEqual(1, bus.getPassengerCount());
        }

        [Test]
        public void EmbarkWithRoom()
        {
            bus.embarkPassenger(new SpoofPerson("working?"));
            Assert.AreEqual("working?", bus.passengers[0].getName());
        }

        [Test]
        public void EmbarkWithoutRoom()
        {
            bus.embarkPassenger(new SpoofPerson());
            Exception exception = Assert.Throws<Exception>(() => bus.embarkPassenger(new SpoofPerson()));
            Assert.IsTrue(exception.Message.Contains("Bus"));
            Assert.IsTrue(exception.Message.Contains("Full"));
            Assert.AreEqual(1, bus.passengers.Count);
        }
    }
}
