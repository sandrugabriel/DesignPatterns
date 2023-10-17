using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_a_Custom_Container
{
    public  class ClassA : IInterfaceA
    {
       public void doA()
        {
            Console.WriteLine("A");
        }
    }
}
