using SOLID_Principles._3.L_iskov_Subtitution_Principle.WithOut;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Principles._3.L_iskov_Subtitution_Principle.With
{
    public class FileManager
    {
        public List<ILoad> allFiles { get; set; }

        public List<IWrite> writeFiles { get; set; }

        public string GetTextFromFiles()
        {
            StringBuilder objStrBuilder = new StringBuilder();
            foreach (var objFile in allFiles)
            {
                objStrBuilder.Append(objFile.LoadText());
            }
            return objStrBuilder.ToString();
        }
        public void SaveTextIntoFiles()
        {
            foreach (var objFile in writeFiles)
            {
                    objFile.SaveText();
            }
        }
    }
}
