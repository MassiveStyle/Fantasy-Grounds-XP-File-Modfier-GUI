using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Grounds_XP_File_Modfier
{
    internal class ExtractFromZip
    {
        private Form1 form1;
        public ExtractFromZip(Form1 form1)
        {
            this.form1 = form1;
        }

        string zipFile = Properties.Settings.Default.SourcePakFile.Replace(".pak", ".zip");
        string directoryDestination = Properties.Settings.Default.SourcePakFile.Replace("5E.pak", "Modifying");

        public void ExtractFileAndDeleteSource()
        {
            if (File.Exists(zipFile))
            {
                ZipFile.ExtractToDirectory(zipFile, directoryDestination);
                form1.ExtractZipChangeColorPass();
                form1.ExtraxtZipChangeMessage("Files successfully extracted");
            }
            else
            {
                form1.ExtractChangeColorFail();
                form1.ExtraxtZipChangeMessage("The Zip file doesnt exist");
            }
            File.Delete(zipFile);
        }
    }
}
