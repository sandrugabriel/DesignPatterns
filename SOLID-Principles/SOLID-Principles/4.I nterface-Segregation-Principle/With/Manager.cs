﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._4.I_nterface_Segregation_Principle.With
{
    class Manager : IAssgin,ICreate
    {
        public void AssginTask()
        {
            //Code to assign a task.
        }

        public void CreateTask()
        {
            //Code to create a task.  
        }
    }
}
