namespace HelloEnglishTeacher
{
    partial class ProcessForm
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
            this.picProcessing = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picProcessing)).BeginInit();
            this.SuspendLayout();
            // 
            // picProcessing
            // 
            this.picProcessing.BackColor = System.Drawing.Color.Transparent;
            this.picProcessing.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.picProcessing.Image = global::HelloEnglishTeacher.Properties.Resources.processing;
            this.picProcessing.Location = new System.Drawing.Point(0, 0);
            this.picProcessing.Name = "picProcessing";
            this.picProcessing.Size = new System.Drawing.Size(287, 139);
            this.picProcessing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picProcessing.TabIndex = 21;
            this.picProcessing.TabStop = false;
            // 
            // ProcessForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::HelloEnglishTeacher.Properties.Resources.bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(287, 138);
            this.Controls.Add(this.picProcessing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProcessForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ProcessForm";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picProcessing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picProcessing;
    }
}