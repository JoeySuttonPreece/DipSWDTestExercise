using NUnit.Framework;
using DipTestingExercises;
using System;

namespace DipTestingExercisesTests
{
    public class MotorVehicleTests
    {
        public FakeMotorVehicle motorVehicle;

        [SetUp]
        public void Setup()
        {
            motorVehicle = new FakeMotorVehicle(new SpoofPerson("faker"), 100, 50, 2);
        }

        [Test]
        public void Constructor()
        {
            Assert.AreEqual(100, motorVehicle.maxFuel);
            Assert.AreEqual(50, motorVehicle.currentFuel);
            Assert.AreEqual(2, motorVehicle.litresPerKM);
        }

        [Test]
        public void GetRemainingFuel()
        {
            Assert.AreEqual(50, motorVehicle.getFuelRemaining());
        }

        [Test]
        public void RefuelWithRoom()
        {
            motorVehicle.refuel(50);
            Assert.AreEqual(100, motorVehicle.currentFuel);
        }

        [Test]
        public void RefuelWithoutRoom()
        {
            Exception exception = Assert.Throws<Exception>(() => motorVehicle.refuel(51));
            Assert.IsTrue(exception.Message.Contains("cannot hold that much fuel"));
        }

        [Test]
        public void RefuelNegative()
        {
            Exception exception = Assert.Throws<Exception>(() => motorVehicle.refuel(-1));
            Assert.IsTrue(exception.Message.Contains("stealing fuel"));
        }

        [Test]
        public void TravelWithFuel()
        {
            motorVehicle.travel(10);
            Assert.AreEqual(30, motorVehicle.getFuelRemaining());
        }

        [Test]
        public void TravelWithoutFuel()
        {
            Exception exception = Assert.Throws<Exception>(() => motorVehicle.travel(26));
            Assert.IsTrue(exception.Message.Contains("Out of Fuel"));
            Assert.AreEqual(0, motorVehicle.getFuelRemaining());
        }
    }
}
