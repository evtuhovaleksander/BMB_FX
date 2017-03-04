using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMB_FX.ORM
{
    class Master_ORM
    {
        public static List<int> get_id_where_service(int id)
        {
            return
                SQL.get_List_Int(
                    "select m.ID from master m inner join master_service ms on ms.master_id=m.id  where (ms.service_id=" +
                    id.ToString() + ")");

        }

        public static string get_master_where_id(int id)
        {
            return
                SQL.ReadValueStatic("select m.Master from master m where (m.ID=" +id.ToString() + ")").ToString();
                  

        }

        public static int get_id_where_master(string master)
        {
            return
                SQL.ReadValueInt32("select m.ID from master m where (m.Master='" + master + "')");


        }

        public static double get_MainInd(int id)
        {
            return SQL.ReadValueDouble("select main_index from master where ID=" + id);
        }
    }
}
