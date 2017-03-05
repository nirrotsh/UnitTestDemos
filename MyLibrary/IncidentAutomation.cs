using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyLibrary.Model;

namespace MyLibrary
{    public class IncidentAutomation
    {
        private IPublisher publisher;
        private IIncidentRepository repo;

        public IncidentAutomation(IIncidentRepository repo, IPublisher publisher)
        {
            this.publisher = publisher;
            this.repo = repo;
        }

        public void DeployAutoTasksForIncident(int incidentId)
        {
            var incident = repo.GetIncidentById(incidentId);
            incident.Tasks = new List<IncidentTaskData>(repo.GetAutodeployTasksForIncidentType(incident.IncidentTypeId));
            repo.SaveOrUpdateIncidentTasks(incident);
            publisher.Publish(new IncidentNotification());
        }
    }
}
