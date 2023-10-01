using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._2.O_pen_Closed_Principle.With
{
    public class Circle : IArea
    {
        public double Radius { get; set; }

        public double Area()
        {
            return Radius*Radius*Math.PI;
        }
    }
}
