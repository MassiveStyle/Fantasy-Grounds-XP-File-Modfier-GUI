using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fantasy_Grounds_XP_File_Modfier
{
    internal class Replace
    {
        string fileToModify = Properties.Settings.Default.SourcePakFile.Replace("5E.pak", "Modifying/scripts/manager_ps2.lua");
        string defaultString1 = "nAverageSplit = math.floor((nXP / #aParty) + 0.5);";
        string replaceString1 = "nAverageSplit = nXP;";

        string defaultString2 = "nAverageSplit = 0;";
        string replaceString2 = "nAverageSplit = nXP;";

        string defaultString3 = "nFinalSplit = math.max((nXP - ((#aParty - 1) * nAverageSplit)), 0);";
        string replaceString3 = "nAverageSplit = nXP;";

        private Form1 form1;
        public Replace(Form1 form1)
        {
            this.form1 = form1;
        }

        public void ReplaceString()
        {

            bool snipped1 = File.ReadLines(fileToModify).Any(line => line.Contains(defaultString1));
            bool snipped2 = File.ReadLines(fileToModify).Any(line => line.Contains(defaultString2));
            bool snipped3 = File.ReadLines(fileToModify).Any(line => line.Contains(defaultString3));

            if (snipped1)
            {
                string str = File.ReadAllText(fileToModify);
                str = str.Replace(defaultString1, replaceString1);
                File.WriteAllText(fileToModify, str);
                form1.ReplaceString1ChangeMessage("String 1 replaced!");
                form1.ReplaceString1ColorPass();
            }
            else
            {
                form1.ReplaceString1ChangeMessage("String 1 not found in File");
                form1.ReplaceString1ColorFail();
            }

            if (snipped2)
            {
                string str = File.ReadAllText(fileToModify);
                str = str.Replace(defaultString2, replaceString2);
                File.WriteAllText(fileToModify, str);
                form1.ReplaceString2ChangeMessage("String 2 replaced!");
                form1.ReplaceString2ColorPass();
            }
            else
            {
                form1.ReplaceString2ChangeMessage("String 2 not found in File");
                form1.ReplaceString2ColorFail();
            }

            if (snipped3)
            {
                string str = File.ReadAllText(fileToModify);
                str = str.Replace(defaultString3, replaceString3);
                File.WriteAllText(fileToModify, str);
                form1.ReplaceString3ChangeMessage("String 3 replaced!");
                form1.ReplaceString3ColorPass();
            }
            else
            {
                form1.ReplaceString3ChangeMessage("String 3 not found in File");
                form1.ReplaceString3ColorFail();
            }

        }
    }
}
