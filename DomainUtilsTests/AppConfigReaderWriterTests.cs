using Kabab.ClassSchedule.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DomainUtilsTests
{
    [TestClass]
    public class AppConfigReaderWriterTests
    {
        private AppConfiguration appConfig;

        [TestInitialize]
        public void InitTest()
        {
            appConfig = new AppConfiguration();
        }

        [TestMethod]
        public void TestReadConfiguration()
        {
        }

        [TestMethod]
        public void TestWriteConfiguration()
        {
        }
    }
}
