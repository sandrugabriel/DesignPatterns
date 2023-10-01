using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._4.I_nterface_Segregation_Principle.WithOut
{
    public class Developer
    {
        public void AssginTask()
        {
            Console.WriteLine("Developer can't Assign Task");
        }

        public void CreateTask()
        {
            Console.WriteLine("Developer can't Create Task");
        }

        public void WorkOnTask()
        {
            /* Code to work on a task*/
        }
    }
}
