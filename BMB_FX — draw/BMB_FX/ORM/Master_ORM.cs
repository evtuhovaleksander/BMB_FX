﻿using System;
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
    }
}
