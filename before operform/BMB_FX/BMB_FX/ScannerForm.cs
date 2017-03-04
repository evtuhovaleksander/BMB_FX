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
    public partial class ScannerForm : Form
    {

        public int Code;
        const int leng = 5;

        public static int Scan()
        {
            ScannerForm frm = new ScannerForm();
            frm.ShowDialog();
            return frm.Code;
        }

        public ScannerForm()
        {
            InitializeComponent();
            Code = -1;
        }

        private void Cancel_but_Click(object sender, EventArgs e)
        {

            Code = - 1;
            Close();

        }

        private void ScannerForm_Load(object sender, EventArgs e)
        {
            progressBar.Value = progressBar.Maximum;
            timer.Start();
        }

        private void timer_Tick(object sender, EventArgs e)
        {

            progressBar.Value--;
            if (progressBar.Value == progressBar.Minimum)
            {
                timer.Stop();
                get_Code();
                Close();
            }
            
        }

        void get_Code()
        {
            if (textBox.Text.Length == leng)
            {
                try
                {
                    Code = Convert.ToInt32(textBox.Text);
                }
                catch (Exception)
                {
                    Code = -1;
                }
                Close();
            }
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
           get_Code();
        }
    }
}
