using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._2.O_pen_Closed_Principle.With
{
    public class AreaCalculator
    {
        public double TotalArea(IArea[] arrObjects)
        {
            double area = 0;
            foreach (var obj in arrObjects)
            {
                area += obj.Area();
            }
            return area;
        }

    }
}
