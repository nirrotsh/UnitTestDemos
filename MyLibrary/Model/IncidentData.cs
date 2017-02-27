using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary.Model
{
    public class IncidentData
    {
        public DateTime LastActivityTime { get; set; }
        public bool IsEscalated { get; set; }
    }
}
