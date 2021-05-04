using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesSolution.Logging
{
    public interface ILogger
    {
        void Information(string message);
        void Warning(string message);
        void Error(string message);
    }
}
