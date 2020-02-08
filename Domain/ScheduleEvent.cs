using System;

namespace Kabab.ClassSchedule.Domain
{
    /// <summary>
    /// Schedule event class.
    /// </summary>
    [Serializable]
    public class ScheduleEvent
    {
        /// <summary>
        /// Type of event.
        /// </summary>
        public ScheduleEventType EventType { get; set; }

        /// <summary>
        /// Start event time.
        /// </summary>
        public DateTime StartTime { get; set; }

        /// <summary>
        /// Event duration.
        /// </summary>
        public TimeSpan Duration { get; set; }
        
        /// <summary>
        /// Common ctor.
        /// </summary>
        public ScheduleEvent() { }

        /// <summary>
        /// Additional ctor.
        /// </summary>
        /// <param name="eventType">Tipe of event.</param>
        /// <param name="startTime">Start event time.</param>
        /// <param name="duration">Event duration.</param>
        public ScheduleEvent(ScheduleEventType eventType, DateTime startTime, TimeSpan duration)
        {
            this.EventType = eventType;
            this.StartTime = startTime;
            this.Duration = duration;
        }

        /// <summary>
        /// Object as string.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "ScheduleEvent[" +
                "EventType: " + EventType +
                "; StartTime: " + StartTime.ToString("hh:mm:ss") +
                "; Duration: " + Duration.ToString("hh:mm:ss") + "]";
        }
    }
}
