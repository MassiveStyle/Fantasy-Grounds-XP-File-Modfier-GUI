namespace Fantasy_Grounds_XP_File_Modfier
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label1 = new Label();
            label2 = new Label();
            button1 = new Button();
            renamePakProgressBar = new ProgressBar();
            renamePakTimer = new System.Windows.Forms.Timer(components);
            extractZipProgressbar = new ProgressBar();
            extractZipTimer = new System.Windows.Forms.Timer(components);
            renamePakResult = new Label();
            extractZipResult = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            replaceString1Progressbar = new ProgressBar();
            replaceString2Progressbar = new ProgressBar();
            replaceString3Progressbar = new ProgressBar();
            replaceString1Result = new Label();
            replaceString2Result = new Label();
            replaceString3Result = new Label();
            replaceString1Timer = new System.Windows.Forms.Timer(components);
            replaceString2Timer = new System.Windows.Forms.Timer(components);
            replaceString3Timer = new System.Windows.Forms.Timer(components);
            label6 = new Label();
            reZipProgressbar = new ProgressBar();
            reZipResult = new Label();
            reZipTimer = new System.Windows.Forms.Timer(components);
            label7 = new Label();
            renamingZipProgressbar = new ProgressBar();
            renamingZipResult = new Label();
            renamingZipTimer = new System.Windows.Forms.Timer(components);
            label8 = new Label();
            cleaningUpProgressbar = new ProgressBar();
            cleaningUpResult = new Label();
            cleaningUpTimer = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            folderBrowserDialog1 = new FolderBrowserDialog();
            filePath = new Label();
            selectNewFileButton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(14, 10);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(203, 31);
            label1.TabIndex = 0;
            label1.Text = "Renaming Pak";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(14, 73);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(234, 31);
            label2.TabIndex = 1;
            label2.Text = "Unziping Archive";
            // 
            // button1
            // 
            button1.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.MenuText;
            button1.Location = new Point(21, 660);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(164, 62);
            button1.TabIndex = 8;
            button1.Text = "Start";
            button1.UseVisualStyleBackColor = true;
            button1.Click += start_Click;
            // 
            // renamePakProgressBar
            // 
            renamePakProgressBar.Location = new Point(569, 10);
            renamePakProgressBar.Margin = new Padding(4, 3, 4, 3);
            renamePakProgressBar.Name = "renamePakProgressBar";
            renamePakProgressBar.Size = new Size(226, 32);
            renamePakProgressBar.TabIndex = 9;
            // 
            // renamePakTimer
            // 
            renamePakTimer.Tick += renamePak_Tick;
            // 
            // extractZipProgressbar
            // 
            extractZipProgressbar.Location = new Point(569, 76);
            extractZipProgressbar.Margin = new Padding(4, 3, 4, 3);
            extractZipProgressbar.Name = "extractZipProgressbar";
            extractZipProgressbar.Size = new Size(226, 32);
            extractZipProgressbar.TabIndex = 11;
            // 
            // extractZipTimer
            // 
            extractZipTimer.Tick += extractZipTimer_Tick;
            // 
            // renamePakResult
            // 
            renamePakResult.AutoSize = true;
            renamePakResult.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            renamePakResult.ForeColor = SystemColors.ButtonFace;
            renamePakResult.Location = new Point(877, 10);
            renamePakResult.Margin = new Padding(4, 0, 4, 0);
            renamePakResult.Name = "renamePakResult";
            renamePakResult.Size = new Size(202, 31);
            renamePakResult.TabIndex = 18;
            renamePakResult.Text = "-- PENDING --";
            // 
            // extractZipResult
            // 
            extractZipResult.AutoSize = true;
            extractZipResult.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            extractZipResult.ForeColor = SystemColors.ButtonFace;
            extractZipResult.Location = new Point(877, 73);
            extractZipResult.Margin = new Padding(4, 0, 4, 0);
            extractZipResult.Name = "extractZipResult";
            extractZipResult.Size = new Size(202, 31);
            extractZipResult.TabIndex = 20;
            extractZipResult.Text = "-- PENDING --";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(14, 140);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(230, 31);
            label3.TabIndex = 21;
            label3.Text = "Replace String 1";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(14, 211);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(230, 31);
            label4.TabIndex = 22;
            label4.Text = "Replace String 2";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(14, 284);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(230, 31);
            label5.TabIndex = 23;
            label5.Text = "Replace String 3";
            // 
            // replaceString1Progressbar
            // 
            replaceString1Progressbar.Location = new Point(569, 143);
            replaceString1Progressbar.Margin = new Padding(4, 3, 4, 3);
            replaceString1Progressbar.Name = "replaceString1Progressbar";
            replaceString1Progressbar.Size = new Size(226, 32);
            replaceString1Progressbar.TabIndex = 24;
            // 
            // replaceString2Progressbar
            // 
            replaceString2Progressbar.Location = new Point(569, 215);
            replaceString2Progressbar.Margin = new Padding(4, 3, 4, 3);
            replaceString2Progressbar.Name = "replaceString2Progressbar";
            replaceString2Progressbar.Size = new Size(226, 32);
            replaceString2Progressbar.TabIndex = 25;
            // 
            // replaceString3Progressbar
            // 
            replaceString3Progressbar.Location = new Point(569, 287);
            replaceString3Progressbar.Margin = new Padding(4, 3, 4, 3);
            replaceString3Progressbar.Name = "replaceString3Progressbar";
            replaceString3Progressbar.Size = new Size(226, 32);
            replaceString3Progressbar.TabIndex = 26;
            // 
            // replaceString1Result
            // 
            replaceString1Result.AutoSize = true;
            replaceString1Result.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            replaceString1Result.ForeColor = SystemColors.ButtonFace;
            replaceString1Result.Location = new Point(877, 140);
            replaceString1Result.Margin = new Padding(4, 0, 4, 0);
            replaceString1Result.Name = "replaceString1Result";
            replaceString1Result.Size = new Size(202, 31);
            replaceString1Result.TabIndex = 27;
            replaceString1Result.Text = "-- PENDING --";
            // 
            // replaceString2Result
            // 
            replaceString2Result.AutoSize = true;
            replaceString2Result.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            replaceString2Result.ForeColor = SystemColors.ButtonFace;
            replaceString2Result.Location = new Point(877, 211);
            replaceString2Result.Margin = new Padding(4, 0, 4, 0);
            replaceString2Result.Name = "replaceString2Result";
            replaceString2Result.Size = new Size(202, 31);
            replaceString2Result.TabIndex = 28;
            replaceString2Result.Text = "-- PENDING --";
            // 
            // replaceString3Result
            // 
            replaceString3Result.AutoSize = true;
            replaceString3Result.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            replaceString3Result.ForeColor = SystemColors.ButtonFace;
            replaceString3Result.Location = new Point(877, 284);
            replaceString3Result.Margin = new Padding(4, 0, 4, 0);
            replaceString3Result.Name = "replaceString3Result";
            replaceString3Result.Size = new Size(202, 31);
            replaceString3Result.TabIndex = 29;
            replaceString3Result.Text = "-- PENDING --";
            // 
            // replaceString1Timer
            // 
            replaceString1Timer.Tick += replaceString1Timer_Tick;
            // 
            // replaceString2Timer
            // 
            replaceString2Timer.Tick += replaceString2Timer_Tick;
            // 
            // replaceString3Timer
            // 
            replaceString3Timer.Tick += replaceString3Timer_Tick;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(14, 355);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(258, 31);
            label6.TabIndex = 30;
            label6.Text = "Repacking Archive";
            // 
            // reZipProgressbar
            // 
            reZipProgressbar.Location = new Point(569, 359);
            reZipProgressbar.Margin = new Padding(4, 3, 4, 3);
            reZipProgressbar.Name = "reZipProgressbar";
            reZipProgressbar.Size = new Size(226, 32);
            reZipProgressbar.TabIndex = 31;
            // 
            // reZipResult
            // 
            reZipResult.AutoSize = true;
            reZipResult.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            reZipResult.ForeColor = SystemColors.ButtonFace;
            reZipResult.Location = new Point(877, 355);
            reZipResult.Margin = new Padding(4, 0, 4, 0);
            reZipResult.Name = "reZipResult";
            reZipResult.Size = new Size(202, 31);
            reZipResult.TabIndex = 32;
            reZipResult.Text = "-- PENDING --";
            // 
            // reZipTimer
            // 
            reZipTimer.Tick += reZipTimer_Tick;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(14, 429);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(194, 31);
            label7.TabIndex = 33;
            label7.Text = "Renaming Zip";
            // 
            // renamingZipProgressbar
            // 
            renamingZipProgressbar.Location = new Point(569, 433);
            renamingZipProgressbar.Margin = new Padding(4, 3, 4, 3);
            renamingZipProgressbar.Name = "renamingZipProgressbar";
            renamingZipProgressbar.Size = new Size(226, 32);
            renamingZipProgressbar.TabIndex = 34;
            // 
            // renamingZipResult
            // 
            renamingZipResult.AutoSize = true;
            renamingZipResult.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            renamingZipResult.ForeColor = SystemColors.ButtonFace;
            renamingZipResult.Location = new Point(877, 429);
            renamingZipResult.Margin = new Padding(4, 0, 4, 0);
            renamingZipResult.Name = "renamingZipResult";
            renamingZipResult.Size = new Size(202, 31);
            renamingZipResult.TabIndex = 35;
            renamingZipResult.Text = "-- PENDING --";
            // 
            // renamingZipTimer
            // 
            renamingZipTimer.Tick += renamingZipTimer_Tick;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(14, 500);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(174, 31);
            label8.TabIndex = 36;
            label8.Text = "Cleaning Up";
            // 
            // cleaningUpProgressbar
            // 
            cleaningUpProgressbar.Location = new Point(569, 503);
            cleaningUpProgressbar.Margin = new Padding(4, 3, 4, 3);
            cleaningUpProgressbar.Name = "cleaningUpProgressbar";
            cleaningUpProgressbar.Size = new Size(226, 32);
            cleaningUpProgressbar.TabIndex = 37;
            // 
            // cleaningUpResult
            // 
            cleaningUpResult.AutoSize = true;
            cleaningUpResult.Font = new Font("Microsoft Sans Serif", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            cleaningUpResult.ForeColor = SystemColors.ButtonFace;
            cleaningUpResult.Location = new Point(877, 500);
            cleaningUpResult.Margin = new Padding(4, 0, 4, 0);
            cleaningUpResult.Name = "cleaningUpResult";
            cleaningUpResult.Size = new Size(202, 31);
            cleaningUpResult.TabIndex = 38;
            cleaningUpResult.Text = "-- PENDING --";
            // 
            // cleaningUpTimer
            // 
            cleaningUpTimer.Tick += cleaningUpTimer_Tick;
            // 
            // button2
            // 
            button2.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.MenuText;
            button2.Location = new Point(192, 660);
            button2.Margin = new Padding(4, 3, 4, 3);
            button2.Name = "button2";
            button2.Size = new Size(164, 62);
            button2.TabIndex = 39;
            button2.Text = "Exit";
            button2.UseVisualStyleBackColor = true;
            button2.Click += exit_Click;
            // 
            // filePath
            // 
            filePath.AutoSize = true;
            filePath.Font = new Font("Microsoft Sans Serif", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            filePath.ForeColor = SystemColors.ButtonFace;
            filePath.Location = new Point(16, 629);
            filePath.Margin = new Padding(4, 0, 4, 0);
            filePath.Name = "filePath";
            filePath.Size = new Size(195, 24);
            filePath.TabIndex = 41;
            filePath.Text = "-- Path to Pak File --";
            // 
            // selectNewFileButton
            // 
            selectNewFileButton.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Bold, GraphicsUnit.Point);
            selectNewFileButton.ForeColor = SystemColors.MenuText;
            selectNewFileButton.Location = new Point(364, 660);
            selectNewFileButton.Margin = new Padding(4, 3, 4, 3);
            selectNewFileButton.Name = "selectNewFileButton";
            selectNewFileButton.Size = new Size(356, 62);
            selectNewFileButton.TabIndex = 42;
            selectNewFileButton.Text = "Select New File";
            selectNewFileButton.UseVisualStyleBackColor = true;
            selectNewFileButton.Click += selectNewFileButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1269, 736);
            Controls.Add(selectNewFileButton);
            Controls.Add(filePath);
            Controls.Add(button2);
            Controls.Add(cleaningUpResult);
            Controls.Add(cleaningUpProgressbar);
            Controls.Add(label8);
            Controls.Add(renamingZipResult);
            Controls.Add(renamingZipProgressbar);
            Controls.Add(label7);
            Controls.Add(reZipResult);
            Controls.Add(reZipProgressbar);
            Controls.Add(label6);
            Controls.Add(replaceString3Result);
            Controls.Add(replaceString2Result);
            Controls.Add(replaceString1Result);
            Controls.Add(replaceString3Progressbar);
            Controls.Add(replaceString2Progressbar);
            Controls.Add(replaceString1Progressbar);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(extractZipResult);
            Controls.Add(renamePakResult);
            Controls.Add(extractZipProgressbar);
            Controls.Add(renamePakProgressBar);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonFace;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            Name = "Form1";
            Text = "Fantasy Grounds XP File Modifier";
            FormClosing += Form1_FormClosing;
            FormClosed += Form1_FormClosed;
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button button1;
        private ProgressBar renamePakProgressBar;
        private System.Windows.Forms.Timer renamePakTimer;
        private ProgressBar extractZipProgressbar;
        private System.Windows.Forms.Timer extractZipTimer;
        private Label renamePakResult;
        private Label extractZipResult;
        private Label label3;
        private Label label4;
        private Label label5;
        private ProgressBar replaceString1Progressbar;
        private ProgressBar replaceString2Progressbar;
        private ProgressBar replaceString3Progressbar;
        private Label replaceString1Result;
        private Label replaceString2Result;
        private Label replaceString3Result;
        private System.Windows.Forms.Timer replaceString1Timer;
        private System.Windows.Forms.Timer replaceString2Timer;
        private System.Windows.Forms.Timer replaceString3Timer;
        private Label label6;
        private ProgressBar reZipProgressbar;
        private Label reZipResult;
        private System.Windows.Forms.Timer reZipTimer;
        private Label label7;
        private ProgressBar renamingZipProgressbar;
        private Label renamingZipResult;
        private System.Windows.Forms.Timer renamingZipTimer;
        private Label label8;
        private ProgressBar cleaningUpProgressbar;
        private Label cleaningUpResult;
        private System.Windows.Forms.Timer cleaningUpTimer;
        private Button button2;
        private FolderBrowserDialog folderBrowserDialog1;
        private Label filePath;
        private Button selectNewFileButton;
    }
}