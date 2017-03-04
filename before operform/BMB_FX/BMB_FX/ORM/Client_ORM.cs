using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMB_FX.ORM
{
    class Client_ORM
    {
        public static int get_id_where_Name(string name)
        {
            return SQL.ReadValueInt32("select ID from client where Client='" + name + "'");
        }
        public static string get_name_where_id(int id)
        {
            return SQL.ReadValueStatic("select Client from client where ID=" + id + "").ToString();
        }
    }
}
