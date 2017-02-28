using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary;
using MyLibrary.Model;
using MyLibraryTests.Stubs;

namespace MyLibraryTests
{
    [TestClass]
    public class SecondStep_StubsTests
    {
        [TestMethod]
        public void ShouldBeAbletoCloseIncident()
        {
            //Preparing
            IPublisher publisherStub = new PublisherStub();
            var subj = new SecondStep_Stubs(publisherStub);
            var incident = new IncidentData
            {
                IsClosed = false
            };

            //Test
            subj.CloseIncident(incident);

            //Assert
            Assert.IsTrue(incident.IsClosed, "Incident Should be closed");
        }
    }
}
