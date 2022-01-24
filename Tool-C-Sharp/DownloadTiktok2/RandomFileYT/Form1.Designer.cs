
namespace RandomFileYT
{
    partial class RandomFile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RandomFile));
            this.btnChon = new System.Windows.Forms.Button();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnExecute = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.cb15Each = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbChannel = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLastTime = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblComeBack = new System.Windows.Forms.Label();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cb10Folders = new System.Windows.Forms.CheckBox();
            this.txtChangeName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.btnSelectFolder = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.txtChangeFolder = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(490, 106);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(92, 35);
            this.btnChon.TabIndex = 0;
            this.btnChon.Text = "...";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(95, 110);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(376, 26);
            this.txtFolder.TabIndex = 1;
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(28, 214);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(135, 55);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(54, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Folder";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(446, 214);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 55);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(95, 168);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(376, 26);
            this.txtNumber.TabIndex = 5;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // cb15Each
            // 
            this.cb15Each.AutoSize = true;
            this.cb15Each.Location = new System.Drawing.Point(490, 169);
            this.cb15Each.Name = "cb15Each";
            this.cb15Each.Size = new System.Drawing.Size(92, 24);
            this.cb15Each.TabIndex = 7;
            this.cb15Each.Text = "15 each";
            this.cb15Each.UseVisualStyleBackColor = true;
            this.cb15Each.CheckedChanged += new System.EventHandler(this.cb15Each_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 171);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Number";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Channel";
            // 
            // cmbChannel
            // 
            this.cmbChannel.FormattingEnabled = true;
            this.cmbChannel.Items.AddRange(new object[] {
            "Funny smile     (viral)         -hai.nguyen0698",
            "Anmation film (CatsFunnyAnimal)    -taikhoancv1",
            "Funny animal   (CatsFunnyAnimal)    -hainguyen9x4",
            "Animal film     (animalsTag)      -taikhoancv02",
            "Hot lady         (CuteGirl)        -hai.nguyenvan0983"});
            this.cmbChannel.Location = new System.Drawing.Point(94, 17);
            this.cmbChannel.Name = "cmbChannel";
            this.cmbChannel.Size = new System.Drawing.Size(488, 28);
            this.cmbChannel.TabIndex = 9;
            this.cmbChannel.SelectedIndexChanged += new System.EventHandler(this.cmbChannel_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(237, 214);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 55);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save time";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Channel last upload time:";
            // 
            // lblLastTime
            // 
            this.lblLastTime.AutoSize = true;
            this.lblLastTime.Location = new System.Drawing.Point(218, 71);
            this.lblLastTime.Name = "lblLastTime";
            this.lblLastTime.Size = new System.Drawing.Size(33, 20);
            this.lblLastTime.TabIndex = 12;
            this.lblLastTime.Text = "--:--";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(82, 300);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(24, 20);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Status";
            // 
            // lblComeBack
            // 
            this.lblComeBack.AutoSize = true;
            this.lblComeBack.Location = new System.Drawing.Point(82, 334);
            this.lblComeBack.Name = "lblComeBack";
            this.lblComeBack.Size = new System.Drawing.Size(24, 20);
            this.lblComeBack.TabIndex = 15;
            this.lblComeBack.Text = "---";
            // 
            // btnResetAll
            // 
            this.btnResetAll.Location = new System.Drawing.Point(446, 299);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(135, 55);
            this.btnResetAll.TabIndex = 16;
            this.btnResetAll.Text = "ResetAll";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(18, 2);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(640, 417);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnChon);
            this.tabPage1.Controls.Add(this.txtFolder);
            this.tabPage1.Controls.Add(this.btnResetAll);
            this.tabPage1.Controls.Add(this.lblComeBack);
            this.tabPage1.Controls.Add(this.btnExecute);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.btnReset);
            this.tabPage1.Controls.Add(this.lblStatus);
            this.tabPage1.Controls.Add(this.txtNumber);
            this.tabPage1.Controls.Add(this.lblLastTime);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cb15Each);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.cmbChannel);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage1.Size = new System.Drawing.Size(632, 384);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Random file";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cb10Folders);
            this.tabPage2.Controls.Add(this.txtChangeName);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.btnSelectFolder);
            this.tabPage2.Controls.Add(this.txtChangeFolder);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.button8);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabPage2.Size = new System.Drawing.Size(589, 384);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Change name";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cb10Folders
            // 
            this.cb10Folders.AutoSize = true;
            this.cb10Folders.Location = new System.Drawing.Point(309, 175);
            this.cb10Folders.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cb10Folders.Name = "cb10Folders";
            this.cb10Folders.Size = new System.Drawing.Size(162, 24);
            this.cb10Folders.TabIndex = 10;
            this.cb10Folders.Text = "Create 10 Folders";
            this.cb10Folders.UseVisualStyleBackColor = true;
            // 
            // txtChangeName
            // 
            this.txtChangeName.Location = new System.Drawing.Point(100, 109);
            this.txtChangeName.Name = "txtChangeName";
            this.txtChangeName.Size = new System.Drawing.Size(301, 26);
            this.txtChangeName.TabIndex = 8;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(30, 112);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 20);
            this.label15.TabIndex = 9;
            this.label15.Text = "Name";
            // 
            // btnSelectFolder
            // 
            this.btnSelectFolder.Location = new System.Drawing.Point(430, 38);
            this.btnSelectFolder.Name = "btnSelectFolder";
            this.btnSelectFolder.Size = new System.Drawing.Size(92, 35);
            this.btnSelectFolder.TabIndex = 4;
            this.btnSelectFolder.Text = "...";
            this.btnSelectFolder.UseVisualStyleBackColor = true;
            this.btnSelectFolder.Click += new System.EventHandler(this.btnSelectFolder_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(30, 46);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 20);
            this.label14.TabIndex = 6;
            this.label14.Text = "Folder";
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(100, 175);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(135, 55);
            this.button8.TabIndex = 7;
            this.button8.Text = "Execute";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // txtChangeFolder
            // 
            this.txtChangeFolder.Location = new System.Drawing.Point(100, 40);
            this.txtChangeFolder.Name = "txtChangeFolder";
            this.txtChangeFolder.Size = new System.Drawing.Size(301, 26);
            this.txtChangeFolder.TabIndex = 5;
            // 
            // RandomFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 428);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(814, 508);
            this.MinimumSize = new System.Drawing.Size(562, 421);
            this.Name = "RandomFile";
            this.Text = "RandomFile";
            this.Load += new System.EventHandler(this.RandomFile_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.CheckBox cb15Each;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbChannel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLastTime;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblComeBack;
        private System.Windows.Forms.Button btnResetAll;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSelectFolder;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.TextBox txtChangeName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox cb10Folders;
        private System.Windows.Forms.TextBox txtChangeFolder;
    }
}

