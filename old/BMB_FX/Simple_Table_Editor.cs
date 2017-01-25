using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BMB_FX
{
    public partial class Simple_Table_Editor : Form
    {
       

        public Simple_Table_Editor()
        {
            InitializeComponent();
        }

        public static void  Form_Lauch(string queue)
        {
            Simple_Table_Editor frm=new Simple_Table_Editor();
            frm.dgv.load_Data(queue);
            frm.ShowDialog();
        }

        private void Upload_But_Click(object sender, EventArgs e)
        {

            dgv.upload_Data();
        }

        private void Simple_Table_Editor_Load(object sender, EventArgs e)
        {

        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
