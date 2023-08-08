using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Grounds_XP_File_Modfier
{
    internal class RenameFromZipToPak
    {
        string renameToPakFile = Properties.Settings.Default.SourcePakFile;
        string newZipFilePath = Properties.Settings.Default.SourcePakFile.Replace(".pak", ".zip");
        private Form1 form1;

        public RenameFromZipToPak(Form1 form1)
        {
            this.form1 = form1;
        }

        public void ZipToPak()
        {

            System.IO.FileInfo fi = new System.IO.FileInfo(newZipFilePath);

            if (fi.Exists)
            {
                fi.MoveTo(renameToPakFile);
                form1.RenamingZipChangeMessage("File successfuly Renamed!");
                form1.RenamingZipColorPass();
            }
            else
            {
                form1.RenamingZipChangeMessage("File doesnt Exists");
                form1.RenamingZipColorFail();
            }

        }
    }
}
