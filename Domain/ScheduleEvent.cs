using System;

namespace Kabab.ClassSchedule.Domain
{
    public class ScheduleEvent
    {
        private ScheduleEventType eventType;

        private DateTime startTime;

        private TimeSpan duration;

        public ScheduleEvent(ScheduleEventType eventType, DateTime startTime, TimeSpan duration)
        {
            this.eventType = eventType;
            this.startTime = startTime;
            this.duration = duration;
        }

        public ScheduleEventType EventType
        {
            get
            {
                return this.eventType;
            }
        }

        public DateTime StartTime
        {
            get
            {
                return this.startTime;
            }
        }

        public TimeSpan Duration
        {
            get
            {
                return this.duration;
            }
        }
    }
}
