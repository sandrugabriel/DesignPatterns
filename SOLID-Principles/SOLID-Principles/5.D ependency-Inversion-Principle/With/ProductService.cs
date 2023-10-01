using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._5.D_ependency_Inversion_Principle.With
{
    public class ProductService
    {
        private readonly ILog _log;

        public ProductService(ILog log)
        {
            _log = log;
        }

        public void Log(string message)
        {
            _log.Log(message);
        }
    }
}
