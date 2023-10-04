using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Program;
using The_Builder_Pattern.Ex1;

namespace The_Builder_Pattern.Ex1
{
    public class MountainBikeBuilder : IBicycleBuilder
    {
        private BicycleProduct _bicycle;

        public MountainBikeBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            _bicycle = new BicycleProduct();
        }

        public void BuildFrame()
        {
            _bicycle.Frame = new MountainBikeFrame();
        }

        public void BuildHandleBars()
        {
            _bicycle.Handlebars = new MountainBikeHandlebars();
        }

        public void BuildSeat()
        {
            _bicycle.Seat = new GenericSeat();
        }

        public void BuildSuspension()
        {
            _bicycle.Suspension = new FullSuspension();
        }

        public void BuildDriveTrain()
        {
            _bicycle.Drivetrain = new MountainDrivetrain();
        }

        public void BuildBrakes()
        {
            _bicycle.Brakes = new DiscBrakes();
        }

        public IBicycleProduct GetProduct()
        {
            return _bicycle;
        }
    }

}
