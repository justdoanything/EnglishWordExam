namespace HelloEnglishTeacher
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.OpenFile = new System.Windows.Forms.OpenFileDialog();
            this.btnFileSearch = new System.Windows.Forms.Button();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.picContact = new System.Windows.Forms.PictureBox();
            this.picCheck1 = new System.Windows.Forms.PictureBox();
            this.picXbutton = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelVersion = new System.Windows.Forms.Label();
            this.panelExam = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtExamStart = new System.Windows.Forms.TextBox();
            this.txtExamEnd = new System.Windows.Forms.TextBox();
            this.picDot2 = new System.Windows.Forms.PictureBox();
            this.labelExamNum = new System.Windows.Forms.Label();
            this.picDot1 = new System.Windows.Forms.PictureBox();
            this.labelExamType = new System.Windows.Forms.Label();
            this.comboBoxExamType = new System.Windows.Forms.ComboBox();
            this.LabelFirstWord = new System.Windows.Forms.Label();
            this.chkBoxFirstWord = new System.Windows.Forms.CheckBox();
            this.txtExamNum = new System.Windows.Forms.TextBox();
            this.chkMakeExam = new System.Windows.Forms.CheckBox();
            this.labelMakeExam = new System.Windows.Forms.Label();
            this.Worker = new System.ComponentModel.BackgroundWorker();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxExamType2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXbutton)).BeginInit();
            this.panelExam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDot2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDot1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // OpenFile
            // 
            this.OpenFile.Filter = "Excel Files|*.xlsx;*.csv;*.xls|모든 파일|*.*";
            // 
            // btnFileSearch
            // 
            this.btnFileSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFileSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFileSearch.Location = new System.Drawing.Point(242, 16);
            this.btnFileSearch.Name = "btnFileSearch";
            this.btnFileSearch.Size = new System.Drawing.Size(55, 23);
            this.btnFileSearch.TabIndex = 0;
            this.btnFileSearch.Text = "Open";
            this.btnFileSearch.UseVisualStyleBackColor = true;
            this.btnFileSearch.Click += new System.EventHandler(this.btnFileSearch_Click);
            // 
            // txtFilePath
            // 
            this.txtFilePath.BackColor = System.Drawing.SystemColors.Window;
            this.txtFilePath.Enabled = false;
            this.txtFilePath.Location = new System.Drawing.Point(12, 15);
            this.txtFilePath.Multiline = true;
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(210, 23);
            this.txtFilePath.TabIndex = 1;
            this.txtFilePath.TabStop = false;
            // 
            // picContact
            // 
            this.picContact.BackColor = System.Drawing.Color.Transparent;
            this.picContact.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picContact.BackgroundImage")));
            this.picContact.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picContact.Location = new System.Drawing.Point(314, 211);
            this.picContact.Name = "picContact";
            this.picContact.Size = new System.Drawing.Size(33, 30);
            this.picContact.TabIndex = 14;
            this.picContact.TabStop = false;
            this.picContact.Click += new System.EventHandler(this.picContact_Click);
            // 
            // picCheck1
            // 
            this.picCheck1.BackgroundImage = global::HelloEnglishTeacher.Properties.Resources.check;
            this.picCheck1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picCheck1.Location = new System.Drawing.Point(34, 201);
            this.picCheck1.Name = "picCheck1";
            this.picCheck1.Size = new System.Drawing.Size(24, 22);
            this.picCheck1.TabIndex = 3;
            this.picCheck1.TabStop = false;
            this.picCheck1.Visible = false;
            // 
            // picXbutton
            // 
            this.picXbutton.BackColor = System.Drawing.Color.White;
            this.picXbutton.BackgroundImage = global::HelloEnglishTeacher.Properties.Resources.x_blue;
            this.picXbutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picXbutton.Location = new System.Drawing.Point(327, 16);
            this.picXbutton.Name = "picXbutton";
            this.picXbutton.Size = new System.Drawing.Size(20, 20);
            this.picXbutton.TabIndex = 2;
            this.picXbutton.TabStop = false;
            this.picXbutton.Click += new System.EventHandler(this.picXbutton_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(3, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(355, 20);
            this.label1.TabIndex = 24;
            this.label1.Text = "파일 쓰기 완료 ! 파일을 열어서 확인하세요.";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVersion
            // 
            this.labelVersion.AutoSize = true;
            this.labelVersion.BackColor = System.Drawing.Color.Transparent;
            this.labelVersion.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelVersion.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.labelVersion.Location = new System.Drawing.Point(314, 244);
            this.labelVersion.Name = "labelVersion";
            this.labelVersion.Size = new System.Drawing.Size(31, 12);
            this.labelVersion.TabIndex = 25;
            this.labelVersion.Text = "v2.5";
            // 
            // panelExam
            // 
            this.panelExam.BackColor = System.Drawing.Color.Transparent;
            this.panelExam.Controls.Add(this.pictureBox2);
            this.panelExam.Controls.Add(this.label2);
            this.panelExam.Controls.Add(this.comboBoxExamType2);
            this.panelExam.Controls.Add(this.label4);
            this.panelExam.Controls.Add(this.pictureBox1);
            this.panelExam.Controls.Add(this.label3);
            this.panelExam.Controls.Add(this.txtExamStart);
            this.panelExam.Controls.Add(this.txtExamEnd);
            this.panelExam.Controls.Add(this.picDot2);
            this.panelExam.Controls.Add(this.labelExamNum);
            this.panelExam.Controls.Add(this.picDot1);
            this.panelExam.Controls.Add(this.labelExamType);
            this.panelExam.Controls.Add(this.comboBoxExamType);
            this.panelExam.Controls.Add(this.LabelFirstWord);
            this.panelExam.Controls.Add(this.chkBoxFirstWord);
            this.panelExam.Controls.Add(this.txtExamNum);
            this.panelExam.Location = new System.Drawing.Point(4, 72);
            this.panelExam.Name = "panelExam";
            this.panelExam.Size = new System.Drawing.Size(354, 102);
            this.panelExam.TabIndex = 31;
            this.panelExam.Tag = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(295, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 12);
            this.label4.TabIndex = 43;
            this.label4.Text = "~";
            this.label4.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::HelloEnglishTeacher.Properties.Resources.dot;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Location = new System.Drawing.Point(12, 60);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(10, 10);
            this.pictureBox1.TabIndex = 42;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(30, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 12);
            this.label3.TabIndex = 41;
            this.label3.Text = "문제 개수";
            // 
            // txtExamStart
            // 
            this.txtExamStart.Location = new System.Drawing.Point(255, 63);
            this.txtExamStart.Name = "txtExamStart";
            this.txtExamStart.Size = new System.Drawing.Size(38, 21);
            this.txtExamStart.TabIndex = 40;
            this.txtExamStart.Visible = false;
            this.txtExamStart.TextChanged += new System.EventHandler(this.txtExamStart_TextChanged);
            this.txtExamStart.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExamStart_KeyPress);
            // 
            // txtExamEnd
            // 
            this.txtExamEnd.Location = new System.Drawing.Point(310, 63);
            this.txtExamEnd.Name = "txtExamEnd";
            this.txtExamEnd.Size = new System.Drawing.Size(38, 21);
            this.txtExamEnd.TabIndex = 39;
            this.txtExamEnd.Visible = false;
            this.txtExamEnd.TextChanged += new System.EventHandler(this.txtExamEnd_TextChanged);
            this.txtExamEnd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExamEnd_KeyPress);
            // 
            // picDot2
            // 
            this.picDot2.BackColor = System.Drawing.Color.Transparent;
            this.picDot2.BackgroundImage = global::HelloEnglishTeacher.Properties.Resources.dot;
            this.picDot2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picDot2.Location = new System.Drawing.Point(174, 69);
            this.picDot2.Name = "picDot2";
            this.picDot2.Size = new System.Drawing.Size(10, 10);
            this.picDot2.TabIndex = 38;
            this.picDot2.TabStop = false;
            this.picDot2.Visible = false;
            // 
            // labelExamNum
            // 
            this.labelExamNum.AutoSize = true;
            this.labelExamNum.BackColor = System.Drawing.Color.Transparent;
            this.labelExamNum.Location = new System.Drawing.Point(192, 69);
            this.labelExamNum.Name = "labelExamNum";
            this.labelExamNum.Size = new System.Drawing.Size(57, 12);
            this.labelExamNum.TabIndex = 37;
            this.labelExamNum.Text = "문제 범위";
            this.labelExamNum.Visible = false;
            // 
            // picDot1
            // 
            this.picDot1.BackColor = System.Drawing.Color.Transparent;
            this.picDot1.BackgroundImage = global::HelloEnglishTeacher.Properties.Resources.dot;
            this.picDot1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picDot1.Location = new System.Drawing.Point(12, 10);
            this.picDot1.Name = "picDot1";
            this.picDot1.Size = new System.Drawing.Size(10, 10);
            this.picDot1.TabIndex = 36;
            this.picDot1.TabStop = false;
            // 
            // labelExamType
            // 
            this.labelExamType.AutoSize = true;
            this.labelExamType.BackColor = System.Drawing.Color.Transparent;
            this.labelExamType.Location = new System.Drawing.Point(30, 8);
            this.labelExamType.Name = "labelExamType";
            this.labelExamType.Size = new System.Drawing.Size(57, 12);
            this.labelExamType.TabIndex = 35;
            this.labelExamType.Text = "시험 유형";
            // 
            // comboBoxExamType
            // 
            this.comboBoxExamType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxExamType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExamType.FormattingEnabled = true;
            this.comboBoxExamType.Location = new System.Drawing.Point(99, 2);
            this.comboBoxExamType.Name = "comboBoxExamType";
            this.comboBoxExamType.Size = new System.Drawing.Size(156, 20);
            this.comboBoxExamType.TabIndex = 33;
            this.comboBoxExamType.SelectedIndexChanged += new System.EventHandler(this.comboBoxExamType_SelectedIndexChanged);
            // 
            // LabelFirstWord
            // 
            this.LabelFirstWord.AutoSize = true;
            this.LabelFirstWord.BackColor = System.Drawing.Color.Transparent;
            this.LabelFirstWord.Enabled = false;
            this.LabelFirstWord.Location = new System.Drawing.Point(30, 80);
            this.LabelFirstWord.Name = "LabelFirstWord";
            this.LabelFirstWord.Size = new System.Drawing.Size(93, 12);
            this.LabelFirstWord.TabIndex = 32;
            this.LabelFirstWord.Text = "첫글자 보여주기";
            // 
            // chkBoxFirstWord
            // 
            this.chkBoxFirstWord.AutoSize = true;
            this.chkBoxFirstWord.Enabled = false;
            this.chkBoxFirstWord.Location = new System.Drawing.Point(11, 79);
            this.chkBoxFirstWord.Name = "chkBoxFirstWord";
            this.chkBoxFirstWord.Size = new System.Drawing.Size(15, 14);
            this.chkBoxFirstWord.TabIndex = 31;
            this.chkBoxFirstWord.UseVisualStyleBackColor = true;
            // 
            // txtExamNum
            // 
            this.txtExamNum.Location = new System.Drawing.Point(99, 53);
            this.txtExamNum.Name = "txtExamNum";
            this.txtExamNum.Size = new System.Drawing.Size(38, 21);
            this.txtExamNum.TabIndex = 34;
            this.txtExamNum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExamNum_KeyPress);
            // 
            // chkMakeExam
            // 
            this.chkMakeExam.AutoSize = true;
            this.chkMakeExam.Checked = true;
            this.chkMakeExam.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMakeExam.Location = new System.Drawing.Point(14, 57);
            this.chkMakeExam.Name = "chkMakeExam";
            this.chkMakeExam.Size = new System.Drawing.Size(15, 14);
            this.chkMakeExam.TabIndex = 46;
            this.chkMakeExam.UseVisualStyleBackColor = true;
            this.chkMakeExam.CheckedChanged += new System.EventHandler(this.chkMakeExam_CheckedChanged);
            // 
            // labelMakeExam
            // 
            this.labelMakeExam.AutoSize = true;
            this.labelMakeExam.BackColor = System.Drawing.Color.Transparent;
            this.labelMakeExam.Location = new System.Drawing.Point(33, 58);
            this.labelMakeExam.Name = "labelMakeExam";
            this.labelMakeExam.Size = new System.Drawing.Size(97, 12);
            this.labelMakeExam.TabIndex = 47;
            this.labelMakeExam.Text = "시험 문제 만들기";
            this.labelMakeExam.Click += new System.EventHandler(this.labelMakeExam_Click);
            // 
            // Worker
            // 
            this.Worker.WorkerReportsProgress = true;
            this.Worker.WorkerSupportsCancellation = true;
            this.Worker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.Worker_DoWork);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImage = global::HelloEnglishTeacher.Properties.Resources.dot;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Location = new System.Drawing.Point(12, 36);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(10, 10);
            this.pictureBox2.TabIndex = 46;
            this.pictureBox2.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(30, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 12);
            this.label2.TabIndex = 45;
            this.label2.Text = "시험 유형2";
            // 
            // comboBoxExamType2
            // 
            this.comboBoxExamType2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxExamType2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExamType2.FormattingEnabled = true;
            this.comboBoxExamType2.Location = new System.Drawing.Point(99, 28);
            this.comboBoxExamType2.Name = "comboBoxExamType2";
            this.comboBoxExamType2.Size = new System.Drawing.Size(156, 20);
            this.comboBoxExamType2.TabIndex = 44;
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::HelloEnglishTeacher.Properties.Resources.bg_popup;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(362, 268);
            this.Controls.Add(this.labelMakeExam);
            this.Controls.Add(this.chkMakeExam);
            this.Controls.Add(this.panelExam);
            this.Controls.Add(this.labelVersion);
            this.Controls.Add(this.picContact);
            this.Controls.Add(this.picCheck1);
            this.Controls.Add(this.picXbutton);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.btnFileSearch);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Tag = "Make English Word!!";
            this.Text = "Make English Word!!";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.picContact)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCheck1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picXbutton)).EndInit();
            this.panelExam.ResumeLayout(false);
            this.panelExam.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDot2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDot1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog OpenFile;
        private System.Windows.Forms.Button btnFileSearch;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.PictureBox picXbutton;
        private System.Windows.Forms.PictureBox picCheck1;
        private System.Windows.Forms.PictureBox picContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelVersion;
        private System.Windows.Forms.Panel panelExam;
        private System.Windows.Forms.PictureBox picDot2;
        private System.Windows.Forms.Label labelExamNum;
        private System.Windows.Forms.PictureBox picDot1;
        private System.Windows.Forms.Label labelExamType;
        private System.Windows.Forms.ComboBox comboBoxExamType;
        private System.Windows.Forms.Label LabelFirstWord;
        private System.Windows.Forms.CheckBox chkBoxFirstWord;
        private System.Windows.Forms.TextBox txtExamNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtExamStart;
        private System.Windows.Forms.TextBox txtExamEnd;
        private System.Windows.Forms.CheckBox chkMakeExam;
        private System.Windows.Forms.Label labelMakeExam;
        private System.ComponentModel.BackgroundWorker Worker;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxExamType2;
    }
}