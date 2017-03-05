using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Model
{
    public interface IIncidentRepository
    {
        IncidentData GetIncidentById(int incidentId);
        void SaveOrUpdateIncidentTasks(IncidentData incident);
        IList<IncidentTaskData> GetAutodeployTasksForIncidentType(int incidentType);
    }
}
