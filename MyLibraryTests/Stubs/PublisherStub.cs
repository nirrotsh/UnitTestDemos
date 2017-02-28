using MyLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryTests.Stubs
{
    class PublisherStub : IPublisher
    {
        public void Publish(INotificationData notificationdata)
        {
            if (notificationdata == null)
                throw new ArgumentNullException("Notification cannot be null");
            return;
        }
    }
}
