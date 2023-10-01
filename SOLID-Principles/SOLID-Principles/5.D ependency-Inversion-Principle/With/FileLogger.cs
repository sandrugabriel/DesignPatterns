using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._5.D_ependency_Inversion_Principle.With
{
    public class FileLogger : ILog
    {
        public void Log(string message)
        {
            Console.WriteLine("Inside Log method of FileLogger.");
            LogToFile(message);
        }
        private void LogToFile(string message)
        {
            Console.WriteLine("Method: LogToFile, Text: {0}", message);
        }
    }
}
