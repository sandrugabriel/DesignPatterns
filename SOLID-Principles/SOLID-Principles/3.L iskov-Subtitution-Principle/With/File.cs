using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._3.L_iskov_Subtitution_Principle.With
{
    public class File : ILoad, IWrite
    {

        public string LoadText()
        {
            /* Code to read text from file */
            return string.Empty;
        }
        public void SaveText()
        {
            /* Code to save text into file */
        }

    }
}
