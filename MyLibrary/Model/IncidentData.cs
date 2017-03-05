using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Model
{
    public class IncidentData
    {
        public int Id { get; set; }
        public DateTime LastActivityTime { get; set; }
        public bool IsEscalated { get; set; }
        public bool IsClosed { get; set; }
        public List<IncidentTaskData> Tasks { get; set; }
        public int IncidentTypeId { get; set; }
    }
}
