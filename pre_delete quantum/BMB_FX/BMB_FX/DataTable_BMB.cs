using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMB_FX
{
   public class DataTable_BMB : DataTable
    {
        public void translate_Columns()
        {
            SQL cl = new SQL();
            for (int i = 0; i < Columns.Count; i++)
            {
                Columns[i].ColumnName = cl.get_Translation(Columns[i].ColumnName);
            }
        }

        public void back_translate_Columns()
        {
            SQL cl = new SQL();
            for (int i = 0; i < Columns.Count; i++)
            {
                Columns[i].ColumnName = cl.get_Back_Translation(Columns[i].ColumnName);
            }
        }
    }
}
