using System;
using System.Collections.Generic;

namespace Kabab.ClassSchedule.Domain
{
    /// <summary>
    /// Application configuration.
    /// </summary>
    [Serializable]
    public class AppConfiguration
    {
        public AppConfiguration()
        {
            this.EventList = new List<ScheduleEvent>();
        }

        /// <summary>
        /// Event collection.
        /// </summary>
        public List<ScheduleEvent> EventList { get; set; }

        /// <summary>
        /// Web-service port number.
        /// </summary>
        public int WebServicePortNumber { get; set; }

        /// <summary>
        /// Used COM-port.
        /// </summary>
        public string ComPortName { get; set; }
    }
}
