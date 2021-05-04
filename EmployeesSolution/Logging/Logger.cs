using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace EmployeesSolution.Logging
{
    public class Logger : ILogger
    {
        public void Information(string message)
        {
            Trace.TraceInformation(message);
        }

        public void Warning(string message)
        {
            Trace.TraceWarning(message);
        }
        public void Error(string message)
        {
            Trace.TraceError(message);
        }
    }
}