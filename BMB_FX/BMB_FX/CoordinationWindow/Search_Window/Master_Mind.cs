using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMB_FX.CoordinationWindow.Search_Window
{
    static class Master_Mind
    {
       public static int max_wait_time = 10;
        public static int delay_cycle = 5;

        public static int delay_penalty_coef = 200;
        public static int wait_penalty_coef = 10;
        public static int master_penalty = 5;
        public static int resource_penalty = 5;
    }
}
