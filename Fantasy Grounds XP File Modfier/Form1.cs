namespace Fantasy_Grounds_XP_File_Modfier
{
    public partial class Form1 : Form
    {
        public OpenFileDialog openFileDialog1 = new OpenFileDialog();
        bool finish = true;

        public Form1()
        {
            InitializeComponent();
        }

        public void GetSettings()
        {
            openFileDialog1.FileName = Properties.Settings.Default.SourcePakFile;
            filePath.Text = openFileDialog1.FileName;
        }

        public void SaveSettings()
        {
            Properties.Settings.Default.SourcePakFile = openFileDialog1.FileName;
            Properties.Settings.Default.Save();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Properties.Settings.Default.SourcePakFile))
            {
                selectNewFileButton.Visible = true;
            }
            else
            {
                selectNewFileButton.Visible = false;
            }
            GetSettings();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            SaveSettings();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!finish)
            {
                MessageBox.Show("Please wait till all steps are completed");
                e.Cancel = true;
            }
        }

        private void start_Click(object sender, EventArgs e)
        {
            finish = false;

            while (string.IsNullOrEmpty(openFileDialog1.FileName))
            {
                MessageBox.Show("No file selected. Please select the 5E.pak file");
                openFileDialog1.Title = "Select 5E Pak File";
                openFileDialog1.Filter = "Pak File (5E.pak)|5E.pak";
                openFileDialog1.ShowDialog();
                Properties.Settings.Default.SourcePakFile = openFileDialog1.FileName;
                filePath.Text = openFileDialog1.FileName;
            }

            renamePakTimer.Start();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (finish)
            {
                SaveSettings();
                Environment.Exit(0);
            }
            else
            {
                MessageBox.Show("Please wait till all steps are completed");
            }

        }


        private void selectNewFileButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = string.Empty;
            openFileDialog1.Title = "Select 5E Pak File";
            openFileDialog1.Filter = "Pak File (5E.pak)|5E.pak";
            openFileDialog1.ShowDialog();
            Properties.Settings.Default.SourcePakFile = openFileDialog1.FileName;
            filePath.Text = openFileDialog1.FileName;
        }

        private void renamePak_Tick(object sender, EventArgs e)
        {
            renamePakProgressBar.Increment(7);
            if (renamePakProgressBar.Value >= renamePakProgressBar.Maximum)
            {
                renamePakTimer.Stop();
                RenameFromPakToZip renameFromPakToZip = new RenameFromPakToZip(this);
                renameFromPakToZip.PakToZip();
                extractZipTimer.Start();
            }
        }


        private void extractZipTimer_Tick(object sender, EventArgs e)
        {
            extractZipProgressbar.Increment(7);
            if (extractZipProgressbar.Value >= extractZipProgressbar.Maximum)
            {
                extractZipTimer.Stop();
                ExtractFromZip extractFromZip = new ExtractFromZip(this);
                extractFromZip.ExtractFileAndDeleteSource();
                replaceString1Timer.Start();
            }
        }

        private void replaceString1Timer_Tick(object sender, EventArgs e)
        {
            replaceString1Progressbar.Increment(7);
            if (replaceString1Progressbar.Value >= replaceString1Progressbar.Maximum)
            {
                replaceString1Timer.Stop();
                replaceString2Timer.Start();
            }
        }

        private void replaceString2Timer_Tick(object sender, EventArgs e)
        {
            replaceString2Progressbar.Increment(7);
            if (replaceString2Progressbar.Value >= replaceString2Progressbar.Maximum)
            {
                replaceString2Timer.Stop();
                replaceString3Timer.Start();
            }
        }

        private void replaceString3Timer_Tick(object sender, EventArgs e)
        {
            replaceString3Progressbar.Increment(7);
            if (replaceString3Progressbar.Value >= replaceString3Progressbar.Maximum)
            {
                replaceString3Timer.Stop();
                Replace replace = new Replace(this);
                replace.ReplaceString();
                reZipTimer.Start();
            }
        }

        private void reZipTimer_Tick(object sender, EventArgs e)
        {
            reZipProgressbar.Increment(7);
            {
                if (reZipProgressbar.Value >= reZipProgressbar.Maximum)
                {
                    reZipTimer.Stop();
                    ReZip reZip = new ReZip(this);
                    reZip.ZipFiles();
                    renamingZipTimer.Start();
                }
            }
        }

        private void renamingZipTimer_Tick(object sender, EventArgs e)
        {
            renamingZipProgressbar.Increment(7);
            if (renamingZipProgressbar.Value >= renamingZipProgressbar.Maximum)
            {
                renamingZipTimer.Stop();
                RenameFromZipToPak renameFromZipToPak = new RenameFromZipToPak(this);
                renameFromZipToPak.ZipToPak();
                cleaningUpTimer.Start();
            }
        }

        private void cleaningUpTimer_Tick(object sender, EventArgs e)
        {
            cleaningUpProgressbar.Increment(7);
            if (cleaningUpProgressbar.Value >= cleaningUpProgressbar.Maximum)
            {
                cleaningUpTimer.Stop();
                CleanUp cleanUp = new CleanUp(this);
                cleanUp.DelTrash();
                finish = true;
            }
        }
        public void RenamePakChangeMessage(string message)
        {
            renamePakResult.Text = message;
        }

        public void ExtraxtZipChangeMessage(string message)
        {
            extractZipResult.Text = message;
        }

        public void ReplaceString1ChangeMessage(string message)
        {
            replaceString1Result.Text = message;
        }

        public void ReplaceString2ChangeMessage(string message)
        {
            replaceString2Result.Text = message;
        }

        public void ReplaceString3ChangeMessage(string message)
        {
            replaceString3Result.Text = message;
        }

        public void ReZipChangeMessage(string message)
        {
            reZipResult.Text = message;
        }
        public void RenamingZipChangeMessage(string message)
        {
            renamingZipResult.Text = message;
        }

        public void CleaningUpChangeMessage(string message)
        {
            cleaningUpResult.Text = message;
        }


        public void RenamePakChangeColorPass()
        {
            renamePakResult.BackColor = Color.LimeGreen;
            renamePakResult.ForeColor = Color.Black;
        }

        public void RenamePakChangeColorFail()
        {
            renamePakResult.BackColor = Color.Red;
            renamePakResult.ForeColor = Color.Black;
        }

        public void ExtractZipChangeColorPass()
        {
            extractZipResult.BackColor = Color.LimeGreen;
            extractZipResult.ForeColor = Color.Black;
        }


        public void ExtractChangeColorFail()
        {
            extractZipResult.BackColor = Color.Red;
            extractZipResult.ForeColor = Color.Black;
        }

        public void ReplaceString1ColorPass()
        {
            replaceString1Result.BackColor = Color.LimeGreen;
            replaceString1Result.ForeColor = Color.Black;
        }


        public void ReplaceString1ColorFail()
        {
            replaceString1Result.BackColor = Color.Red;
            replaceString1Result.ForeColor = Color.Black;
        }

        public void ReplaceString2ColorPass()
        {
            replaceString2Result.BackColor = Color.LimeGreen;
            replaceString2Result.ForeColor = Color.Black;
        }


        public void ReplaceString2ColorFail()
        {
            replaceString2Result.BackColor = Color.Red;
            replaceString2Result.ForeColor = Color.Black;
        }

        public void ReplaceString3ColorPass()
        {
            replaceString3Result.BackColor = Color.LimeGreen;
            replaceString3Result.ForeColor = Color.Black;
        }


        public void ReplaceString3ColorFail()
        {
            replaceString3Result.BackColor = Color.Red;
            replaceString3Result.ForeColor = Color.Black;
        }

        public void ReZipColorPass()
        {
            reZipResult.BackColor = Color.LimeGreen;
            reZipResult.ForeColor = Color.Black;
        }


        public void ReZipColorFail()
        {
            reZipResult.BackColor = Color.Red;
            reZipResult.ForeColor = Color.Black;
        }

        public void RenamingZipColorPass()
        {
            renamingZipResult.BackColor = Color.LimeGreen;
            renamingZipResult.ForeColor = Color.Black;
        }


        public void RenamingZipColorFail()
        {
            renamingZipResult.BackColor = Color.Red;
            renamingZipResult.ForeColor = Color.Black;
        }

        public void CleaningUpColorPass()
        {
            cleaningUpResult.BackColor = Color.LimeGreen;
            cleaningUpResult.ForeColor = Color.Black;
        }


        public void CleaningUpColorFail()
        {
            cleaningUpResult.BackColor = Color.Red;
            cleaningUpResult.ForeColor = Color.Black;
        }
    }
}