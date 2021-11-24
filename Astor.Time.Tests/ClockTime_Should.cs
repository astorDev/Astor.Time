
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Astor.Time.Tests
{
    [TestClass]
    public class ClockTime_Should
    {
        [TestMethod]
        public void ReturnKindaCurrentTime_WhenJustStarted()
        {
            Assert.AreEqual(DateTime.Now.ToString(), Clock.Time.ToString());
        }

        [TestMethod]
        public void ReturnSetTime_WhenItWasSet()
        {
            Clock.Time = new DateTime(2020, 1, 12);
            
            Assert.AreEqual(new DateTime(2020, 1, 12), Clock.Time);
        }

        [TestMethod]
        public void ReturnKindaCurrentTime_AfterReset()
        {
            Clock.Time = new DateTime(2020, 1, 2);
            Clock.Reset();
            
            Assert.AreEqual(DateTime.Now.ToString(), Clock.Time.ToString());
        }
    }
}