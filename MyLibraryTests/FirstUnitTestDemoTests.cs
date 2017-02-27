using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;
using MyLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Tests
{
    [TestClass]
    public class FirstUnitTestDemoTests
    {
        [TestMethod]
        public void ShouldEscalateAnUntouchedIncident()
        {
            //Prepare
            IncidentData i = new IncidentData
            {
                LastActivityTime = DateTime.Now.AddDays(-4),
                IsEscalated = false
            };
            var ctl = new FirstUnitTestDemo();

            //Test
            ctl.EscalateIncidentIfRequired(i);

            //Assert
            Assert.IsTrue(i.IsEscalated, "Old incidents should be escalated");
        }

        [TestMethod]
        public void ShouldRemoveEscalationForTouchedIncidents()
        {
            //Prepare
            IncidentData i = new IncidentData
            {
                LastActivityTime = DateTime.Now.AddSeconds(-30),
                IsEscalated = true
            };
            var ctl = new FirstUnitTestDemo();

            //Test
            ctl.EscalateIncidentIfRequired(i);

            //Assert
            Assert.IsFalse(i.IsEscalated, "Incident that was updated should not be escalated");
        }
    }
}