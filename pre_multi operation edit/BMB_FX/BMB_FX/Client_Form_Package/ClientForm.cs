using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMB_FX.Element_Show;

namespace BMB_FX
{
    public partial class ClientForm : Form
    {
        
        public Table table;
        private int Selected_Index=-1;
        public ClientForm()
        {
            InitializeComponent();
            List<Element> elements = new List<Element>();
            elements.Add(new Element("ID", false));
            elements.Add(new Element("Client", true));
            elements.Add(new Element("PuInd_ID", false, true, "punctuality_index","Val"));
            table = new Table(elements,dgv,"client");
            table.LoadData();
        }

        private void Add_But_Click(object sender, EventArgs e)
        {
            FormBuilder.Prepare_Form_To_Add(table,new Point(50,50));
        }

        private void Select_But_Click(object sender, EventArgs e)
        {
            if (dgv.SelectedRows.Count != 1)
            {
                MessageBox.Show("er");
            }
            else
            {
                Selected_Index = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
            }
            Close();

        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.RowIndex!=-1) FormBuilder.Prepare_Form_To_Show(table, new Point(50, 50),Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value));
        }

        public static int get_ClientID()
        {
            ClientForm frm = new ClientForm();
            frm.ShowDialog();
            return frm.Selected_Index;
        }
    }
}
