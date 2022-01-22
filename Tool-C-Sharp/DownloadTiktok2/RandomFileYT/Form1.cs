using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace RandomFileYT
{
    public partial class RandomFile : Form
    {
        int currenIdChannel = -1;
        List<string> saveDatas = new List<string>();
        string logFileName = "logSaveTime.log";
        public RandomFile()
        {
            InitializeComponent();
            this.FormClosing += Form1_FormClosing;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //In case windows is trying to shut down, don't hold the process up
            if (e.CloseReason == CloseReason.WindowsShutDown) return;

            var confirmResult = MessageBox.Show("Do you want to SAVE the last time upload of this channel... ?",
                                     "Confirm Save!!",
                                     MessageBoxButtons.YesNo);
            if (confirmResult == DialogResult.Yes)
            {
                // Save the last time upload of channel.
                SaveLastTimeUploadOfChannel(currenIdChannel);
            }
            else
            {
                // If 'No', do something here.
            }
        }
        private bool SaveLastTimeUploadOfChannel(int idChannel)
        {
            var currentTime = DateTime.Now.ToString("MM/dd/yyyy hh:mm tt");
            var dataChannel = idChannel.ToString() + "-" + currentTime;
            if (saveDatas.Count == 0)
            {
                saveDatas.Add(dataChannel);
            }
            else
            {
                var upddated = false;
                for (int i = 0; i < saveDatas.Count; i++)
                {
                    int indexOf = saveDatas[i].IndexOf('-');
                    if (idChannel.ToString() == saveDatas[i].Substring(0, indexOf))
                    {
                        saveDatas[i] = dataChannel;
                        upddated = true;
                        break;
                    }
                }
                if (!upddated)
                {
                    saveDatas.Add(dataChannel);
                }
            }
            return WriteToFile(saveDatas);
        }

        private bool WriteToFile(List<string> datas)
        {
            try
            {
                using (StreamWriter writer = new StreamWriter(logFileName))
                {
                    string createText = "";
                    foreach (var item in saveDatas)
                    {
                        createText += item + Environment.NewLine;
                    }
                    writer.WriteLine(createText);
                }
            }
            catch
            {
                return false;
            }
            return true;
        }

        private void btnChon_Click(object sender, EventArgs e)
        {
            txtFolder.Text = ChooseFolder();
        }
        private string ChooseFolder()
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.SelectedPath = txtFolder.Text;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                return folderBrowserDialog1.SelectedPath;
            }
            else
            {

            }
            return txtFolder.Text;
        }

        private void txtNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
            }
            else
            {
                e.Handled = false;
            }
        }
        FileInfo[] Files;
        List<FileInfo> filesSelecteds15 = new List<FileInfo>();
        private void btnExecute_Click(object sender, EventArgs e)
        {
            DirectoryInfo d = new DirectoryInfo(txtFolder.Text);

            List<FileInfo> filesSelecteds = new List<FileInfo>();
            Files = d.GetFiles("*.mp4");
            if (Files.Length > 0)
            {
                foreach (var f in Files)
                {
                    File.SetAttributes(f.FullName, FileAttributes.Normal);
                }
                Random rd = new Random();
                int maxNumber = int.Parse(txtNumber.Text) <= Files.Length ? int.Parse(txtNumber.Text) : Files.Length;
                for (int i = 0; i < maxNumber; i++)
                {
                    filesSelecteds.Add(Files[rd.Next(0, Files.Length - 1)]);
                }

                if (cb15Each.Checked)
                {
                    filesSelecteds.Clear();
                    maxNumber = 15 <= Files.Length ? 15 : Files.Length;
                    for (int i = 0; i < maxNumber; i++)
                    {
                        var index = rd.Next(0, Files.Length - 1);
                        if (!filesSelecteds15.Contains(Files[index]))
                        {

                            filesSelecteds.Add(Files[index]);
                        }
                        else
                        {
                            i--;
                            continue;
                        }
                    }
                    filesSelecteds15.AddRange(filesSelecteds);
                }
                HideOtherFile(filesSelecteds);
            }
            else
            {
                MessageBox.Show("There is no File!");
            }
        }
        private void HideOtherFile(List<FileInfo> filesSelecteds)
        {

            foreach (var f in Files)
            {
                if (!filesSelecteds.Contains(f))
                {
                    File.SetAttributes(f.FullName, FileAttributes.Hidden);

                }
            }
        }
        private void btnReset_Click(object sender, EventArgs e)
        {

            DirectoryInfo d = new DirectoryInfo(txtFolder.Text);
            Files = d.GetFiles("*.mp4");
            foreach (var f in Files)
            {
                File.SetAttributes(f.FullName, FileAttributes.Normal);
            }
            if (filesSelecteds15 != null)
            {
                filesSelecteds15.Clear();
            }
        }

        private void cb15Each_CheckedChanged(object sender, EventArgs e)
        {
            if (cb15Each.Checked)
            {
                txtNumber.Enabled = false;
            }
            else
            {
                txtNumber.Enabled = true;
            }
            if (filesSelecteds15 != null)
            {
                filesSelecteds15.Clear();
            }
        }

        private void RandomFile_Load(object sender, EventArgs e)
        {
            txtFolder.Text = @"";
            txtNumber.Text = "105";
            ReadLastTimeUploadOfChannel();
        }

        private void cmbChannel_SelectedIndexChanged(object sender, EventArgs e)
        {
            currenIdChannel = cmbChannel.SelectedIndex;
            ShowTheLastTime(currenIdChannel);
            //
            switch (currenIdChannel)
            {
                case 0: txtFolder.Text = @"D:\Youtube\viral";
                    break;
                case 1: txtFolder.Text = @"D:\Youtube\CatsFunnyAnimal";
                    break;
                case 2: txtFolder.Text = @"D:\Youtube\CatsFunnyAnimal";
                    break;
                case 3: txtFolder.Text = @"D:\Youtube\animalsTag";
                    break;
                case 4: txtFolder.Text = @"D:\Youtube\CuteGirl";
                    break;
                default:txtFolder.Text = "";
                    break;
            }
            //
            if (!String.IsNullOrEmpty(txtFolder.Text))
            {
                if (saveDatas.Count - 1 >= currenIdChannel)
                {
                    int indexOf = saveDatas[currenIdChannel].IndexOf('-');
                    lblLastTime.Text = saveDatas[currenIdChannel].Substring(indexOf + 1, saveDatas[currenIdChannel].Length - 1 - indexOf);
                    DateTime lastTime = DateTime.Parse(lblLastTime.Text);
                    var deltaTime = DateTime.Now - lastTime;
                    if(deltaTime.TotalSeconds - 24 * 60 * 60 > 0)
                    {
                        lblStatus.ForeColor = System.Drawing.Color.Black;
                        lblStatus.Text = "Can upload video now!";
                        lblComeBack.Text = "";
                    }
                    else
                    {
                        lblStatus.ForeColor = System.Drawing.Color.Red;
                        lblStatus.Text = "Can't upload video now!";
                        lblComeBack.Text = $"Come back at: {lastTime.AddHours(24)}";
                    }
                }
            }
        }

        private void ShowTheLastTime(int currenIdChannel)
        {
            if (saveDatas.Count - 1 >= currenIdChannel)
            {
                int indexOf = saveDatas[currenIdChannel].IndexOf('-');
                lblLastTime.Text = saveDatas[currenIdChannel].Substring(indexOf + 1, saveDatas[currenIdChannel].Length -1 - indexOf);
            }
        }

        private void ReadLastTimeUploadOfChannel()
        {
            int counter = 0;
            var createNew = false;
            // Read the file and display it line by line.
            if (!File.Exists(logFileName))
            {   
                // Create a new file     
                using (FileStream fs = File.Create(logFileName))
                {
                    createNew = true;
                }
            }
            try
            {
                saveDatas.Clear();
                foreach (string line in File.ReadLines(logFileName))
                {
                    System.Console.WriteLine(line);
                    if (!String.IsNullOrEmpty(line))
                    {
                        saveDatas.Add(line);
                        counter++;
                    }
                }
                if (counter < 5 && createNew == false)
                {
                    //MessageBox.Show("Lack save data of some channel!!!");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ReadLastTimeUploadOfChannel();
            SaveLastTimeUploadOfChannel(currenIdChannel);
            ShowTheLastTime(currenIdChannel);
        }

        private void btnResetAll_Click(object sender, EventArgs e)
        {
            var listFolders = new List<string>();
            listFolders.Add(@"D:\Youtube\animalsTag");
            listFolders.Add(@"D:\Youtube\CatsFunnyAnimal");
            listFolders.Add(@"D:\Youtube\CuteGirl");
            listFolders.Add(@"D:\Youtube\viral");

            foreach (var item in listFolders )
            {
                DirectoryInfo d = new DirectoryInfo(item);
                Files = d.GetFiles("*.mp4");
                foreach (var f in Files)
                {
                    File.SetAttributes(f.FullName, FileAttributes.Normal);
                }
                if (filesSelecteds15 != null)
                {
                    filesSelecteds15.Clear();
                }
            }
        }
    }
}
