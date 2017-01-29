using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BMB_FX
{
   public  class DataGridView_BMB :DataGridView
    {
        const int offset=20;
        SQL cl;
        MySqlDataAdapter adapter;

        public void load_Data(string queue)
        {
            cl = new SQL();
            cl.prepare_DataAdapter(queue);
            cl.prepare_DataTable();
            cl.table.translate_Columns();

            DataSource = cl.table;
        }

        public void upload_Data()
        {
            cl.upload_Data();
        }

        public DataGridView_BMB(TabPage parent)
        {
            Parent = parent;
            Height = parent.Height - 2*offset;
            Width = parent.Width - 2*offset;
            Location=new Point(offset,offset);
        }

        public DataGridView_BMB()
        {
        }
    }
}
