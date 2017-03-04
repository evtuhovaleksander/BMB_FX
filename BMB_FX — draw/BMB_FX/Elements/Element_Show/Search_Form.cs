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

namespace BMB_FX.Elements.Element_Show
{
    public partial class Search_Form : Form
    {
        public Search_Form(Table input_table)
        {
            InitializeComponent();
            table = input_table;
            table.dgv = dgv;
            table.LoadData();
        }

        public Table table;
        private void Search_Form_Load(object sender, EventArgs e)
        {

        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.RowIndex!=-1) FormBuilder.Prepare_Form_To_Edit(table, new Point(50, 50), e.RowIndex);
        }

        private void Add_But_Click(object sender, EventArgs e)
        {
            FormBuilder.Prepare_Form_To_Add(table, new Point(50, 50));
        }
    }
}
