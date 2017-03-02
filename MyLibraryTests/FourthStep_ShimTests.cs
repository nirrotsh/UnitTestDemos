using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NSubstitute;
using MyLibrary;
using MyLibrary.Model;

namespace MyLibraryTests
{
    [TestClass]
    public class FourthStep_ShimTests
    {
        [TestMethod]
        public void ShouldSetDateTimeCorrectlyOnCloseIncident()
        {
            var publisherMock = Substitute.For<IPublisher>();   //This is the mock
            var subj = new SecondStep_Stubs(publisherMock);

            //Shimming
            var expectedTime = new DateTime(2017, 2, 26, 11, 30, 00);
            System.Prig.PDateTime.NowGet().Body = () => expectedTime; 
            var test = DateTime.Now;

            var incident = new IncidentData
            {
                IsClosed = false
            };

            subj.CloseIncident(incident);

            //Assert
            Assert.AreEqual(expectedTime, incident.LastActivityTime);
        }
    }
}
