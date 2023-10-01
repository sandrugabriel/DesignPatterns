using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._5.D_ependency_Inversion_Principle.WithOut
{
    public class ProductService
    {
        private readonly FileLogger _fileLogger = new FileLogger();
        private readonly DatabaseLogger databaseLogger = new DatabaseLogger();
        public void LogToFile(string message)
        {
            _fileLogger.Log(message);
        }

        public void LogToSateBase(string message)
        {
            databaseLogger.Log(message);
        }
    }
}
