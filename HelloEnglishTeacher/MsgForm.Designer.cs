namespace HelloEnglishTeacher
{
    partial class MsgForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.picboxMsgX = new System.Windows.Forms.PictureBox();
            this.lblMsgMsg = new System.Windows.Forms.Label();
            this.picboxMsgConfirm = new System.Windows.Forms.PictureBox();
            this.labelMsg = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMsgX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMsgConfirm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::HelloEnglishTeacher.Properties.Resources.bg_popup_top_bar;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.picboxMsgX);
            this.panel1.Controls.Add(this.lblMsgMsg);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(262, 34);
            this.panel1.TabIndex = 0;
            // 
            // picboxMsgX
            // 
            this.picboxMsgX.BackgroundImage = global::HelloEnglishTeacher.Properties.Resources.x_blue;
            this.picboxMsgX.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxMsgX.Location = new System.Drawing.Point(236, 11);
            this.picboxMsgX.Name = "picboxMsgX";
            this.picboxMsgX.Size = new System.Drawing.Size(17, 15);
            this.picboxMsgX.TabIndex = 24;
            this.picboxMsgX.TabStop = false;
            this.picboxMsgX.Click += new System.EventHandler(this.picboxMsgX_Click);
            // 
            // lblMsgMsg
            // 
            this.lblMsgMsg.AutoSize = true;
            this.lblMsgMsg.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lblMsgMsg.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lblMsgMsg.ForeColor = System.Drawing.Color.White;
            this.lblMsgMsg.Image = ((System.Drawing.Image)(resources.GetObject("lblMsgMsg.Image")));
            this.lblMsgMsg.Location = new System.Drawing.Point(8, 12);
            this.lblMsgMsg.Name = "lblMsgMsg";
            this.lblMsgMsg.Size = new System.Drawing.Size(65, 12);
            this.lblMsgMsg.TabIndex = 23;
            this.lblMsgMsg.Text = "Message";
            // 
            // picboxMsgConfirm
            // 
            this.picboxMsgConfirm.BackgroundImage = global::HelloEnglishTeacher.Properties.Resources.ok_check;
            this.picboxMsgConfirm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picboxMsgConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picboxMsgConfirm.Location = new System.Drawing.Point(103, 86);
            this.picboxMsgConfirm.Name = "picboxMsgConfirm";
            this.picboxMsgConfirm.Size = new System.Drawing.Size(58, 26);
            this.picboxMsgConfirm.TabIndex = 21;
            this.picboxMsgConfirm.TabStop = false;
            this.picboxMsgConfirm.Click += new System.EventHandler(this.picboxMsgConfirm_Click);
            this.picboxMsgConfirm.MouseLeave += new System.EventHandler(this.picboxMsgConfirm_MouseLeave);
            this.picboxMsgConfirm.MouseHover += new System.EventHandler(this.picboxMsgConfirm_MouseHover);
            // 
            // labelMsg
            // 
            this.labelMsg.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMsg.BackColor = System.Drawing.Color.WhiteSmoke;
            this.labelMsg.Font = new System.Drawing.Font("맑은 고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.labelMsg.Location = new System.Drawing.Point(10, 37);
            this.labelMsg.Name = "labelMsg";
            this.labelMsg.Size = new System.Drawing.Size(240, 46);
            this.labelMsg.TabIndex = 22;
            this.labelMsg.Text = "메세지";
            this.labelMsg.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MsgForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HelloEnglishTeacher.Properties.Resources.bg_popup_noheader;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(262, 124);
            this.Controls.Add(this.labelMsg);
            this.Controls.Add(this.picboxMsgConfirm);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MsgForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MsgForm";
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MsgForm_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMsgX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picboxMsgConfirm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox picboxMsgX;
        private System.Windows.Forms.Label lblMsgMsg;
        private System.Windows.Forms.PictureBox picboxMsgConfirm;
        private System.Windows.Forms.Label labelMsg;
    }
}