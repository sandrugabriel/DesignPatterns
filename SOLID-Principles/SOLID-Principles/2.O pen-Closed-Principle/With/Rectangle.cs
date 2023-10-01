using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._2.O_pen_Closed_Principle.With
{
    public class Rectangle : IArea
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public double Area()
        {
           return Height*Width;
        }
    }
}
