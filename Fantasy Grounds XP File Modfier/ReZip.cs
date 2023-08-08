using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Grounds_XP_File_Modfier
{
    internal class ReZip
    {
        private Form1 form1;

        public ReZip(Form1 form1)
        {
            this.form1 = form1;
        }

        public string newZipFilePath = Properties.Settings.Default.SourcePakFile.Replace(".pak", ".zip");
        public string directoryDestination = Properties.Settings.Default.SourcePakFile.Replace("5E.pak", "Modifying");


        public void ZipFiles()
        {
            ZipFile.CreateFromDirectory(directoryDestination, newZipFilePath);
            form1.ReZipChangeMessage("Files successfuly packed");
            form1.ReZipColorPass();
        }
    }
}
