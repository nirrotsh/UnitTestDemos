using Machine.Specifications;
using MyLibrary;
using MyLibrary.Model;
using NSubstitute;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibraryTests
{ 
    [Subject(typeof(IncidentAutomation))]
    public class When_deploying_auto_tasks
    {
        static IncidentData incident;
        static IncidentAutomation automationSvc;
        static IPublisher publisher;
        static IIncidentRepository repo;
        static List<IncidentTaskData> deployedTasks;

        Establish context = () =>
        {
            incident = new IncidentData
            {
                Id = 11,
                Tasks = new List<IncidentTaskData>(),
                IncidentTypeId = 4
            };
            deployedTasks = new List<IncidentTaskData>{
                    new IncidentTaskData(),
                    new IncidentTaskData(),
                    new IncidentTaskData()
                };
            repo = Substitute.For<IIncidentRepository>();
            repo.GetAutodeployTasksForIncidentType(incident.IncidentTypeId)
                .Returns(deployedTasks);
            repo.GetIncidentById(incident.Id)
                .Returns(incident);
            publisher = Substitute.For<IPublisher>();
            automationSvc = new IncidentAutomation(repo, publisher);
        };

        Because of = () => automationSvc.DeployAutoTasksForIncident(incident.Id);

        It Should_add_autoDeployed_tasks_to_incident = () => incident.Tasks.Count.ShouldEqual(deployedTasks.Count);
        It Should_send_tasksAdded_Notification = () => publisher.Received(1).Publish(Arg.Any<INotificationData>());
        It Should_update_incident_in_db = () => repo.Received(1).SaveOrUpdateIncidentTasks(incident);
    }
}
