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
    public partial class RateForm : Form
    {
        public int Rate;
        public RateForm()
        {
            InitializeComponent();
            Rate = -1;
        }

        public static int GetRate()
        {
            RateForm frm = new RateForm();
            Screen[] sc = Screen.AllScreens;
            int monitor_index = 0;
            if (sc.Length != 1)
            {
                monitor_index = 1;
            }
            else
            {
                monitor_index = 0;
            }

            frm.FormBorderStyle = FormBorderStyle.Sizable;
            frm.Left = sc[monitor_index].Bounds.Width;
            frm.Top = sc[monitor_index].Bounds.Height;
            frm.StartPosition = FormStartPosition.Manual;
            frm.Location = sc[monitor_index].Bounds.Location;
            Point p = new Point(sc[monitor_index].Bounds.Location.X, sc[monitor_index].Bounds.Location.Y);
            frm.Location = p;
           if(monitor_index==1) frm.WindowState = FormWindowState.Maximized;

            frm.ShowDialog();
            while (frm.Rate == -1)
            {
                frm.ShowDialog();
            }
            return frm.Rate;
        }

        private void RateForm_Load(object sender, EventArgs e)
        {

        }

        private void Set_One_Click(object sender, EventArgs e)
        {
            Rate = 1;
            Close();
        }

        private void Set_Five_Click(object sender, EventArgs e)
        {
            Rate = 5;
            Close();
        }
    }
}
