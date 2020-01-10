using System;

namespace Kabab.ClassSchedule.Domain
{
    [Serializable]
    public class ScheduleEvent
    {
        public ScheduleEventType EventType { get; set; }

        public DateTime StartTime { get; set; }

        public TimeSpan Duration { get; set; }

        public ScheduleEvent() { }

        public ScheduleEvent(ScheduleEventType eventType, DateTime startTime, TimeSpan duration)
        {
            this.EventType = eventType;
            this.StartTime = startTime;
            this.Duration = duration;
        }
    }
}
