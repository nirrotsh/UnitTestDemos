using MyLibrary.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLibrary
{
    public class FirstUnitTestDemo
    {
        public void EscalateIncidentIfRequired(IncidentData incident)
        {
            var escalationPoint = DateTime.Now.AddMinutes(-30);

            incident.IsEscalated = incident.LastActivityTime < escalationPoint;
        }
    }
}
