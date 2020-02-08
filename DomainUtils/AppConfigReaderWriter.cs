using Kabab.ClassSchedule.Domain;
using System;
using System.IO;
using System.Xml.Serialization;

namespace DomainUtils
{
    /// <summary>
    /// Application configutation reader-writer.
    /// </summary>
    public static class AppConfigReaderWriter
    {
        /// <summary>
        /// Default file name for store application configuration.
        /// </summary>
        private const string defaultFileName = "AppConfiguration.cfg";

        /// <summary>
        /// Reading configuration from file.
        /// </summary>
        /// <returns></returns>
        public static AppConfiguration Read()
        {
            var deserializer = new XmlSerializer(typeof(AppConfiguration));
            AppConfiguration appConfig;

            using (var sr = new StreamReader(new FileStream(defaultFileName, FileMode.Open)))
            {
                appConfig = (AppConfiguration)deserializer.Deserialize(sr);
            }

            return appConfig;
        }

        /// <summary>
        /// Writing configuration to file.
        /// </summary>
        /// <param name="config"></param>
        public static void Write(AppConfiguration config)
        {
            var serializer = new XmlSerializer(typeof(AppConfiguration));

            using (var sw = new StreamWriter(new FileStream(defaultFileName, FileMode.CreateNew)))
            {
                serializer.Serialize(sw, config);
            }
        }
    }
}
