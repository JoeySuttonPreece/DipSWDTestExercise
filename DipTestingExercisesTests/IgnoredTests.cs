using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace DipTestingExercisesTests
{
    class IgnoredTests
    {
        [Test]
        [Ignore("Ignore this one")]
        public void Test_To_Ignore()
        {
            throw new NotImplementedException();
        }
    }
}
