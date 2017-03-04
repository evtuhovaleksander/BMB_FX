using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMB_FX.ORM
{
    class Service_ORM
    {
        public static List<string> get_Services()
        {
            return SQL.get_List_String("Select Service from service");
        }

        public static int get_id_where_service(string service)
        {
            return SQL.ReadValueInt32("select ID from service where service='" + service + "'");
        }

        public static int get_gap_duration(int id)
        {
            return
                SQL.ReadValueInt32(
                    "select gd.Val from gap_duration gd  where gd.Service_ID="+id+"  and Date=(select max(g.Date) from gap_duration g where g.Service_ID="+id+")");
            return
                SQL.ReadValueInt32(
                    "select gd.Val from gap_duration gd  where gd.Service_ID=" + id + "  and Date = (select MAX(g.Date) from gap_duration g where g.Service)");
        }
        public static string get_Name_by_id(int id)
        {
            return
                SQL.ReadValueStatic(
                    "select Service from service where ID=" + id).ToString();
        }
    }
}
