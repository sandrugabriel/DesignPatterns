using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._4.I_nterface_Segregation_Principle.With
{
    public interface IAssgin
    {
        void AssginTask();
    }

    public interface ICreate
    {
        void CreateTask();
    }

    public interface IWork
    {
        void WorkOnTask();

    }

}
