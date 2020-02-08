using Kabab.ClassSchedule.Domain;
using Kabab.ClassSchedule.DomainUtils;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Kabab.ClassSchedule.DomainUtilsTests
{
    [TestClass]
    public class AppConfigReaderWriterTests
    {
        private AppConfiguration appConfig;

        [TestInitialize]
        public void InitTest()
        {
            appConfig = new AppConfiguration();

            appConfig.ComPortName = "COM7";
            appConfig.WebServicePortNumber = 8088;

            var now = DateTime.Now;

            appConfig.EventList.Add(
                new ScheduleEvent(
                    ScheduleEventType.Lesson, 
                    new DateTime(now.Year, now.Month, now.Day, 8, 30, 0), TimeSpan.FromMinutes(45)));

            appConfig.EventList.Add(
                new ScheduleEvent(
                    ScheduleEventType.Break,
                    new DateTime(now.Year, now.Month, now.Day, 9, 15, 0), TimeSpan.FromMinutes(10)));

            appConfig.EventList.Add(
                new ScheduleEvent(
                    ScheduleEventType.Lesson,
                    new DateTime(now.Year, now.Month, now.Day, 9, 25, 0), TimeSpan.FromMinutes(45)));

            appConfig.EventList.Add(
                new ScheduleEvent(
                    ScheduleEventType.Break,
                    new DateTime(now.Year, now.Month, now.Day, 10, 10, 0), TimeSpan.FromMinutes(10)));

            appConfig.EventList.Add(
                new ScheduleEvent(
                    ScheduleEventType.Lesson,
                    new DateTime(now.Year, now.Month, now.Day, 10, 20, 0), TimeSpan.FromMinutes(45)));
        }

        [TestMethod]
        public void TestReadConfiguration()
        {
            AppConfigReaderWriter.Write(appConfig);

            var config = AppConfigReaderWriter.Read();
        }

        [TestMethod]
        public void TestWriteConfiguration()
        {
        }
    }
}
