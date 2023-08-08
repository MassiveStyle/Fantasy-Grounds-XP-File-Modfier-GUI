using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Grounds_XP_File_Modfier
{
    internal class RenameFromPakToZip
    {
        private Form1 form1;
        public RenameFromPakToZip(Form1 form1)
        {
            this.form1 = form1;
        }
        public void PakToZip()
        {
            string sourceFile = Properties.Settings.Default.SourcePakFile;
            string outputFile = Properties.Settings.Default.SourcePakFile.Replace(".pak", ".zip");


            System.IO.FileInfo fi = new System.IO.FileInfo(sourceFile);

            if (fi.Exists)
            {
                fi.MoveTo(outputFile);
                form1.RenamePakChangeMessage("File Renamed");
                form1.RenamePakChangeColorPass();
            }
            else
            {
                form1.RenamePakChangeMessage("File Doesnt Exists");
                form1.RenamePakChangeColorFail();
            }
        }
    }
}
