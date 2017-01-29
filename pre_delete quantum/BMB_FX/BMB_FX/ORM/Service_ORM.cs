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
    }
}
