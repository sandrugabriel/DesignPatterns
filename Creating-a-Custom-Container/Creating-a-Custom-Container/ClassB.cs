using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Creating_a_Custom_Container
{
    public class ClassB : IInterfaceB
    {

        private IInterfaceA _classA;

        public ClassB(IInterfaceA classA)
        {
            _classA = classA;
        }

        public void doB()
        {
            _classA.doA();
            Console.WriteLine("B");
        }
    }
}
