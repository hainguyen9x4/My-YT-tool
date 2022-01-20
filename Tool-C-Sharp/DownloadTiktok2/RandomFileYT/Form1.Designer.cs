
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnExecute = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb15Each = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbChannel = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.lblLastTime = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblComeBack = new System.Windows.Forms.Label();
            this.btnResetAll = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(421, 122);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(92, 35);
            this.btnChon.TabIndex = 0;
            this.btnChon.Text = "...";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(91, 126);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(301, 26);
            this.txtFolder.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Folder";
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(25, 224);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(135, 56);
            this.btnExecute.TabIndex = 3;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(375, 224);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(135, 56);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(91, 179);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(301, 26);
            this.txtNumber.TabIndex = 5;
            this.txtNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumber_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Number";
            // 
            // cb15Each
            // 
            this.cb15Each.AutoSize = true;
            this.cb15Each.Location = new System.Drawing.Point(421, 180);
            this.cb15Each.Name = "cb15Each";
            this.cb15Each.Size = new System.Drawing.Size(92, 24);
            this.cb15Each.TabIndex = 7;
            this.cb15Each.Text = "15 each";
            this.cb15Each.UseVisualStyleBackColor = true;
            this.cb15Each.CheckedChanged += new System.EventHandler(this.cb15Each_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Channel";
            // 
            // cmbChannel
            // 
            this.cmbChannel.FormattingEnabled = true;
            this.cmbChannel.Items.AddRange(new object[] {
            "Funny smile (viral) -hai.nguyen0698",
            "Anmation film (CatsFunnyAnimal) -taikhoancv1",
            "Funny animal (CatsFunnyAnimal) -hainguyen9x4",
            "Animal film (animalsTag) -taikhoancv02",
            "Hot lady (CuteGirl) -hai.nguyenvan0983"});
            this.cmbChannel.Location = new System.Drawing.Point(91, 27);
            this.cmbChannel.Name = "cmbChannel";
            this.cmbChannel.Size = new System.Drawing.Size(419, 28);
            this.cmbChannel.TabIndex = 9;
            this.cmbChannel.SelectedIndexChanged += new System.EventHandler(this.cmbChannel_SelectedIndexChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 56);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save time";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Channel last upload time:";
            // 
            // lblLastTime
            // 
            this.lblLastTime.AutoSize = true;
            this.lblLastTime.Location = new System.Drawing.Point(214, 81);
            this.lblLastTime.Name = "lblLastTime";
            this.lblLastTime.Size = new System.Drawing.Size(33, 20);
            this.lblLastTime.TabIndex = 12;
            this.lblLastTime.Text = "--:--";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Location = new System.Drawing.Point(79, 311);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(24, 20);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "---";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(21, 311);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Status";
            // 
            // lblComeBack
            // 
            this.lblComeBack.AutoSize = true;
            this.lblComeBack.Location = new System.Drawing.Point(79, 345);
            this.lblComeBack.Name = "lblComeBack";
            this.lblComeBack.Size = new System.Drawing.Size(24, 20);
            this.lblComeBack.TabIndex = 15;
            this.lblComeBack.Text = "---";
            // 
            // btnResetAll
            // 
            this.btnResetAll.Location = new System.Drawing.Point(375, 293);
            this.btnResetAll.Name = "btnResetAll";
            this.btnResetAll.Size = new System.Drawing.Size(135, 56);
            this.btnResetAll.TabIndex = 16;
            this.btnResetAll.Text = "ResetAll";
            this.btnResetAll.UseVisualStyleBackColor = true;
            this.btnResetAll.Click += new System.EventHandler(this.btnResetAll_Click);
            // 
            // RandomFile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 374);
            this.Controls.Add(this.btnResetAll);
            this.Controls.Add(this.lblComeBack);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblLastTime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cmbChannel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb15Each);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNumber);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnExecute);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.btnChon);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(565, 430);
            this.MinimumSize = new System.Drawing.Size(565, 430);
            this.Name = "RandomFile";
            this.Text = "RandomFile";
            this.Load += new System.EventHandler(this.RandomFile_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExecute;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb15Each;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbChannel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblLastTime;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblComeBack;
        private System.Windows.Forms.Button btnResetAll;
    }
}

