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
            this.checkBoxPost = new System.Windows.Forms.CheckBox();
            this.UrlText = new System.Windows.Forms.TextBox();
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
            this.ChoosePath.SuspendLayout();
            this.ChooseHashAlgorithm.SuspendLayout();
            this.flowLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // HashSum
            // 
            this.HashSum.Location = new System.Drawing.Point(3, 39);
            this.HashSum.Name = "HashSum";
            this.HashSum.Size = new System.Drawing.Size(141, 30);
            this.HashSum.TabIndex = 0;
            this.HashSum.Text = "Generate Hash Sum";
            this.HashSum.UseVisualStyleBackColor = true;
            this.HashSum.Click += new System.EventHandler(this.HashSum_Click);
            // 
            // Path
            // 
            this.Path.Location = new System.Drawing.Point(3, 3);
            this.Path.Name = "Path";
            this.Path.Size = new System.Drawing.Size(141, 30);
            this.Path.TabIndex = 1;
            this.Path.Text = "Path";
            this.Path.UseVisualStyleBackColor = true;
            this.Path.Click += new System.EventHandler(this.Path_Click);
            // 
            // OpenTxt
            // 
            this.OpenTxt.Location = new System.Drawing.Point(3, 121);
            this.OpenTxt.Name = "OpenTxt";
            this.OpenTxt.Size = new System.Drawing.Size(141, 30);
            this.OpenTxt.TabIndex = 2;
            this.OpenTxt.Text = "Open File With Hash Sum";
            this.OpenTxt.UseVisualStyleBackColor = true;
            this.OpenTxt.Click += new System.EventHandler(this.OpenTxt_Click);
            // 
            // ClearFile
            // 
            this.ClearFile.Location = new System.Drawing.Point(3, 157);
            this.ClearFile.Name = "ClearFile";
            this.ClearFile.Size = new System.Drawing.Size(141, 30);
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
            this.Count.Size = new System.Drawing.Size(91, 13);
            this.Count.TabIndex = 6;
            this.Count.Text = "Count of files: 0/0";
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
            // checkBoxPost
            // 
            this.checkBoxPost.AutoSize = true;
            this.checkBoxPost.Location = new System.Drawing.Point(456, 184);
            this.checkBoxPost.Name = "checkBoxPost";
            this.checkBoxPost.Size = new System.Drawing.Size(99, 17);
            this.checkBoxPost.TabIndex = 9;
            this.checkBoxPost.Text = "Post on the site";
            this.checkBoxPost.UseVisualStyleBackColor = true;
            this.checkBoxPost.CheckedChanged += new System.EventHandler(this.checkBoxPost_CheckedChanged);
            // 
            // UrlText
            // 
            this.UrlText.Enabled = false;
            this.UrlText.Location = new System.Drawing.Point(456, 207);
            this.UrlText.Name = "UrlText";
            this.UrlText.Size = new System.Drawing.Size(267, 20);
            this.UrlText.TabIndex = 10;
            this.UrlText.TextChanged += new System.EventHandler(this.UrlText_TextChanged);
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
            this.FolderPath.Checked = true;
            this.FolderPath.Location = new System.Drawing.Point(67, 13);
            this.FolderPath.Name = "FolderPath";
            this.FolderPath.Size = new System.Drawing.Size(54, 17);
            this.FolderPath.TabIndex = 1;
            this.FolderPath.TabStop = true;
            this.FolderPath.Text = "Folder";
            this.FolderPath.UseVisualStyleBackColor = true;
            this.FolderPath.CheckedChanged += new System.EventHandler(this.FolderPath_CheckedChanged);
            // 
            // FilePath
            // 
            this.FilePath.AutoSize = true;
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
            this.ChoosePathTxt.Location = new System.Drawing.Point(3, 75);
            this.ChoosePathTxt.Name = "ChoosePathTxt";
            this.ChoosePathTxt.Size = new System.Drawing.Size(141, 40);
            this.ChoosePathTxt.TabIndex = 13;
            this.ChoosePathTxt.Text = "Choose Path For File With Hash Sum";
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
            this.CurrentPathFileForHashSum.Size = new System.Drawing.Size(161, 13);
            this.CurrentPathFileForHashSum.TabIndex = 15;
            this.CurrentPathFileForHashSum.Text = "Current path file with Hash Sum: ";
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.Controls.Add(this.Path);
            this.flowLayoutPanel.Controls.Add(this.HashSum);
            this.flowLayoutPanel.Controls.Add(this.ChoosePathTxt);
            this.flowLayoutPanel.Controls.Add(this.OpenTxt);
            this.flowLayoutPanel.Controls.Add(this.ClearFile);
            this.flowLayoutPanel.Location = new System.Drawing.Point(11, 43);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(148, 189);
            this.flowLayoutPanel.TabIndex = 16;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 311);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.CurrentPathFileForHashSum);
            this.Controls.Add(this.CurrentPath);
            this.Controls.Add(this.ChooseHashAlgorithm);
            this.Controls.Add(this.ChoosePath);
            this.Controls.Add(this.UrlText);
            this.Controls.Add(this.checkBoxPost);
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
        private System.Windows.Forms.CheckBox checkBoxPost;
        private System.Windows.Forms.TextBox UrlText;
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
    }
}

