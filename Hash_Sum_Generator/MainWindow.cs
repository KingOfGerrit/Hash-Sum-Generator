using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Collections;
using System.Net;
using System.Threading;
using System.Security.Cryptography;
using System.Windows;

namespace Hash_Sum_Generator
{

    public partial class MainWindow : Form
    {
        private string stPath = Hash_Sum_Generator.Properties.Settings.Default.Path;
        private string stPathOfHashSumTxt = Hash_Sum_Generator.Properties.Settings.Default.PathForFileWithHashSum;
        private Thread Hash = null;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if(Hash_Sum_Generator.Properties.Settings.Default.Saved_Path == null)
                Hash_Sum_Generator.Properties.Settings.Default.Saved_Path = new List<string>();

            if (Hash_Sum_Generator.Properties.Settings.Default.Saved_Path != null)
                SavedPathListBox.Items.AddRange(Hash_Sum_Generator.Properties.Settings.Default.Saved_Path.ToArray());
            //SavedPathListBox.DataSource = Hash_Sum_Generator.Properties.Settings.Default.Saved_Path;

            if (!(File.Exists(stPathOfHashSumTxt + "\\Hash Sums.txt")))
            {
                FileStream fs = File.Create(stPathOfHashSumTxt + "\\Hash Sums.txt");
                fs.Close();
            }

            CurrentPath.Text = "Current path:  " + stPath;

            if (Hash_Sum_Generator.Properties.Settings.Default.PathForFileWithHashSum == "")
            {
                Hash_Sum_Generator.Properties.Settings.Default.PathForFileWithHashSum = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                stPathOfHashSumTxt = Hash_Sum_Generator.Properties.Settings.Default.PathForFileWithHashSum;
            }


            CurrentPathFileForHashSum.Text = "Hash Sum export file:  " + stPathOfHashSumTxt + "\\Hash Sum.txt";

            //UrlText.Text = Hash_Sum_Generator.Properties.Settings.Default.UrlText;

            //checkBoxPost.Checked = Hash_Sum_Generator.Properties.Settings.Default.Post_on_the_site;

            //if (checkBoxPost.Checked == true)
            //{
            //    OpenTxt.Enabled = false;
            //    ClearFile.Enabled = false;
            //    UrlText.Enabled = true;
            //}
            //else
            //{
            //    OpenTxt.Enabled = true;
            //    ClearFile.Enabled = true;
            //    UrlText.Enabled = false;
            //}

            switch (Hash_Sum_Generator.Properties.Settings.Default.HashAlgorithm)
            {
                case "MD5":
                    ChooseMD5.Checked = true;
                    break;
                case "RIPEMD160":
                    ChooseRIPEMD160.Checked = true;
                    break;
                case "SHA1":
                    ChooseSHA1.Checked = true;
                    break;
                case "SHA256":
                    ChooseSHA256.Checked = true;
                    break;
                case "SHA384":
                    ChooseSHA384.Checked = true;
                    break;
                case "SHA512":
                    ChooseSHA512.Checked = true;
                    break;
                default:
                    ChooseMD5.Checked = true;
                    break;
            }

            switch (Hash_Sum_Generator.Properties.Settings.Default.File_or_Folder)
            {
                case "File":
                    FilePath.Checked = true;
                    break;
                case "Folder":
                    FolderPath.Checked = true;
                    break;
                default:
                    FilePath.Checked = true;
                    break;
            }
        }

        private void ChoosePathTxt_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog OPF = new FolderBrowserDialog();
            if (OPF.ShowDialog() == DialogResult.OK)
            {
                File.Delete(stPathOfHashSumTxt + "\\Hash Sums.txt");
                stPathOfHashSumTxt = OPF.SelectedPath;

                FileStream fs = File.Create(stPathOfHashSumTxt + "\\Hash Sums.txt");
                fs.Close();

                CurrentPathFileForHashSum.Text = "Hash Sum export file:  " + stPathOfHashSumTxt + "\\Hash Sum.txt";
                Hash_Sum_Generator.Properties.Settings.Default.PathForFileWithHashSum = stPathOfHashSumTxt;
                Hash_Sum_Generator.Properties.Settings.Default.Save();
            }
        }
        
        private string ChooseFolder()
        {
            FolderBrowserDialog OPF = new FolderBrowserDialog();
            if (OPF.ShowDialog() == DialogResult.OK)
                return OPF.SelectedPath;
            else
                return stPath;
        }

        private string ChooseFile()
        {
            OpenFileDialog OPF = new OpenFileDialog();
            if (OPF.ShowDialog() == DialogResult.OK)
                return OPF.FileName;
            else
                return stPath;
        }

        private void Path_Click(object sender, EventArgs e)
        {
            if(FolderPath.Checked == true)
            {
                stPath = ChooseFolder();
                CurrentPath.Text = "Current path:  " + stPath;
                Hash_Sum_Generator.Properties.Settings.Default.Path = stPath;
                Hash_Sum_Generator.Properties.Settings.Default.Save();

                SavedPathListBox.SelectedIndex = -1;
            } 
            else
            {
                stPath = ChooseFile();
                CurrentPath.Text = "Current path:  " + stPath;
                Hash_Sum_Generator.Properties.Settings.Default.Path = stPath;
                Hash_Sum_Generator.Properties.Settings.Default.Save();

                SavedPathListBox.SelectedIndex = -1;
            }
        }

        //MD5
        public string ComputeMD5Checksum(string path)
        {
            using (var vMD5 = MD5.Create())
            {
                using (var stream = File.OpenRead(path))
                {
                    return BitConverter.ToString(vMD5.ComputeHash(stream)).Replace("-", string.Empty);
                }
            }
        }

        //RIPEMD160
        public string ComputeRIPEMD160Checksum(string path)
        {
            using (var vRIPEMD160 = RIPEMD160.Create())
            {
                using (var stream = File.OpenRead(path))
                {
                    return BitConverter.ToString(vRIPEMD160.ComputeHash(stream)).Replace("-", string.Empty);
                }
            }
        }

        //SHA1
        public string ComputeSHA1Checksum(string path)
        {
            using (var vSHA1 = SHA1.Create())
            {
                using (var stream = File.OpenRead(path))
                {
                    return BitConverter.ToString(vSHA1.ComputeHash(stream)).Replace("-", string.Empty);
                }
            }
        }

        //SHA256
        public string ComputeSHA256Checksum(string path)
        {
            using (var vSHA256 = SHA256.Create())
            {
                using (var stream = File.OpenRead(path))
                {
                    return BitConverter.ToString(vSHA256.ComputeHash(stream)).Replace("-", string.Empty);
                }
            }
        }

        //SHA384
        public string ComputeSHA384Checksum(string path)
        {
            using (var vSHA384 = SHA384.Create())
            {
                using (var stream = File.OpenRead(path))
                {
                    return BitConverter.ToString(vSHA384.ComputeHash(stream)).Replace("-", string.Empty);
                }
            }
        }

        //SHA512
        public string ComputeSHA512Checksum(string path)
        {
            using (var vSHA512 = SHA512.Create())
            {
                using (var stream = File.OpenRead(path))
                {
                    return BitConverter.ToString(vSHA512.ComputeHash(stream)).Replace("-", string.Empty);
                }
            }
        }

        //Post on the site
        //private void POST(string Data, string Url)
        //{
        //    try
        //    {
        //        System.Net.WebRequest req = System.Net.WebRequest.Create(Url);
        //        req.Method = "POST";
        //        req.Timeout = 100000;
        //        req.ContentType = "application/x-www-form-urlencoded";
        //        byte[] sentData = Encoding.GetEncoding(1251).GetBytes(Data);
        //        req.ContentLength = sentData.Length;
        //        System.IO.Stream sendStream = req.GetRequestStream();
        //        sendStream.Write(sentData, 0, sentData.Length);
        //        sendStream.Close();
        //    }
        //      catch (ThreadAbortException)
        //    {
        //      throw;
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        //Main function
        public void GenerateHash()
        {
            try
            {
                if (!(File.Exists(stPathOfHashSumTxt + "\\Hash Sums.txt")))
                {
                    FileStream fs = File.Create(stPathOfHashSumTxt + "\\Hash Sums.txt");
                    fs.Close();
                }

                string[] stFiles = new String[1];
                string[] stFilesFull = new String[1];
            
                if (FolderPath.Checked == true)
                {
                    stFiles = Directory.GetFiles(stPath, "*.*", SearchOption.AllDirectories);
                    stFilesFull = Directory.GetFiles(stPath, "*.*", SearchOption.AllDirectories);
                }
                else
                {
                    stFiles[0] = stPath;
                    stFilesFull[0] = stPath;
                }
            

                //Disable all interface
                Invoke((Action)(() =>
                {
                    flowLayoutPanel.Enabled = false;
                    groupBoxSavedPath.Enabled = false;
                    About_Button.Enabled = false;
                    ChooseHashAlgorithm.Enabled = false;
                    ChoosePath.Enabled = false;
                    HashSum.Enabled = false;

                    AbortButton.Enabled = true;

                    progressBar1.Value = 0;
                    Count.Text = "Number of files: " + "0/" + Convert.ToString(stFiles.Length);
                    progressBar1.Maximum = stFiles.Length;
                    Status.Text = "Status: Create array of files...";
                }));

                if (FolderPath.Checked == true)
                {
                    for (Int32 i = 0; i < stFiles.Length; i++)
                    {
                        stFiles[i] = stFiles[i].Remove(0, stPath.Length);

                        Invoke((Action)(() =>
                        {
                            progressBar1.Value++;
                            Count.Text = "Number of files: " + (i + 1) + "/" + Convert.ToString(stFiles.Length);
                            File_Name.Text = "File:  " + stFilesFull[i];
                        }));
                    }
                }

                /*
                if (System.IO.File.Exists(stPathOfHashSumTxt + "\\Hash Sums.txt"))
                {
                    string s = File.ReadAllText(stPathOfHashSumTxt + "\\Hash Sums.txt");
                    s = s.Remove(0, s.Length);
                    File.WriteAllText(stPathOfHashSumTxt + "\\Hash Sums.txt", s);
                }
                */

                //if (checkBoxPost.Checked == false)
                //{

                Invoke((Action)(() =>
                {
                    Count.Text = "Number of files: " + "0/" + Convert.ToString(stFiles.Length);
                    progressBar1.Value = 0;
                    Status.Text = "Status: Generate hash sum...";
                }));

                StreamWriter HashWrite;

                FileInfo file = new FileInfo(stPathOfHashSumTxt + "\\Hash Sums.txt");

                if ((File.ReadAllLines(stPathOfHashSumTxt + "\\Hash Sums.txt")).Length != 0)
                {
                    HashWrite = file.AppendText();
                    HashWrite.WriteLine("\n");
                    HashWrite.Close();
                }

                for (Int32 i = 0; i < stFiles.Length; i++)
                {

                    HashWrite = file.AppendText();

                    switch (Hash_Sum_Generator.Properties.Settings.Default.HashAlgorithm)
                    {
                        case "MD5":
                            HashWrite.WriteLine(stFiles[i] + "\t" + ComputeMD5Checksum(stFilesFull[i]));
                            break;
                        case "RIPEMD160":
                            HashWrite.WriteLine(stFiles[i] + "\t" + ComputeRIPEMD160Checksum(stFilesFull[i]));
                            break;
                        case "SHA1":
                            HashWrite.WriteLine(stFiles[i] + "\t" + ComputeSHA1Checksum(stFilesFull[i]));
                            break;
                        case "SHA256":
                            HashWrite.WriteLine(stFiles[i] + "\t" + ComputeSHA256Checksum(stFilesFull[i]));
                            break;
                        case "SHA384":
                            HashWrite.WriteLine(stFiles[i] + "\t" + ComputeSHA384Checksum(stFilesFull[i]));
                            break;
                        case "SHA512":
                            HashWrite.WriteLine(stFiles[i] + "\t" + ComputeSHA512Checksum(stFilesFull[i]));
                            break;
                        default:
                            HashWrite.WriteLine(stFiles[i] + "\t" + ComputeMD5Checksum(stFilesFull[i]));
                            break;
                    }

                    //if (ChooseMD5.Checked == true)
                    //    HashWrite.WriteLine(stFiles[i] + "\t" + ComputeMD5Checksum(stFilesFull[i]));
                    //else if (ChooseSHA1.Checked == true)
                    //    HashWrite.WriteLine(stFiles[i] + "\t" + ComputeSHA1Checksum(stFilesFull[i]));
                    //else if (ChooseSHA256.Checked == true)
                    //    HashWrite.WriteLine(stFiles[i] + "\t" + ComputeSHA256Checksum(stFilesFull[i]));
                    //else if (ChooseSHA384.Checked == true)
                    //    HashWrite.WriteLine(stFiles[i] + "\t" + ComputeSHA384Checksum(stFilesFull[i]));
                    //else if (ChooseSHA512.Checked == true)
                    //    HashWrite.WriteLine(stFiles[i] + "\t" + ComputeSHA512Checksum(stFilesFull[i]));
                    //else if (ChooseRIPEMD160.Checked == true)
                    //    HashWrite.WriteLine(stFiles[i] + "\t" + ComputeRIPEMD160Checksum(stFilesFull[i]));

                    HashWrite.Close();

                    Invoke((Action)(() =>
                    {
                        progressBar1.Value++;
                        Count.Text = "Number of files: " + (i + 1) + "/" + Convert.ToString(stFiles.Length);
                        File_Name.Text = "File:  " + stFilesFull[i];
                    }));
                }

                //} 
                //else
                //{
                //    Invoke((Action)(() =>
                //    {
                //        progressBar1.Value = 0;
                //        Status.Text = "Status: Load in site...";
                //    }));
                
                //    for (Int32 i = 0; i < stFiles.Length; i++)
                //    {
                //        Invoke((Action)(() =>
                //        {
                //            progressBar1.Value++;
                //            Count.Text = "Count of files: " + (i + 1) + "/" + Convert.ToString(stFiles.Length);
                //            File_Name.Text = " " + stFilesFull[i];
                //        }));

                //        POST("key=" + stFiles[i] + "&" + "stmd5=" + ComputeMD5Checksum(stFilesFull[i]), UrlText.Text);
                //    }
                //}

                Invoke((Action)(() =>
                {
                    Status.Text = "Status: Complete";

                    //Enable interface
                    //UrlText.Enabled = true;
                    //checkBoxPost.Enabled = true;

                    AbortButton.Enabled = false;

                    groupBoxSavedPath.Enabled = true;
                    About_Button.Enabled = true;
                    flowLayoutPanel.Enabled = true;
                    HashSum.Enabled = true;
                    ChooseHashAlgorithm.Enabled = true;
                    ChoosePath.Enabled = true;

                    //if (checkBoxPost.Checked == true)
                    //{
                    //    OpenTxt.Enabled = false;
                    //    ClearFile.Enabled = false;
                    //    UrlText.Enabled = true;
                    //}
                    //else
                    //{
                    //    OpenTxt.Enabled = true;
                    //    ClearFile.Enabled = true;
                    //    UrlText.Enabled = false;
                    //}

                    MessageBox.Show("Complete");
                }));
            }
            catch (ThreadAbortException)
            {
                throw;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void HashSum_Click(object sender, EventArgs e)
        {
            if (stPath != "")
            {
                progressBar1.Value = 0;
                Count.Text = "Number of files: 0/0";
                Status.Text = "Status: ";
                //Thread for calculate hash
                Hash = new Thread(new ThreadStart(GenerateHash));
                Hash.IsBackground = true;
                Hash.Start();
            }
            else
            {
                MessageBox.Show("Select path!!!");
            }
        }

        private void OpenTxt_Click(object sender, EventArgs e)
        {
            if (File.Exists(stPathOfHashSumTxt + "\\Hash Sums.txt"))
            {
                Process proc = new Process();
                proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.FileName = stPathOfHashSumTxt + "\\Hash Sums.txt";
                proc.Start();
            }
            else
            {
                FileStream fs = File.Create(stPathOfHashSumTxt + "\\Hash Sums.txt");
                fs.Close();

                Process proc = new Process();
                proc.StartInfo.UseShellExecute = true;
                proc.StartInfo.FileName = stPathOfHashSumTxt + "\\Hash Sums.txt";
                proc.Start();
            }
        }

        private void ClearFile_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to clear file???", "", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                if (File.Exists(stPathOfHashSumTxt + "\\Hash Sums.txt"))
                {
                    string s = File.ReadAllText(stPathOfHashSumTxt + "\\Hash Sums.txt");
                    s = s.Remove(0, s.Length);
                    File.WriteAllText(stPathOfHashSumTxt + "\\Hash Sums.txt", s);
                }
                else
                {
                    FileStream fs = File.Create(stPathOfHashSumTxt + "\\Hash Sums.txt");
                    fs.Close();

                    string s = File.ReadAllText(stPathOfHashSumTxt + "\\Hash Sums.txt");
                    s = s.Remove(0, s.Length);
                    File.WriteAllText(stPathOfHashSumTxt + "\\Hash Sums.txt", s);
                }
            }
        }

        //private void checkBoxPost_CheckedChanged(object sender, EventArgs e)
        //{
        //    Hash_Sum_Generator.Properties.Settings.Default.Post_on_the_site = checkBoxPost.Checked;
        //    Hash_Sum_Generator.Properties.Settings.Default.Save();

        //    if (checkBoxPost.Checked == true)
        //    {
        //        OpenTxt.Enabled = false;
        //        ClearFile.Enabled = false;
        //        UrlText.Enabled = true;
        //    }
        //    else
        //    {
        //        OpenTxt.Enabled = true;
        //        ClearFile.Enabled = true;
        //        UrlText.Enabled = false;
        //    }
        //}

        //private void UrlText_TextChanged(object sender, EventArgs e)
        //{
        //    Hash_Sum_Generator.Properties.Settings.Default.UrlText = UrlText.Text;
        //    Hash_Sum_Generator.Properties.Settings.Default.Save();
        //}

        private void ChooseAlgorithm_CheckedChanged(object sender, EventArgs e)
        {
            Hash_Sum_Generator.Properties.Settings.Default.HashAlgorithm = (((RadioButton)sender).Name).Replace("Choose", "");
            Hash_Sum_Generator.Properties.Settings.Default.Save();
        }

        //private void ChooseMD5_CheckedChanged(object sender, EventArgs e)
        //{
        //    Hash_Sum_Generator.Properties.Settings.Default.HashAlgorithm = "MD5";
        //    Hash_Sum_Generator.Properties.Settings.Default.Save();
        //}

        //private void ChooseRIPEMD160_CheckedChanged(object sender, EventArgs e)
        //{
        //    Hash_Sum_Generator.Properties.Settings.Default.HashAlgorithm = "RIPEMD160";
        //    Hash_Sum_Generator.Properties.Settings.Default.Save();
        //}

        //private void ChooseSHA1_CheckedChanged(object sender, EventArgs e)
        //{
        //    Hash_Sum_Generator.Properties.Settings.Default.HashAlgorithm = "SHA1";
        //    Hash_Sum_Generator.Properties.Settings.Default.Save();
        //}

        //private void ChooseSHA256_CheckedChanged(object sender, EventArgs e)
        //{
        //    Hash_Sum_Generator.Properties.Settings.Default.HashAlgorithm = "SHA256";
        //    Hash_Sum_Generator.Properties.Settings.Default.Save();
        //}

        //private void ChooseSHA384_CheckedChanged(object sender, EventArgs e)
        //{
        //    Hash_Sum_Generator.Properties.Settings.Default.HashAlgorithm = "SHA384";
        //    Hash_Sum_Generator.Properties.Settings.Default.Save();
        //}

        //private void ChooseSHA512_CheckedChanged(object sender, EventArgs e)
        //{
        //    Hash_Sum_Generator.Properties.Settings.Default.HashAlgorithm = "SHA512";
        //    Hash_Sum_Generator.Properties.Settings.Default.Save();
        //}
        

        private void FilePath_CheckedChanged(object sender, EventArgs e)
        {
            if(FilePath.Checked == true)
            {
                FileAttributes attr = new FileAttributes();

                if(stPath.Length != 0)
                {
                    attr = File.GetAttributes(@stPath);
                }

                if (!(attr.HasFlag(FileAttributes.Directory)))
                {
                    stPath = "";
                    CurrentPath.Text = "Current path:  ";
                    Hash_Sum_Generator.Properties.Settings.Default.Path = stPath;
                    Hash_Sum_Generator.Properties.Settings.Default.Save();
                }
                Hash_Sum_Generator.Properties.Settings.Default.File_or_Folder = "File";
                Hash_Sum_Generator.Properties.Settings.Default.Save();
            }
        }

        private void FolderPath_CheckedChanged(object sender, EventArgs e)
        {
            if (FolderPath.Checked == true)
            {
                FileAttributes attr = new FileAttributes();

                if (stPath.Length != 0)
                {
                    attr = File.GetAttributes(@stPath);
                }

                if (attr.HasFlag(FileAttributes.Directory))
                {
                    stPath = "";
                    CurrentPath.Text = "Current path:  ";
                    Hash_Sum_Generator.Properties.Settings.Default.Path = stPath;
                    Hash_Sum_Generator.Properties.Settings.Default.Save();
                }
                Hash_Sum_Generator.Properties.Settings.Default.File_or_Folder = "Folder";
                Hash_Sum_Generator.Properties.Settings.Default.Save();
            }
        }


        private void Add_Path_Click(object sender, EventArgs e)
        {
            if (FolderPath.Checked == true)
            {
                string stTMPPath = ChooseFolder();
                if (stTMPPath != "" && Hash_Sum_Generator.Properties.Settings.Default.Saved_Path.Contains(stTMPPath) == false)
                {
                    SavedPathListBox.Items.Add(stTMPPath);
                    stPath = Convert.ToString(SavedPathListBox.Items[SavedPathListBox.Items.Count - 1]);
                    CurrentPath.Text = "Current path:  " + stPath;
                    Hash_Sum_Generator.Properties.Settings.Default.Path = stPath;
                    Hash_Sum_Generator.Properties.Settings.Default.Saved_Path = SavedPathListBox.Items.OfType<string>().ToList();
                    Hash_Sum_Generator.Properties.Settings.Default.Save();

                    SavedPathListBox.SelectedIndex = SavedPathListBox.Items.Count - 1;
                }
                else
                    SavedPathListBox.SelectedIndex = Hash_Sum_Generator.Properties.Settings.Default.Saved_Path.FindIndex(x => x.StartsWith(stTMPPath));
            }
            else
            {
                string stTMPPath = ChooseFile();
                if (stTMPPath != "" && Hash_Sum_Generator.Properties.Settings.Default.Saved_Path.Contains(stTMPPath) == false)
                {
                    SavedPathListBox.Items.Add(stTMPPath);
                    stPath = Convert.ToString(SavedPathListBox.Items[SavedPathListBox.Items.Count - 1]);
                    CurrentPath.Text = "Current path:  " + stPath;
                    Hash_Sum_Generator.Properties.Settings.Default.Path = stPath;
                    Hash_Sum_Generator.Properties.Settings.Default.Saved_Path = SavedPathListBox.Items.OfType<string>().ToList();
                    Hash_Sum_Generator.Properties.Settings.Default.Save();

                    SavedPathListBox.SelectedIndex = SavedPathListBox.Items.Count - 1;
                }
                else
                    SavedPathListBox.SelectedIndex = Hash_Sum_Generator.Properties.Settings.Default.Saved_Path.FindIndex(x => x.StartsWith(stTMPPath));
            }

            string[] test = stPath.Split(new Char[] { '\\' });
        }

        private void Delete_Path_Click(object sender, EventArgs e)
        {
            if (SavedPathListBox.SelectedIndex != -1)
            {
                Hash_Sum_Generator.Properties.Settings.Default.Saved_Path.RemoveAt(SavedPathListBox.SelectedIndex);

                SavedPathListBox.Items.Remove(SavedPathListBox.SelectedItem);

                Hash_Sum_Generator.Properties.Settings.Default.Save();

                SavedPathListBox.SelectedIndex = SavedPathListBox.Items.Count - 1;
            }
            
        }

        private void Delete_All_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete all???", "", MessageBoxButtons.YesNo);
            if(result == DialogResult.Yes)
            {
                SavedPathListBox.Items.Clear();
                Hash_Sum_Generator.Properties.Settings.Default.Saved_Path.Clear();
                Hash_Sum_Generator.Properties.Settings.Default.Save();
            }
            
        }

        private void SavedPathListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(SavedPathListBox.Items.Count != 0)
            {
                if (SavedPathListBox.SelectedItem != null && SavedPathListBox.SelectedIndex != -1)
                {
                    FileAttributes attr = File.GetAttributes(@stPath);

                    stPath = Convert.ToString(SavedPathListBox.SelectedItem);
                    CurrentPath.Text = "Current path:  " + stPath;
                    Hash_Sum_Generator.Properties.Settings.Default.Path = stPath;
                    Hash_Sum_Generator.Properties.Settings.Default.Save();

                    if (attr.HasFlag(FileAttributes.Directory))
                        FolderPath.Checked = true;
                    else
                        FilePath.Checked = true;
                }
            }
            else
            {
                stPath = "";
                CurrentPath.Text = "Current path:  ";
                Hash_Sum_Generator.Properties.Settings.Default.Path = stPath;
                Hash_Sum_Generator.Properties.Settings.Default.Save();
            }
            

            //int n = stPath.IndexOf(".");
        }


        private void About_Button_Click(object sender, EventArgs e)
        {
            AboutWindow form = new AboutWindow();
            form.ShowDialog();
        }


        private void AbortButton_Click(object sender, EventArgs e)
        {
            Hash.Abort();
            Status.Text = "Status: Aborted";

            AbortButton.Enabled = false;

            groupBoxSavedPath.Enabled = true;
            About_Button.Enabled = true;
            flowLayoutPanel.Enabled = true;
            //UrlText.Enabled = true;
            //checkBoxPost.Enabled = true;
            ChooseHashAlgorithm.Enabled = true;
            HashSum.Enabled = true;

            //if (checkBoxPost.Checked == true)
            //{
            //    OpenTxt.Enabled = false;
            //    ClearFile.Enabled = false;
            //    UrlText.Enabled = true;
            //}
            //else
            //{
            //    OpenTxt.Enabled = true;
            //    ClearFile.Enabled = true;
            //    UrlText.Enabled = false;
            //}
        }


        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            ThreadStart ts = delegate()
            {
                BeginInvoke((Action)delegate()
                {
                    Application.Exit();
                });
            };
            Thread t = new Thread(ts);
            t.Start();
        }
    }
}