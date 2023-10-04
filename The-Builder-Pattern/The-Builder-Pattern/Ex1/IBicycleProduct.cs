using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_Builder_Pattern.Ex1;
using static Program;

namespace The_Builder_Pattern.Ex1
{
     interface IBicycleProduct
    {
        public IFrame Frame { get; set; }
        public ISuspension Suspension { get; set; }
        public IHandlebars Handlebars { get; set; }
        public IDrivetrain Drivetrain { get; set; }
        public ISeat Seat { get; set; }
        public IBrakes Brakes { get; set; }
    }
}
