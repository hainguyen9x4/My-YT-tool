
namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.txtFolderPath = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtThread = new System.Windows.Forms.TextBox();
            this.lblDelay = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDelay = new System.Windows.Forms.TextBox();
            this.lblErrorNum = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtStartNum = new System.Windows.Forms.TextBox();
            this.lblDownloaded = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rdiTiktok = new System.Windows.Forms.RadioButton();
            this.rdioYouTube = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.rdio3 = new System.Windows.Forms.RadioButton();
            this.rdio12 = new System.Windows.Forms.RadioButton();
            this.rdio1 = new System.Windows.Forms.RadioButton();
            this.txtSplitData = new System.Windows.Forms.TextBox();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblNumberLink = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAnalyse = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(16, 65);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(787, 205);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(286, 183);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(517, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Download";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "List Link:";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(101, 29);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(206, 26);
            this.txtFileName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "File Name";
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(751, 92);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(52, 35);
            this.btnBrowser.TabIndex = 5;
            this.btnBrowser.Text = "...";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // txtFolderPath
            // 
            this.txtFolderPath.Location = new System.Drawing.Point(14, 97);
            this.txtFolderPath.Name = "txtFolderPath";
            this.txtFolderPath.Size = new System.Drawing.Size(720, 26);
            this.txtFolderPath.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Save To Folder";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtThread);
            this.groupBox1.Controls.Add(this.lblDelay);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtDelay);
            this.groupBox1.Controls.Add(this.lblErrorNum);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtStartNum);
            this.groupBox1.Controls.Add(this.lblDownloaded);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtFileName);
            this.groupBox1.Controls.Add(this.btnBrowser);
            this.groupBox1.Controls.Add(this.txtFolderPath);
            this.groupBox1.Location = new System.Drawing.Point(12, 434);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(817, 228);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 195);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(121, 20);
            this.label8.TabIndex = 16;
            this.label8.Text = "Thread number:";
            // 
            // txtThread
            // 
            this.txtThread.Location = new System.Drawing.Point(150, 192);
            this.txtThread.Name = "txtThread";
            this.txtThread.Size = new System.Drawing.Size(92, 26);
            this.txtThread.TabIndex = 15;
            // 
            // lblDelay
            // 
            this.lblDelay.AutoSize = true;
            this.lblDelay.ForeColor = System.Drawing.Color.Red;
            this.lblDelay.Location = new System.Drawing.Point(701, 142);
            this.lblDelay.Name = "lblDelay";
            this.lblDelay.Size = new System.Drawing.Size(24, 20);
            this.lblDelay.TabIndex = 14;
            this.lblDelay.Text = "---";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(301, 142);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(182, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Delay each download(s):";
            // 
            // txtDelay
            // 
            this.txtDelay.Location = new System.Drawing.Point(489, 136);
            this.txtDelay.Name = "txtDelay";
            this.txtDelay.Size = new System.Drawing.Size(206, 26);
            this.txtDelay.TabIndex = 12;
            this.txtDelay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDelay_KeyPress);
            // 
            // lblErrorNum
            // 
            this.lblErrorNum.AutoSize = true;
            this.lblErrorNum.ForeColor = System.Drawing.Color.Red;
            this.lblErrorNum.Location = new System.Drawing.Point(548, 31);
            this.lblErrorNum.Name = "lblErrorNum";
            this.lblErrorNum.Size = new System.Drawing.Size(24, 20);
            this.lblErrorNum.TabIndex = 11;
            this.lblErrorNum.Text = "---";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(338, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Start number:";
            // 
            // txtStartNum
            // 
            this.txtStartNum.Location = new System.Drawing.Point(450, 28);
            this.txtStartNum.Name = "txtStartNum";
            this.txtStartNum.Size = new System.Drawing.Size(92, 26);
            this.txtStartNum.TabIndex = 9;
            this.txtStartNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStartNum_KeyPress);
            // 
            // lblDownloaded
            // 
            this.lblDownloaded.AutoSize = true;
            this.lblDownloaded.Location = new System.Drawing.Point(177, 142);
            this.lblDownloaded.Name = "lblDownloaded";
            this.lblDownloaded.Size = new System.Drawing.Size(18, 20);
            this.lblDownloaded.TabIndex = 8;
            this.lblDownloaded.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(159, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Number downloaded:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.btnClear);
            this.groupBox2.Controls.Add(this.lblNumberLink);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.btnAnalyse);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(817, 415);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Input";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rdiTiktok);
            this.groupBox4.Controls.Add(this.rdioYouTube);
            this.groupBox4.Location = new System.Drawing.Point(19, 314);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(240, 95);
            this.groupBox4.TabIndex = 19;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Source Selection:";
            // 
            // rdiTiktok
            // 
            this.rdiTiktok.AutoSize = true;
            this.rdiTiktok.Location = new System.Drawing.Point(8, 61);
            this.rdiTiktok.Name = "rdiTiktok";
            this.rdiTiktok.Size = new System.Drawing.Size(76, 24);
            this.rdiTiktok.TabIndex = 17;
            this.rdiTiktok.Text = "Tiktok";
            this.rdiTiktok.UseVisualStyleBackColor = true;
            // 
            // rdioYouTube
            // 
            this.rdioYouTube.AutoSize = true;
            this.rdioYouTube.Checked = true;
            this.rdioYouTube.Location = new System.Drawing.Point(8, 27);
            this.rdioYouTube.Name = "rdioYouTube";
            this.rdioYouTube.Size = new System.Drawing.Size(99, 24);
            this.rdioYouTube.TabIndex = 16;
            this.rdioYouTube.TabStop = true;
            this.rdioYouTube.Text = "YouTube";
            this.rdioYouTube.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.rdio3);
            this.groupBox3.Controls.Add(this.rdio12);
            this.groupBox3.Controls.Add(this.rdio1);
            this.groupBox3.Controls.Add(this.txtSplitData);
            this.groupBox3.Location = new System.Drawing.Point(278, 276);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(240, 131);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Split Selection:";
            // 
            // rdio3
            // 
            this.rdio3.AutoSize = true;
            this.rdio3.Location = new System.Drawing.Point(8, 95);
            this.rdio3.Name = "rdio3";
            this.rdio3.Size = new System.Drawing.Size(109, 24);
            this.rdio3.TabIndex = 18;
            this.rdio3.Text = "Other char";
            this.rdio3.UseVisualStyleBackColor = true;
            this.rdio3.CheckedChanged += new System.EventHandler(this.rdio3_CheckedChanged);
            // 
            // rdio12
            // 
            this.rdio12.AutoSize = true;
            this.rdio12.Location = new System.Drawing.Point(8, 61);
            this.rdio12.Name = "rdio12";
            this.rdio12.Size = new System.Drawing.Size(97, 24);
            this.rdio12.TabIndex = 17;
            this.rdio12.Text = "(newline)";
            this.rdio12.UseVisualStyleBackColor = true;
            // 
            // rdio1
            // 
            this.rdio1.AutoSize = true;
            this.rdio1.Checked = true;
            this.rdio1.Location = new System.Drawing.Point(8, 27);
            this.rdio1.Name = "rdio1";
            this.rdio1.Size = new System.Drawing.Size(48, 24);
            this.rdio1.TabIndex = 16;
            this.rdio1.TabStop = true;
            this.rdio1.Text = "(;)";
            this.rdio1.UseVisualStyleBackColor = true;
            // 
            // txtSplitData
            // 
            this.txtSplitData.Location = new System.Drawing.Point(123, 94);
            this.txtSplitData.MaxLength = 1;
            this.txtSplitData.Name = "txtSplitData";
            this.txtSplitData.Size = new System.Drawing.Size(111, 26);
            this.txtSplitData.TabIndex = 12;
            this.txtSplitData.Click += new System.EventHandler(this.txtSplitData_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(676, 361);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 35);
            this.btnClear.TabIndex = 12;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblNumberLink
            // 
            this.lblNumberLink.AutoSize = true;
            this.lblNumberLink.Location = new System.Drawing.Point(130, 283);
            this.lblNumberLink.Name = "lblNumberLink";
            this.lblNumberLink.Size = new System.Drawing.Size(18, 20);
            this.lblNumberLink.TabIndex = 11;
            this.lblNumberLink.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 283);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(114, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Number of link:";
            // 
            // btnAnalyse
            // 
            this.btnAnalyse.Location = new System.Drawing.Point(528, 361);
            this.btnAnalyse.Name = "btnAnalyse";
            this.btnAnalyse.Size = new System.Drawing.Size(127, 35);
            this.btnAnalyse.TabIndex = 9;
            this.btnAnalyse.Text = "Analyse";
            this.btnAnalyse.UseVisualStyleBackColor = true;
            this.btnAnalyse.Click += new System.EventHandler(this.btnAnalyse_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 681);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "DowloadTiktok";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.TextBox txtFolderPath;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDownloaded;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblNumberLink;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAnalyse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtStartNum;
        private System.Windows.Forms.Label lblErrorNum;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtSplitData;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rdio3;
        private System.Windows.Forms.RadioButton rdio12;
        private System.Windows.Forms.RadioButton rdio1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDelay;
        private System.Windows.Forms.Label lblDelay;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rdiTiktok;
        private System.Windows.Forms.RadioButton rdioYouTube;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtThread;
    }
}

