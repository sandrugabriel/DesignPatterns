using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Builder_Pattern.Ex1
{
    interface IBicycleBuilder
    {
        public void Reset();
        public void BuildFrame();
        public void BuildHandleBars();
        public void BuildSeat();
        public void BuildSuspension();
        public void BuildDriveTrain();
        public void BuildBrakes();
        IBicycleProduct GetProduct();
    }

}
