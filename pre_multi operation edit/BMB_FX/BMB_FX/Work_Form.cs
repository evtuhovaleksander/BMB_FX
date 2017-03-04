using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMB_FX
{
    public partial class Work_Form : Form
    {
        public Work_Form()
        {
            InitializeComponent();
        }

        private void Maximize_But_Click(object sender, EventArgs e)
        {
            Size = new Size(910, Size.Height);
        }

        private void Minimize_But_Click(object sender, EventArgs e)
        {
            Size = new Size(484, Size.Height);
        }

        private void Client_Leave_But_Click(object sender, EventArgs e)
        {
            int rate = RateForm.GetRate();
          //  MessageBox.Show("Got rate " +rate );
            Client_Leave_But.BackColor=Color.LawnGreen;
            Rate_Tbox.Text = rate.ToString();
            Rate_Date_TBox.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void Work_Form_SizeChanged(object sender, EventArgs e)
        {
            Text = "Work_Form " + Size.Width + " x " + Size.Height;
        }
    }
}
