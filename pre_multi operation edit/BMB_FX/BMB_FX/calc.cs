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
    public partial class calc : Form
    {
        public calc()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(textBox2.Text);
            textBox3.Text = "";
            textBox3.Text = "" + (Math.Pow(8,a)).ToString("####################################################################################");
        }
    }
}
