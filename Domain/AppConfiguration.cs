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
