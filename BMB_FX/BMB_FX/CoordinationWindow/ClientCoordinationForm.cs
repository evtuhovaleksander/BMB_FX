using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMB_FX.CoordinationWindow;
using BMB_FX.Element_Show;

namespace BMB_FX
{
    public partial class ClientCoordinationForm : Form
    {
        
        public Table table;
        private int Selected_Index=-1;
        public Coordination_Form parent;
        public ClientCoordinationForm(Coordination_Form parent)
        {
            InitializeComponent();
            this.parent = parent;
            List<Element> elements = new List<Element>();
            //elements.Add(new Element("ID", "int",true));
            //elements.Add(new Element("ID", "key", false));
            //Element("ID", "key", false));
            elements.Add(new Key_Element());
            elements.Add(new Element("Client", "string",true));
            elements.Add(new Simple_Join_Element("gender",true,"gender","Gender"));
            elements.Add(new Element("phone", "string", true));
            elements.Add(new SystemVal_Element("punctuality_index","punctuality_index","Client_ID"));
            table = new Table(elements,dgv,"client");
            Load_Data();
            load_AutoComplete("Client", "client");
        }

        public void load_AutoComplete(string param,string tab)
        {
            List<string> lst = SQL.get_List_String("select " + param + " from " + tab);
            string[] s = new string[lst.Count];
            for (int i = 0; i < lst.Count; i++)
            {
                s[i] = lst[i];
            }
            AutoCompleteStringCollection col = new AutoCompleteStringCollection();
            col.AddRange(s);
            FilterTBox.AutoCompleteCustomSource = col;
        }


        public void Load_Data()
        {
            if (FilterTBox.Text != "")
            {
                table.LoadData("where Client like '%" + FilterTBox.Text + "%'");
            }
            else
            {
                table.LoadData();
            }


           
        }

        private void Add_But_Click(object sender, EventArgs e)
        {
            FormBuilder.Prepare_Form_To_Add(table,new Point(50,50));
            table.LoadData();
            load_AutoComplete("Client","client");
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
                parent.load_client_to_request_form(Selected_Index);
            }
            

        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           if(e.RowIndex!=-1) FormBuilder.Prepare_Form_To_Show(table, new Point(50, 50),Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value));
        }

        private void ClientCoordinationForm_Load(object sender, EventArgs e)
        {

        }

        private void FilterTBox_TextChanged(object sender, EventArgs e)
        {
            Load_Data();
        }

        //public static int get_ClientID()
        //{
        //    ClientCoordinationForm frm = new ClientCoordinationForm();
        //    frm.ShowDialog();
        //    return frm.Selected_Index;
        //}
    }
}
