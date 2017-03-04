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
    public partial class Table_Editor_Multi_Table : Form
    {
        TabPage[] tabPages;
        DataGridView_BMB[] gridViews;
        
        public Table_Editor_Multi_Table(int col,string[] table_names,string[] queues,string queue)
        {
            InitializeComponent();
            if (col != 0)
            {
                tabPages = new TabPage[col];
                for (int i = 0; i < col; i++)
                {
                    tabPages[i]=new TabPage();
                    tabPages[i].Height = tabContainer.Height;
                    tabPages[i].Width = tabContainer.Width;
                    tabPages[i].Location = new Point(0,0);
                    tabPages[i].Text = table_names[i];
                    tabContainer.TabPages.Add(tabPages[i]);
                }
                gridViews = new DataGridView_BMB[col];
                for (int i = 0; i < col; i++)
                {
                    gridViews[i] = new DataGridView_BMB(tabPages[i]);
                    gridViews[i].load_Data(queues[i]);
                }
            }
            dgv.load_Data(queue);
        }

        private void Upload_But_Click(object sender, EventArgs e)
        {
            dgv.upload_Data();
        }

        public static Table_Editor_Multi_Table get_Form(string queue)
        {
            return new Table_Editor_Multi_Table(0,null,null,queue);
        }

        public static Table_Editor_Multi_Table get_Form(Initializer init)
        {
            return new Table_Editor_Multi_Table(init.tables.Length, init.tables, init.queues, init.queue);
        }

        public struct Initializer
        {
            public string[] tables;
            public string[] queues;
            public string queue;
        }
    }
}
