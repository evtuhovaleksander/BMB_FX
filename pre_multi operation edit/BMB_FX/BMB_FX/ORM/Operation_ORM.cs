using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMB_FX.ORM
{
    public class Operation_ORM
    {
        public static void test_add_Operation(int master, int resource, DateTime start, DateTime stop)
        {
            string s =
                "insert into operation (Request_ID,Gap_Start,Gap_Stop,Rate,Comment,Master_ID,Resource_ID) values(" +
                "-1,'"+start.ToString("yyyy-MM-dd HH:mm:ss")+"','"+stop.ToString("yyyy-MM-dd HH:mm:ss") + "',-1,'Cm'," + master + "," + resource + ")";
            SQL.Execute(s);
        }
       
      
    }
}
