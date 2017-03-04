using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMB_FX
{
    class Randomizer
    {
        public static Random rnd;

        static void check()
        {
            if( rnd==null)rnd=new Random();
        }

        public static int get_int()
        {
            check();
            Random rnd2=new Random(rnd.Next(1,9999));
            for (int i = 0; i < rnd2.Next(1, 9999); i++)
            {
                rnd.Next(rnd2.Next(1, 9999));

            }
            return rnd2.Next(0, 9999);
        }
    }
}
