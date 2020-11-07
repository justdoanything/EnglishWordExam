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
    public partial class ProcessForm : Form
    {
        public ProcessForm(int x, int y, int width, int height)
        {
            InitializeComponent();
            
            int centerX= x + (width - this.Width) / 2;
            int centerY = y + (height - this.Height) / 2;

            this.Location = new Point(centerX, centerY);
            
        }
    }
}
