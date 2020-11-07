using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloEnglishTeacher
{
    public partial class MsgForm : Form
    {
        public MsgForm()
        {
            InitializeComponent();
        }

        public MsgForm(string Msg)
        {
            InitializeComponent();
            labelMsg.Text = Msg;
        }

        private void picboxMsgX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picboxMsgConfirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void picboxMsgConfirm_MouseHover(object sender, EventArgs e)
        {
            picboxMsgConfirm.BackgroundImage = Properties.Resources.ok_check_over;
        }

        private void picboxMsgConfirm_MouseLeave(object sender, EventArgs e)
        {
            picboxMsgConfirm.BackgroundImage = Properties.Resources.ok_check;
        }

        private void MsgForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                this.Close();
            }

            if (e.KeyData == (Keys.Alt | Keys.F4))
            {
                this.Close();
            }
        }
    }
}
