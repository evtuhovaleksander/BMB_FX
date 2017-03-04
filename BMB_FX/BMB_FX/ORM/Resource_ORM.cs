using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMB_FX.ORM
{
    class Resource_ORM
    {
        public static List<int> get_id_where_service(int id)
        {
            return
                SQL.get_List_Int(
                    "select r.ID from resource r inner join resource_service rs on rs.resource_id=r.id  where (rs.service_id=" +
                    id.ToString() + ")");

        }

        public static string get_res_where_id(int id)
        {
            return
                SQL.ReadValueStatic("select Resource from resource  where (ID=" + id.ToString() + ")").ToString();


        }

        public static int get_id_where_res(string res)
        {
            return
                SQL.ReadValueInt32("select m.ID from resource m where (m.Resource='" + res + "')");


        }
    }
}
