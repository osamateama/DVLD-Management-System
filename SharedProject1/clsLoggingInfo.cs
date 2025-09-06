using System.Diagnostics;

namespace BusinessLayer
{
    public class clsLoggingErrorInfo
    {

        public static void LoggingError(string Errormessage)
        {
            string sourceName = "DVLDApp";

            if(!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");
            }
            EventLog.WriteEntry(sourceName, Errormessage , EventLogEntryType.Error);

        }
    }
}
