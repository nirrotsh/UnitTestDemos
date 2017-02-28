using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Model
{
    public interface IPublisher
    {
        void Publish(INotificationData notificationdata);
    }
}
