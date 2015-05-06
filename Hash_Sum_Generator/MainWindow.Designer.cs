namespace Hash_Sum_Generator
{
    partial class MainWindow
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.HashSum = new System.Windows.Forms.Button();
            this.Path = new System.Windows.Forms.Button();
            this.OpenTxt = new System.Windows.Forms.Button();
            this.ClearFile = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.Status = new System.Windows.Forms.Label();
            this.Count = new System.Windows.Forms.Label();
            this.File_Name = new System.Windows.Forms.Label();
            this.ChoosePath = new System.Windows.Forms.GroupBox();
            this.FolderPath = new System.Windows.Forms.RadioButton();
            this.FilePath = new System.Windows.Forms.RadioButton();
            this.ChooseHashAlgorithm = new System.Windows.Forms.GroupBox();
            this.ChooseRIPEMD160 = new System.Windows.Forms.RadioButton();
            this.ChooseSHA512 = new System.Windows.Forms.RadioButton();
            this.ChooseSHA384 = new System.Windows.Forms.RadioButton();
            this.ChooseSHA256 = new System.Windows.Forms.RadioButton();
            this.ChooseSHA1 = new System.Windows.Forms.RadioButton();
            this.ChooseMD5 = new System.Windows.Forms.RadioButton();
            this.ChoosePathTxt = new System.Windows.Forms.Button();
            this.CurrentPath = new System.Windows.Forms.Label();
            this.CurrentPathFileForHashSum = new System.Windows.Forms.Label();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.About_Button = new System.Windows.Forms.Button();
            this.SavedPathListBox = new System.Windows.Forms.ListBox();
            this.Add_Path = new System.Windows.Forms.Button();
            this.Delete_Path = new System.Windows.Forms.Button();
            this.Delete_All = new System.Windows.Forms.Button();
            this.groupBoxSavedPath = new System.Windows.Forms.GroupBox();
            this.AbortButton = new System.Windows.Forms.Button();
            this.ChoosePath.SuspendLayout();
            this.ChooseHashAlgorithm.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.groupBoxSavedPath.SuspendLayout();
            this.SuspendLayout();
            // 
            // HashSum
            // 
            this.HashSum.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.HashSum.Location = new System.Drawing.Point(292, 204);
            this.HashSum.Name = "HashSum";
            this.HashSum.Size = new System.Drawing.Size(350, 33);
            this.HashSum.TabIndex = 0;
            this.HashSum.Text = "Generate Hash Sum";
            this.HashSum.UseVisualStyleBackColor = true;
            this.HashSum.Click += new System.EventHandler(this.HashSum_Click);
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(3, 3);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(140, 30);
            this.Path.TabIndex = 1;
            this.Path.Text = "Path";
            this.Path.UseVisualStyleBackColor = true;
            this.Path.Click += new System.EventHandler(this.Path_Click);
            // 
            // OpenTxt
            // 
            this.OpenTxt.Location = new System.Drawing.Point(3, 80);
            this.OpenTxt.Name = "OpenTxt";
            this.OpenTxt.Size = new System.Drawing.Size(140, 30);
            this.OpenTxt.TabIndex = 2;
            this.OpenTxt.Text = "Open File With Hash Sum";
            this.OpenTxt.UseVisualStyleBackColor = true;
            this.OpenTxt.Click += new System.EventHandler(this.OpenTxt_Click);
            // 
            // ClearFile
            // 
            this.ClearFile.Location = new System.Drawing.Point(3, 116);
            this.ClearFile.Name = "ClearFile";
            this.ClearFile.Size = new System.Drawing.Size(140, 30);
            this.ClearFile.TabIndex = 3;
            this.ClearFile.Text = "Clear File With Hash Sum";
            this.ClearFile.UseVisualStyleBackColor = true;
            this.ClearFile.Click += new System.EventHandler(this.ClearFile_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 238);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(711, 25);
            this.progressBar1.TabIndex = 4;
            // 
            // Status
            // 
            this.Status.AutoSize = true;
            this.Status.Location = new System.Drawing.Point(12, 266);
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(40, 13);
            this.Status.TabIndex = 5;
            this.Status.Text = "Status:";
            // 
            // Count
            // 
            this.Count.AutoSize = true;
            this.Count.Location = new System.Drawing.Point(572, 266);
            this.Count.Name = "Count";
            this.Count.Size = new System.Drawing.Size(100, 13);
            this.Count.TabIndex = 6;
            this.Count.Text = "Number of files: 0/0";
            // 
            // File_Name
            // 
            this.File_Name.AutoSize = true;
            this.File_Name.Location = new System.Drawing.Point(12, 288);
            this.File_Name.Name = "File_Name";
            this.File_Name.Size = new System.Drawing.Size(26, 13);
            this.File_Name.TabIndex = 7;
            this.File_Name.Text = "File:";
            // 
            // ChoosePath
            // 
            this.ChoosePath.Controls.Add(this.FolderPath);
            this.ChoosePath.Controls.Add(this.FilePath);
            this.ChoosePath.Location = new System.Drawing.Point(159, 41);
            this.ChoosePath.Name = "ChoosePath";
            this.ChoosePath.Size = new System.Drawing.Size(127, 36);
            this.ChoosePath.TabIndex = 11;
            this.ChoosePath.TabStop = false;
            // 
            // FolderPath
            // 
            this.FolderPath.AutoSize = true;
            this.FolderPath.Location = new System.Drawing.Point(67, 13);
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.Size = new System.Drawing.Size(54, 17);
            this.FolderPath.TabIndex = 1;
            this.FolderPath.Text = "Folder";
            this.FolderPath.UseVisualStyleBackColor = true;
            this.FolderPath.CheckedChanged += new System.EventHandler(this.FolderPath_CheckedChanged);
            // 
            // FilePath
            // 
            this.FilePath.AutoSize = true;
            this.FilePath.Checked = true;
            this.FilePath.Location = new System.Drawing.Point(6, 13);
            this.FilePath.Name = "FilePath";
            this.FilePath.Size = new System.Drawing.Size(41, 17);
            this.FilePath.TabIndex = 0;
            this.FilePath.TabStop = true;
            this.FilePath.Text = "File";
            this.FilePath.UseVisualStyleBackColor = true;
            this.FilePath.CheckedChanged += new System.EventHandler(this.FilePath_CheckedChanged);
            // 
            // ChooseHashAlgorithm
            // 
            this.ChooseHashAlgorithm.Controls.Add(this.ChooseRIPEMD160);
            this.ChooseHashAlgorithm.Controls.Add(this.ChooseSHA512);
            this.ChooseHashAlgorithm.Controls.Add(this.ChooseSHA384);
            this.ChooseHashAlgorithm.Controls.Add(this.ChooseSHA256);
            this.ChooseHashAlgorithm.Controls.Add(this.ChooseSHA1);
            this.ChooseHashAlgorithm.Controls.Add(this.ChooseMD5);
            this.ChooseHashAlgorithm.Location = new System.Drawing.Point(159, 77);
            this.ChooseHashAlgorithm.Name = "ChooseHashAlgorithm";
            this.ChooseHashAlgorithm.Size = new System.Drawing.Size(127, 155);
            this.ChooseHashAlgorithm.TabIndex = 12;
            this.ChooseHashAlgorithm.TabStop = false;
            this.ChooseHashAlgorithm.Text = "Algorithms";
            // 
            // ChooseRIPEMD160
            // 
            this.ChooseRIPEMD160.AutoSize = true;
            this.ChooseRIPEMD160.Location = new System.Drawing.Point(6, 37);
            this.ChooseRIPEMD160.Name = "ChooseRIPEMD160";
            this.ChooseRIPEMD160.Size = new System.Drawing.Size(85, 17);
            this.ChooseRIPEMD160.TabIndex = 5;
            this.ChooseRIPEMD160.Text = "RIPEMD160";
            this.ChooseRIPEMD160.UseVisualStyleBackColor = true;
            this.ChooseRIPEMD160.CheckedChanged += new System.EventHandler(this.ChooseRIPEMD160_CheckedChanged);
            // 
            // ChooseSHA512
            // 
            this.ChooseSHA512.AutoSize = true;
            this.ChooseSHA512.Location = new System.Drawing.Point(6, 129);
            this.ChooseSHA512.Name = "ChooseSHA512";
            this.ChooseSHA512.Size = new System.Drawing.Size(65, 17);
            this.ChooseSHA512.TabIndex = 4;
            this.ChooseSHA512.Text = "SHA512";
            this.ChooseSHA512.UseVisualStyleBackColor = true;
            this.ChooseSHA512.CheckedChanged += new System.EventHandler(this.ChooseSHA512_CheckedChanged);
            // 
            // ChooseSHA384
            // 
            this.ChooseSHA384.AutoSize = true;
            this.ChooseSHA384.Location = new System.Drawing.Point(6, 106);
            this.ChooseSHA384.Name = "ChooseSHA384";
            this.ChooseSHA384.Size = new System.Drawing.Size(65, 17);
            this.ChooseSHA384.TabIndex = 3;
            this.ChooseSHA384.Text = "SHA384";
            this.ChooseSHA384.UseVisualStyleBackColor = true;
            this.ChooseSHA384.CheckedChanged += new System.EventHandler(this.ChooseSHA384_CheckedChanged);
            // 
            // ChooseSHA256
            // 
            this.ChooseSHA256.AutoSize = true;
            this.ChooseSHA256.Location = new System.Drawing.Point(6, 83);
            this.ChooseSHA256.Name = "ChooseSHA256";
            this.ChooseSHA256.Size = new System.Drawing.Size(65, 17);
            this.ChooseSHA256.TabIndex = 2;
            this.ChooseSHA256.Text = "SHA256";
            this.ChooseSHA256.UseVisualStyleBackColor = true;
            this.ChooseSHA256.CheckedChanged += new System.EventHandler(this.ChooseSHA256_CheckedChanged);
            // 
            // ChooseSHA1
            // 
            this.ChooseSHA1.AutoSize = true;
            this.ChooseSHA1.Location = new System.Drawing.Point(6, 60);
            this.ChooseSHA1.Name = "ChooseSHA1";
            this.ChooseSHA1.Size = new System.Drawing.Size(53, 17);
            this.ChooseSHA1.TabIndex = 1;
            this.ChooseSHA1.Text = "SHA1";
            this.ChooseSHA1.UseVisualStyleBackColor = true;
            this.ChooseSHA1.CheckedChanged += new System.EventHandler(this.ChooseSHA1_CheckedChanged);
            // 
            // ChooseMD5
            // 
            this.ChooseMD5.AutoSize = true;
            this.ChooseMD5.Checked = true;
            this.ChooseMD5.Location = new System.Drawing.Point(6, 14);
            this.ChooseMD5.Name = "ChooseMD5";
            this.ChooseMD5.Size = new System.Drawing.Size(48, 17);
            this.ChooseMD5.TabIndex = 0;
            this.ChooseMD5.TabStop = true;
            this.ChooseMD5.Text = "MD5";
            this.ChooseMD5.UseVisualStyleBackColor = true;
            this.ChooseMD5.CheckedChanged += new System.EventHandler(this.ChooseMD5_CheckedChanged);
            // 
            // ChoosePathTxt
            // 
            this.ChoosePathTxt.Location = new System.Drawing.Point(3, 39);
            this.ChoosePathTxt.Name = "ChoosePathTxt";
            this.ChoosePathTxt.Size = new System.Drawing.Size(140, 35);
            this.ChoosePathTxt.TabIndex = 13;
            this.ChoosePathTxt.Text = "Choose Path For Hash Sum Export File";
            this.ChoosePathTxt.UseVisualStyleBackColor = true;
            this.ChoosePathTxt.Click += new System.EventHandler(this.ChoosePathTxt_Click);
            // 
            // CurrentPath
            // 
            this.CurrentPath.AutoSize = true;
            this.CurrentPath.Location = new System.Drawing.Point(12, 9);
            this.CurrentPath.Name = "CurrentPath";
            this.CurrentPath.Size = new System.Drawing.Size(71, 13);
            this.CurrentPath.TabIndex = 14;
            this.CurrentPath.Text = "Current path: ";
            // 
            // CurrentPathFileForHashSum
            // 
            this.CurrentPathFileForHashSum.AutoSize = true;
            this.CurrentPathFileForHashSum.Location = new System.Drawing.Point(12, 27);
            this.CurrentPathFileForHashSum.Name = "CurrentPathFileForHashSum";
            this.CurrentPathFileForHashSum.Size = new System.Drawing.Size(110, 13);
            this.CurrentPathFileForHashSum.TabIndex = 15;
            this.CurrentPathFileForHashSum.Text = "Hash Sum export file: ";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.Path);
            this.flowLayoutPanel.Controls.Add(this.ChoosePathTxt);
            this.flowLayoutPanel.Controls.Add(this.OpenTxt);
            this.flowLayoutPanel.Controls.Add(this.ClearFile);
            this.flowLayoutPanel.Controls.Add(this.About_Button);
            this.flowLayoutPanel.Location = new System.Drawing.Point(11, 43);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(148, 189);
            this.flowLayoutPanel.TabIndex = 16;
            // 
            // About_Button
            // 
            this.About_Button.Location = new System.Drawing.Point(3, 152);
            this.About_Button.Name = "About_Button";
            this.About_Button.Size = new System.Drawing.Size(140, 30);
            this.About_Button.TabIndex = 23;
            this.About_Button.Text = "About";
            this.About_Button.UseVisualStyleBackColor = true;
            this.About_Button.Click += new System.EventHandler(this.About_Button_Click);
            // 
            // SavedPathListBox
            // 
            this.SavedPathListBox.FormattingEnabled = true;
            this.SavedPathListBox.HorizontalScrollbar = true;
            this.SavedPathListBox.Location = new System.Drawing.Point(87, 8);
            this.SavedPathListBox.Name = "SavedPathListBox";
            this.SavedPathListBox.Size = new System.Drawing.Size(338, 147);
            this.SavedPathListBox.TabIndex = 17;
            this.SavedPathListBox.SelectedIndexChanged += new System.EventHandler(this.SavedPathListBox_SelectedIndexChanged);
            // 
            // Add_Path
            // 
            this.Add_Path.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.Add_Path.Location = new System.Drawing.Point(6, 21);
            this.Add_Path.Name = "Add_Path";
            this.Add_Path.Size = new System.Drawing.Size(75, 23);
            this.Add_Path.TabIndex = 19;
            this.Add_Path.Text = "Add path";
            this.Add_Path.UseVisualStyleBackColor = true;
            this.Add_Path.Click += new System.EventHandler(this.Add_Path_Click);
            // 
            // Delete_Path
            // 
            this.Delete_Path.Location = new System.Drawing.Point(6, 50);
            this.Delete_Path.Name = "Delete_Path";
            this.Delete_Path.Size = new System.Drawing.Size(75, 23);
            this.Delete_Path.TabIndex = 20;
            this.Delete_Path.Text = "Delete path";
            this.Delete_Path.UseVisualStyleBackColor = true;
            this.Delete_Path.Click += new System.EventHandler(this.Delete_Path_Click);
            // 
            // Delete_All
            // 
            this.Delete_All.Location = new System.Drawing.Point(6, 79);
            this.Delete_All.Name = "Delete_All";
            this.Delete_All.Size = new System.Drawing.Size(75, 23);
            this.Delete_All.TabIndex = 21;
            this.Delete_All.Text = "Delete all";
            this.Delete_All.UseVisualStyleBackColor = true;
            this.Delete_All.Click += new System.EventHandler(this.Delete_All_Click);
            // 
            // groupBoxSavedPath
            // 
            this.groupBoxSavedPath.Controls.Add(this.SavedPathListBox);
            this.groupBoxSavedPath.Controls.Add(this.Delete_All);
            this.groupBoxSavedPath.Controls.Add(this.Add_Path);
            this.groupBoxSavedPath.Controls.Add(this.Delete_Path);
            this.groupBoxSavedPath.Location = new System.Drawing.Point(292, 43);
            this.groupBoxSavedPath.Name = "groupBoxSavedPath";
            this.groupBoxSavedPath.Size = new System.Drawing.Size(431, 160);
            this.groupBoxSavedPath.TabIndex = 22;
            this.groupBoxSavedPath.TabStop = false;
            this.groupBoxSavedPath.Text = "Favourites";
            // 
            // AbortButton
            // 
            this.AbortButton.Enabled = false;
            this.AbortButton.Location = new System.Drawing.Point(648, 209);
            this.AbortButton.Name = "AbortButton";
            this.AbortButton.Size = new System.Drawing.Size(75, 23);
            this.AbortButton.TabIndex = 24;
            this.AbortButton.Text = "Abort";
            this.AbortButton.UseVisualStyleBackColor = true;
            this.AbortButton.Click += new System.EventHandler(this.AbortButton_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 311);
            this.Controls.Add(this.AbortButton);
            this.Controls.Add(this.HashSum);
            this.Controls.Add(this.groupBoxSavedPath);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.CurrentPathFileForHashSum);
            this.Controls.Add(this.CurrentPath);
            this.Controls.Add(this.ChooseHashAlgorithm);
            this.Controls.Add(this.ChoosePath);
            this.Controls.Add(this.File_Name);
            this.Controls.Add(this.Count);
            this.Controls.Add(this.Status);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hash Sum Generator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.ChoosePath.ResumeLayout(false);
            this.ChoosePath.PerformLayout();
            this.ChooseHashAlgorithm.ResumeLayout(false);
            this.ChooseHashAlgorithm.PerformLayout();
            this.flowLayoutPanel.ResumeLayout(false);
            this.groupBoxSavedPath.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button HashSum;
        public System.Windows.Forms.Button Path;
        public System.Windows.Forms.Button OpenTxt;
        public System.Windows.Forms.Button ClearFile;
        public System.Windows.Forms.ProgressBar progressBar1;
        public System.Windows.Forms.Label Status;
        public System.Windows.Forms.Label Count;
        private System.Windows.Forms.Label File_Name;
        //private System.Windows.Forms.CheckBox checkBoxPost;
        //private System.Windows.Forms.TextBox UrlText;
        private System.Windows.Forms.GroupBox ChoosePath;
        private System.Windows.Forms.RadioButton FolderPath;
        private System.Windows.Forms.RadioButton FilePath;
        private System.Windows.Forms.GroupBox ChooseHashAlgorithm;
        private System.Windows.Forms.RadioButton ChooseSHA1;
        private System.Windows.Forms.RadioButton ChooseMD5;
        private System.Windows.Forms.RadioButton ChooseSHA384;
        private System.Windows.Forms.RadioButton ChooseSHA256;
        private System.Windows.Forms.RadioButton ChooseSHA512;
        private System.Windows.Forms.RadioButton ChooseRIPEMD160;
        public System.Windows.Forms.Button ChoosePathTxt;
        private System.Windows.Forms.Label CurrentPath;
        private System.Windows.Forms.Label CurrentPathFileForHashSum;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel;
        private System.Windows.Forms.ListBox SavedPathListBox;
        private System.Windows.Forms.Button Add_Path;
        private System.Windows.Forms.Button Delete_Path;
        private System.Windows.Forms.Button Delete_All;
        private System.Windows.Forms.GroupBox groupBoxSavedPath;
        private System.Windows.Forms.Button About_Button;
        private System.Windows.Forms.Button AbortButton;
    }
}

