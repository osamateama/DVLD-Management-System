using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace BusinessLayer
{
    public class clsLoggingErrorInfo
    {

        public static void LoggingError()
        {
            string sourceName = "DVLDApp";

            if(!EventLog.SourceExists(sourceName))
            {
                EventLog.CreateEventSource(sourceName, "Application");
            }
            EventLog.WriteEntry(sourceName, "This is an Error event.", EventLogEntryType.Error);

        }
    }
}
