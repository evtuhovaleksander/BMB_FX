using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMB_FX
{
    public class TEST_CLASS
    {
        public static List<string> outt=new List<string>();
        public double out1;
        public double out2;

        public  void test()
        {
            outt= new List<string>();

            tq(1);
            tq(1);
            tq(1);
            tq(1);
            tq(1);
            tq(1);
            tq(1);
            tq(1);

            tq(10);
            tq(10);
            tq(10);
            tq(10);
            tq(10);
            tq(10);
            tq(10);
            tq(10);

            tq(50);
            tq(50);
            tq(50);
            tq(50);
            tq(50);
            tq(50);
            tq(50);
            tq(50);
            tq(50);
            tq(50);

            tq(100);
            tq(100);
            tq(100);
            tq(100);
            tq(100);
            tq(100);
            tq(100);
            tq(100);
            tq(100);
            tq(100);

            for (int i = 0; i < outt.Count; i++)
            {
                Console.WriteLine(outt[i]);
            }

            int a = 0;
        }

        public void tq(int q)
        {
            outt.Add("test for "+q);
            tss(q);
            double l1 = out1;
            double l2 = out2;
            outt.Add("alg1 =" + l1 + "");
            outt.Add("alg2 =" + l2 + "");
            outt.Add("dif ="+(l2-l1).ToString());
            outt.Add("*****\n");
        }

        public  void tss(int lal)
        {

            TimeSpan tiks;
            TimeSpan tiks2;
           

            List<Quantum_Interval> inp = Overlapper.prep_inp(lal);

            tiks = new TimeSpan();
            int col = 1000;
            for (int i = 0; i < col; i++)
            {
                tiks += maketest_alg1(inp);
            }
            out1 = (tiks.TotalMilliseconds/col);
            tiks2 = new TimeSpan();
            for (int i = 0; i < col; i++)
            {
                tiks2 += maketest_alg2(inp);
            }
            out2 = (tiks2.TotalMilliseconds / col);
        }

        public static TimeSpan maketest_alg1(List<Quantum_Interval> inp)
        {
            DateTime sta;
            DateTime sto;
            TimeSpan sum;
            Overlapper cl = new Overlapper(inp);
            sta = DateTime.Now;
            cl.get_concat();
            sto = DateTime.Now;
            sum = sto - sta;
            return sum;
        }

        public static TimeSpan maketest_alg2(List<Quantum_Interval> inp)
        {
            DateTime sta;
            DateTime sto;
            TimeSpan sum;
            Overlapper cl = new Overlapper(inp);
            sta = DateTime.Now;
            cl.get_concat2(inp);
            sto = DateTime.Now;
            sum = sto - sta;
            return sum;
        }
    }
}
