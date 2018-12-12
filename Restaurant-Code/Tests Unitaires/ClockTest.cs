using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Controleur.Temps;

namespace Tests_Unitaires
{
    [TestClass]
    class ClockTest
    {
        [TestMethod]
        public void Test_ResetMethodSetsTickCountToDefaultValue()
        {
            Clock clock = Clock.Instance;

            clock.Start();
            clock.Reset();

            Assert.AreEqual(0, clock.GetTickCount());
        }

        [TestMethod]
        public void Test_ResetMethodSetsIsStartedToDefaultValue()
        {
            Clock clock = Clock.Instance;

            clock.Start();
            clock.Reset();

            Assert.AreEqual(false, clock.isStarted);
        }

        [TestMethod]
        public void Test_ResetMethodSetsIsRestaurantOpenToDefaultValue()
        {
            Clock clock = Clock.Instance;

            clock.Start();
            clock.Reset();

            Assert.AreEqual(false, clock.isRestaurantOpen);
        }
    }
}
