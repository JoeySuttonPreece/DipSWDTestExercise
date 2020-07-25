using System;
using System.Collections.Generic;
using System.Text;
using DipTestingExercises;
using NUnit.Framework;

namespace DipTestingExercisesTests
{
    class PersonTests
    {
        public Person person;

        [SetUp]
        public void Setup()
        {
            person = new FakePerson("Brent", "Beansley", "M");
        }

        [Test]
        public void Constructor()
        {
            Assert.AreEqual("Brent", person.fname);
            Assert.AreEqual("Beansley", person.lname);
        }

        [Test]
        public void GetName()
        {
            Assert.AreEqual("Brent Beansley", person.getName());
        }

        [Test]
        public void GetGender()
        {
            Assert.AreEqual("M", person.getGender());
        }
    }
}
