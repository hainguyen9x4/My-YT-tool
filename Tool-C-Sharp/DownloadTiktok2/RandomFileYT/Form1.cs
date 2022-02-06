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
            //this.FormClosing += Form1_FormClosing;
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
            txtFolder.Text = ChooseFolder(txtChangeFolder.Text);
        }
        private string ChooseFolder(string pathx)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.SelectedPath = pathx;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                return folderBrowserDialog1.SelectedPath;
            }
            else
            {

            }
            return pathx;
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
            txtChangeFolder.Text = @"E:\Youtube";
            txtNumber.Text = "105";
            txtChangeName.Text = "ChangeName-";
            txtPathToMCR.Text = @"D:\Youtube\My-YT-tool\Macro-ThinkPad 100";
            cb15Each.Checked = true;
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
                    //lblLastTime.Text = saveDatas[currenIdChannel].Substring(indexOf + 1, saveDatas[currenIdChannel].Length - 1 - indexOf);
                    ShowTheLastTime(currenIdChannel);
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
            int indexOf = 0;
            for (int i = 0; i < saveDatas.Count; i++)
            {
                indexOf = saveDatas[i].IndexOf('-');
                string str = saveDatas[i].Substring(0, indexOf);
                if (int.Parse(str) == currenIdChannel)
                {
                    lblLastTime.Text = saveDatas[i].Substring(indexOf + 1, saveDatas[i].Length - 1 - indexOf);
                    break;
                }
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

        private void btnSelectFolder_Click(object sender, EventArgs e)
        {
            txtChangeFolder.Text = ChooseFolder(txtChangeFolder.Text);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DirectoryInfo d = new DirectoryInfo(txtChangeFolder.Text);

            List<FileInfo> filesSelecteds = new List<FileInfo>();
            Files = d.GetFiles("*.mp4");
            List<int> numberLists = new List<int>();
            numberLists.Clear();
            if (Files.Length > 0)
            {
                for (int i = 0; i < Files.Length; i++)
                {
                    if (Files[i].Name.Substring(0, Files[i].Name.IndexOf('-') + 1) == txtChangeName.Text)
                    {
                        MessageBox.Show("Choose other name!");
                        return;
                    }
                }
                Random rand = new Random();
                int iNumber = rand.Next(0, Files.Length);
                string strName = "";
                if (cb10Folders.Checked)
                {
                    string folderName = "";
                    for (int index = 0; index < 10; index++)
                    {
                        folderName = txtChangeName.Text + index.ToString();
                        //Create random file name
                        numberLists.Clear();
                        for (int i = 0; i < Files.Length; i++)
                        {
                            while (numberLists.Contains(iNumber))
                                iNumber = rand.Next(0, Files.Length);
                            numberLists.Add(iNumber);
                            //
                            string str = iNumber.ToString();
                            strName = txtChangeName.Text + (iNumber < 10 ? "00" + str : iNumber < 100 ? "0" + str : str);
                            //
                            if (File.Exists(Files[i].FullName))
                            {
                                string newFolderName = txtChangeFolder.Text + @"\" + folderName;
                                if (!Directory.Exists(newFolderName))
                                {
                                    System.IO.Directory.CreateDirectory(newFolderName);
                                }
                                File.Copy(Files[i].FullName, newFolderName + @"\" + strName + ".mp4", true);
                            }
                        }
                    }
                }
                else
                {
                    //Create random file name
                    for (int i = 0; i < Files.Length; i++)
                    {
                        while (numberLists.Contains(iNumber))
                            iNumber = rand.Next(0, Files.Length);
                        numberLists.Add(iNumber);
                        //
                        string str = iNumber.ToString();
                        strName = txtChangeName.Text + (iNumber < 10 ? "00" + str : iNumber < 100 ? "0" + str : str);
                        //
                        if (File.Exists(Files[i].FullName))
                        {
                            //File.Copy(Files[i].FullName, Files[i].DirectoryName + @"\" + strName + ".mp4", true);
                            System.IO.File.Move(Files[i].FullName, Files[i].DirectoryName + @"\" + strName + ".mp4");
                            File.Delete(Files[i].FullName);
                        }
                    }
                }
            }
        }

        private void btnBr2MCR_Click(object sender, EventArgs e)
        {
            txtPathToMCR.Text = ChooseFolder(txtPathToMCR.Text);
        }

        private void btnEXE2MCR_Click(object sender, EventArgs e)
        {
            //Create the locations
            Location[,] Toado = new Location[6, 7];
            int tempX = 417;
            int tempY = 241;
            for (int i = 0; i < 6; i++)//row
            {
                tempX = 417;
                for (int j = 0; j < 7; j++)//column
                {
                    Toado[i, j] = new Location(tempX, tempY);
                    tempX += 28;
                }
                tempY += 28;
            }
            // Get the number of day in month:
            int days = DateTime.DaysInMonth(dateMonth.Value.Year, dateMonth.Value.Month);
            //execute- the first
            switch ((string)cmbStart.SelectedItem)
            {
                case "T2":
                    for (int i = 0; i < 7; i++)
                    {
                        Toado[0, i] = null;
                    }
                    break;
                case "T3":
                    for (int i = 0; i < 7; i++)
                    {
                        Toado[0, i] = null;
                    }
                    Toado[1, 0] = null;
                    break;
                case "T4":
                    for (int i = 0; i < 7; i++)
                    {
                        Toado[0, i] = null;
                    }
                    Toado[1, 0] = null;
                    Toado[1, 1] = null;
                    break;
                case "T5":
                    Toado[0, 0] = null;
                    Toado[0, 1] = null;
                    Toado[0, 2] = null;
                    break;
                case "T6":
                    Toado[0, 0] = null;
                    Toado[0, 1] = null;
                    Toado[0, 2] = null;
                    Toado[0, 3] = null;
                    break;
                case "T7":
                    Toado[0, 0] = null;
                    Toado[0, 1] = null;
                    Toado[0, 2] = null;
                    Toado[0, 3] = null;
                    Toado[0, 4] = null;
                    break;
                case "CN":
                    Toado[0, 0] = null;
                    Toado[0, 1] = null;
                    Toado[0, 2] = null;
                    Toado[0, 3] = null;
                    Toado[0, 4] = null;
                    Toado[0, 5] = null;
                    break;
                default: break;
            }

            //execute- the end
            List<Location> locations = new List<Location>();
            int count = 0;
            bool isFull = false;
            for (int i = 0; i < 6; i++)//row
            {
                for (int j = 0; j < 7; j++)//column
                {
                    if (Toado[i, j] != null)
                    {
                        if (isFull)
                        {
                            Toado[i, j] = null;
                        }
                        else
                        {
                            locations.Add(Toado[i, j]);
                            count++;
                            if (count == days)
                            {
                                isFull = true;
                            }
                        }
                    }
                }
            }
            //Create files CMR
            //Create folder for month:
            string strFolder = txtPathToMCR.Text + @"\Data_Month\" + "T" + dateMonth.Value.Month.ToString() + @"\";
            if (!System.IO.Directory.Exists(strFolder))
                System.IO.Directory.CreateDirectory(strFolder);

            string path = "";
            int iTemp = 0;//row
            int jTemp = 0;//column
            for (int day = 1; day <= days; day++)
            {
                string strSaveData = "DELAY : 10" + Environment.NewLine + $"Mouse : {locations[day - 1].X} : {locations[day - 1].Y} : Click : 0 : 0 : 0" + Environment.NewLine + "DELAY : 10";
                path = strFolder + "d" + day.ToString() + ".mcr";
                File.WriteAllText(path, strSaveData);
                jTemp++;
                if (jTemp == 7)
                {
                    iTemp++;
                    jTemp = 0;
                }
            }
            //Copy file to EXE folder
            string strEXE_Folder = "";
            if (chkMove2EXE.Checked)
            {
                strEXE_Folder = txtPathToMCR.Text + @"\EXE_DAY" + @"\";
                if (!System.IO.Directory.Exists(strEXE_Folder))
                    System.IO.Directory.CreateDirectory(strEXE_Folder);
                //Copy
                Copy(strFolder, strEXE_Folder, true);

            }
            //Delete old info file.
            DirectoryInfo d = new DirectoryInfo(strEXE_Folder);
            Files = d.GetFiles("*.txt");
            foreach(var file in Files)
            {
                try
                {
                    file.Delete();
                }
                catch
                {
                    MessageBox.Show("The info file is oppen!");
                }
            }
            //Create file info

            path = strEXE_Folder + "0_Thang_" + dateMonth.Value.Month.ToString() + "info.txt";
            string strInfoData = "Thang_" + dateMonth.Value.Month.ToString();
            File.WriteAllText(path, strInfoData);
        }
        void Copy(string sourceDir, string targetDir, bool isOverwrite = false)
        {
            foreach (var file in Directory.GetFiles(sourceDir))
                File.Copy(file, Path.Combine(targetDir, Path.GetFileName(file)), isOverwrite);

            foreach (var directory in Directory.GetDirectories(sourceDir))
                Copy(directory, Path.Combine(targetDir, Path.GetFileName(directory)), isOverwrite);
        }

    }
    public class Location
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Location(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
