using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        private const string URL = "https://www.tikwm.com/api/";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fileName = !String.IsNullOrEmpty(txtFileName.Text) ? txtFileName.Text : "Funny-Cute";
            string location = @"D:/" + fileName + "_" + DateTime.Now.ToString("MMddyyyy_h-mmtt") + @"/";
            if (!String.IsNullOrEmpty(txtFolderPath.Text))
            {
                location = txtFolderPath.Text + @"\";
            }
            bool exists = System.IO.Directory.Exists(location);

            if (!exists)
            {
                try
                {
                    System.IO.Directory.CreateDirectory(location);
                    exists = true;
                }
                catch
                {
                    MessageBox.Show("Can't create new folder with fultt path:" + location);
                }
            }
            if (exists)
            {
                if (rdiTiktok.Checked)
                {
                    DownloadFileTitok(richTextBox1.Text, location, fileName);
                }
                else if (rdioYouTube.Checked)
                {
                    var numThread = int.Parse(txtThread.Text);
                    DownloadFileYouTube2(richTextBox1.Text, location, fileName, numThread);
                }
            }
        }
        private void DownloadFileTitok(string text, string location, string fileName)
        {
            string urls = text;
            char splitChar;
            if(GetSplitChar(out splitChar))
            {
                List<string> listUrls = urls.Split(splitChar).ToList();
                int index = int.Parse(String.IsNullOrEmpty(txtStartNum.Text) ? "0" : txtStartNum.Text);
                foreach (var url in listUrls)
                {
                    string URLx = URL + "?url=" + url;
                    if (!String.IsNullOrEmpty(url))
                    {
                        HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URLx);
                        request.Method = "POST";
                        request.ContentType = "application/json";
                        using (Stream webStream = request.GetRequestStream())
                        using (StreamWriter requestWriter = new StreamWriter(webStream, System.Text.Encoding.ASCII))
                        {

                        }
                        try
                        {
                            WebResponse webResponse = request.GetResponse();
                            using (Stream webStream = webResponse.GetResponseStream() ?? Stream.Null)
                            using (StreamReader responseReader = new StreamReader(webStream))
                            {
                                string response = responseReader.ReadToEnd();
                                var result = JsonConvert.DeserializeObject<Tiktok>(response);
                                Console.WriteLine();
                                if (result.Data != null && !String.IsNullOrEmpty(result.Data.Play))
                                {
                                    //Luu ve may
                                    using (var client = new WebClient())
                                    {
                                        var name = location + fileName + "_" + index.ToString() + ".mp4";
                                        client.DownloadFile(result.Data.Play, name);
                                    }
                                }
                                else
                                {
                                    Console.Out.WriteLine("----Download fail--------");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            Console.Out.WriteLine("-----------------");
                            Console.Out.WriteLine(ex.Message);

                        }
                    }
                    lblDownloaded.Text = index.ToString();
                    if (index == listUrls.Count)
                    {
                        MessageBox.Show($"End!\n\r Downloaded {index} files");
                    }
                    Thread.Sleep(int.Parse(txtDelay.Text));
                    index++;
                }
            }
        }
        private void DownloadFileYouTube(string text, string location, string fileName, int numThread)
        {
            string urls = text;
            char splitChar;
            if (GetSplitChar(out splitChar))
            {
                string replacement = Regex.Replace(urls, @"\t|\n|\r", "");
                List<string> listUrls = replacement.Split(splitChar).ToList();
                int index = int.Parse(String.IsNullOrEmpty(txtStartNum.Text) ? "0" : txtStartNum.Text);

                List<Thread> listThred = new List<Thread>();
                for (var i = 0; i < numThread; i++)
                {
                    Thread t1 = new Thread(() => { });
                    t1.Name = "Thread" + (i + 1).ToString();
                    listThred.Add(t1);
                }
                foreach (var url in listUrls)
                {
                    if (string.IsNullOrEmpty(url))
                    {
                        continue;
                    }
                    bool hasFree = false;
                    var thred = CheckFreeThread2(listThred, out hasFree);
                    index++;
                    if (hasFree)
                    {
                        thred = new Thread(() => Work(index, location, fileName, url));
                        thred.Start();
                    }
                    else
                    {
                        Thread.Sleep(int.Parse(txtDelay.Text));
                        using (var client = new WebClient())
                        {

                            string urlxx = ConvertLinkYouTubeToLinkDraw(url);
                            var name = location + fileName + "_" + index.ToString() + ".mp4";
                            try
                            {
                                client.DownloadFile(urlxx, name);
                            }
                            catch
                            {

                            }
                        }
                    }

                }
            }
        }
        private void DownloadFileYouTube2(string text, string location, string fileName, int numThread)
        {
            string urls = text;
            char splitChar;
            if (GetSplitChar(out splitChar))
            {
                string replacement = Regex.Replace(urls, @"\t|\n|\r", "");
                List<string> listUrls = replacement.Split(splitChar).ToList();
                int index = int.Parse(String.IsNullOrEmpty(txtStartNum.Text) ? "0" : txtStartNum.Text);

                List<Thread> listThred = new List<Thread>();
                for (var i = 0; i < numThread; i++)
                {
                    Thread t1 = new Thread(() => { });
                    listThred.Add(t1);
                }
                var listDrawVideos = new List<String>();
                foreach (var url in listUrls)
                {
                    if (string.IsNullOrEmpty(url))
                    {
                        continue;
                    }
                    //Thread.Sleep(int.Parse(txtDelay.Text));
                    string urlxx = ConvertLinkYouTubeToLinkDraw(url);
                    if (!String.IsNullOrEmpty(urlxx))
                    {
                        listDrawVideos.Add(urlxx);
                    }
                    else
                    {
                        continue;
                    }
                    bool b = false;
                    Thread thred = CheckFreeThread2(listThred, out b);
                    string name = location + fileName + "_" + index.ToString() + ".mp4";
                    if (b)
                    {
                        thred = new Thread(() => Work2(urlxx, name, index));
                        thred.Start();
                    }
                    else
                    {
                        Work2(urlxx, name, index);
                        Thread.Sleep(int.Parse(txtDelay.Text));
                    }
                    index++;
                }
            }
        }
        private string ConvertLinkYouTubeToLinkDraw(string urlYoutube)
        {
            string urlAPT = @"https://api.youtubemultidownloader.com/video?url=";
            string url = urlAPT + urlYoutube;
            string ret = "";
            if (!String.IsNullOrEmpty(url))
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
                request.Method = "POST";
                request.ContentType = "application/json";
                //request.ContentLength = DATA.Length;
                StreamWriter requestWriter = new StreamWriter(request.GetRequestStream(), System.Text.Encoding.ASCII);
                //requestWriter.Write(DATA);
                requestWriter.Close();

                try
                {
                    WebResponse webResponse = request.GetResponse();
                    Stream webStream = webResponse.GetResponseStream();
                    StreamReader responseReader = new StreamReader(webStream);
                    string response = responseReader.ReadToEnd();
                    
                    var result = JsonConvert.DeserializeObject<YouTube>(response);
                    if (result != null && result.format != null && result.format[0] != null)
                    {
                        if (!String.IsNullOrEmpty(result.format[0].url))
                        {
                            ret = result.format[0].url;
                        }
                        else if (!String.IsNullOrEmpty(result.format[0].manifestUrl))
                        {
                            ret = result.format[0].manifestUrl;
                        }
                    }
                    responseReader.Close();
                }
                catch (Exception e)
                {
                    Console.Out.WriteLine("-----------------");
                    Console.Out.WriteLine(e.Message);
                }
            }
            return ret;
        }
        private void Work(object index, object location, object fileName, object url)
        {
            using (var client = new WebClient())
            {
                string urlxx = ConvertLinkYouTubeToLinkDraw((string)url);
                string name = (string)location + (string)fileName + "_" + ((int)index).ToString() + ".mp4";
                try
                {
                    client.DownloadFile(urlxx, name);
                }
                catch
                {

                }
                Thread.Sleep(int.Parse(txtDelay.Text));
            }
        }
        private void Work2(string urlxx,string name, int index)
        {
            using (var client = new WebClient())
            {
                try
                {
                    client.DownloadFile(urlxx, name);
                    if (lblDownloaded.InvokeRequired)
                    {
                        lblDownloaded.Invoke(new MethodInvoker(() =>
                        {
                            lblDownloaded.Text = index.ToString();
                        }));
                    }
                    else
                    {
                        lblDownloaded.Text = index.ToString();
                    }
                }
                catch
                {
                    Console.WriteLine("--Fail---");
                    Console.WriteLine(urlxx);
                }
                Thread.Sleep(int.Parse(txtDelay.Text));
            }
        }
        private bool CheckFileExist(string path)
        {
            return File.Exists(path);
        }
        private Thread CheckFreeThread(Thread t1, Thread t2, Thread t3, Thread t4, Thread t5, out bool  hasFree)
        {
            hasFree = true;
            if (t1 == null || t1.ThreadState == ThreadState.Stopped)
            {
                return t1;
            }
            if (t2 == null || t2.ThreadState == ThreadState.Stopped)
            {
                return t2;
            }
            if (t3 == null || t3.ThreadState == ThreadState.Stopped)
            {
                return t3;
            }
            if (t4 == null || t4.ThreadState == ThreadState.Stopped)
            {
                return t4;
            }
            if (t5 == null || t5.ThreadState == ThreadState.Stopped)
            {
                return t5;
            }
            hasFree = false;
            return null;
        }
        private Thread CheckFreeThread2(List<Thread> threds, out bool hasFree)
        {
            hasFree = true;
            foreach(var t in threds)
            {
                if (t == null || t.ThreadState == ThreadState.Stopped || t.ThreadState == ThreadState.Unstarted)
                {
                    return t;
                }
            }
            hasFree = false;
            return null;
        }
        private string ChooseFolder()
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            folderBrowserDialog1.SelectedPath = txtFolderPath.Text;
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                return folderBrowserDialog1.SelectedPath;
            }
            else
            {

            }
            return txtFolderPath.Text;
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            txtFolderPath.Text = ChooseFolder();
        }

        private void btnAnalyse_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(richTextBox1.Text))
            {
                char x = ';';
                if (GetSplitChar(out x))
                {
                    List<string> listUrls = richTextBox1.Text.Split(x).ToList();
                    lblNumberLink.Text = listUrls.Count.ToString();
                }
            }
        }
        private bool GetSplitChar(out char x)
        {
            x = ';';
            if(rdio3.Checked && String.IsNullOrEmpty(txtSplitData.Text))
            {
                txtSplitData.BackColor = Color.Red;
                MessageBox.Show("Enter the split char!");
                return false;
            }
            x = rdio1.Checked ? ';' : rdio12.Checked ? '\n' : txtSplitData.Text[0];
            return true;
        }
        private void txtStartNum_KeyPress(object sender, KeyPressEventArgs e)
        {   
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
                lblErrorNum.Text = "Enter number only!";
            }
            else
            {
                e.Handled = false;
                lblErrorNum.Text = "";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
        }

        private void txtSplitData_Click(object sender, EventArgs e)
        {
            txtSplitData.BackColor = Color.White;
        }

        private void rdio3_CheckedChanged(object sender, EventArgs e)
        {
            if (!rdio3.Checked)
            {
                txtSplitData.BackColor = Color.White;
            }
        }

        private void txtDelay_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {

                e.Handled = true;
                lblDelay.Text = "Enter number only!";
            }
            else
            {
                e.Handled = false;
                lblDelay.Text = "";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtDelay.Text = "1000";
            txtFolderPath.Text = @"D:\Youtube\";
            txtFileName.Text = "Funny-Cute";
            txtStartNum.Text = "1";
            txtThread.Text = "5";
        }
    }
    [Serializable]
    public class Tiktok
    {
        public Data Data { get; set; }
    }
    public class Data
    {
        public string Play { get; set; }
    }
    //
    [Serializable]
    public class YouTube
    {
        public List<YTDataVideo> format { get; set; }
    }
    public class YTDataVideo
    {
       // public int id { get; set; }
        //public int height { get; set; }
        //public int width { get; set; }
        //public int size { get; set; }
        public string url { get; set; }
        public string manifestUrl { get; set; }
    }
}
