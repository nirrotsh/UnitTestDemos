using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MyLibrary.Model;
using MyLibrary;
using NSubstitute;

namespace MyLibraryTests
{
    [TestClass]
    public class ThirdStep_MockTests
    {
        [TestMethod]
        public void ShouldSendNotificationOnClosingOpenIncident()
        {
            var publisherMock = Substitute.For<IPublisher>();   //This is the mock
            var subj = new SecondStep_Stubs(publisherMock);
            var incident = new IncidentData
            {
                IsClosed = false
            };

            //Test
            subj.CloseIncident(incident);

            //Assert
            Assert.IsTrue(incident.IsClosed, "Incident Should be closed");
            publisherMock.Received(1).Publish(Arg.Any<INotificationData>());
        }
    }
}
