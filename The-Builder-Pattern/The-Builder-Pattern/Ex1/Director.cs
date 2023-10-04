using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace The_Builder_Pattern.Ex1
{
    public class Director
    {
        private IBicycleBuilder Builder { get; set; }

        public Director(IBicycleBuilder builder)
        {
            Builder = builder;
        }

        public void ChangeBuilder(IBicycleBuilder builder)
        {
            Builder = builder;
        }

        public IBicycleProduct Make()
        {
            Builder.BuildFrame();
            Builder.BuildHandleBars();
            Builder.BuildSeat();
            Builder.BuildSuspension();
            Builder.BuildDriveTrain();
            Builder.BuildBrakes();

            return Builder.GetProduct();
        }
    }

}
