using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._3.L_iskov_Subtitution_Principle.WithOut
{
    public class ReadOnlyFile : File
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }
        public string LoadText()
        {
            return "Read only file";
        }
        public void SaveText()
        {
            Console.WriteLine("Can't Save");
        }
    }
}
