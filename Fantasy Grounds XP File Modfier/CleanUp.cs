using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Grounds_XP_File_Modfier
{
    internal class CleanUp
    {
        private Form1 form1;
        public CleanUp(Form1 form1)
        {
            this.form1 = form1;
        }

        public void DelTrash()
        {
            Directory.Delete(Properties.Settings.Default.SourcePakFile.Replace("5E.pak", "Modifying"), true);
            form1.CleaningUpChangeMessage("Trash has been cleaned Up!");
            form1.CleaningUpColorPass();
        }
    }
}
