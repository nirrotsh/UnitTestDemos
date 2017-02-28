using MyLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    internal class SecondStep_Stubs
    {
        private IPublisher _publisher;

        public SecondStep_Stubs(IPublisher publisher)
        {
            _publisher = publisher;
        }

        internal void CloseIncident(IncidentData incident)
        {
            if (!incident.IsClosed)
            {
                incident.IsClosed = true;
                incident.LastActivityTime = DateTime.Now;
                _publisher.Publish(new IncidentNotification());
            }
        }
    }
}
