using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMB_FX
{
    public class Overlapper
    {
        //List<Interval> busyIntervals;
        //List<Interval> freIntervals;
        

        //public Overlapper(List<Quantum_Interval> busyIntervals)
        //{
        //    this.busyIntervals = busyIntervals;
        //}

        //public static List<Interval> get_free_Intervals(List<Resource_Interval> bIntervals,DateTime day,int resource_id)
        //{
            
        //    List<Interval> busyIntervals = bIntervals;
        //    List<Interval>  freeIntervals = new List<Interval>();
         
        //    busyIntervals.Sort((x, y) => x.start.CompareTo(y.start));


        //    if (busyIntervals[0].start!=0)
        //    {
        //        freeIntervals.Add(new Interval(0,busyIntervals[0].start-1,day));
        //    }


        //    int stop = busyIntervals.Count-1;
        //    for (int i = 0; i < stop; i++)
        //    {
        //        if (busyIntervals[i].stop < busyIntervals[i + 1].start)
        //        {
        //            if (busyIntervals[i].stop != busyIntervals[i + 1].start - 1)
        //            {
        //                freeIntervals.Add(new Interval(busyIntervals[i].stop + 1, busyIntervals[i + 1].start - 1,day));
        //            }
        //            else
        //            {
        //                continue;
        //            }
        //        }
        //        else
        //        {
        //            {
        //                busyIntervals[i + 1]=new Interval(busyIntervals[i].start,Math.Max(busyIntervals[i].stop, busyIntervals[i+1].stop),day);
        //            }
        //        }
        //    }

        //    if (busyIntervals[stop].stop != 287)
        //    {
        //        freeIntervals.Add(new Interval(busyIntervals[stop].stop+1,287,day));
        //    }

        //    return freeIntervals;
        //}

        public static List<Master_Interval> get_free_Intervals(Master master)
        {

            List<Master_Interval> busyIntervals = master.blocked_intervals;
            List<Master_Interval> freeIntervals = new List<Master_Interval>();

            busyIntervals.Sort((x, y) => x.start.CompareTo(y.start));

            if (busyIntervals.Count == 0)
            {
                freeIntervals.Add(new Master_Interval(0, 287, master.day.Date,
                        master.masterID));
            }
            else
            {



                if (busyIntervals[0].start != 0)
                {
                    freeIntervals.Add(new Master_Interval(0, busyIntervals[0].start - 1, master.day.Date,
                        master.masterID));
                }


                int stop = busyIntervals.Count - 1;
                for (int i = 0; i < stop; i++)
                {
                    if (busyIntervals[i].stop < busyIntervals[i + 1].start)
                    {
                        if (busyIntervals[i].stop != busyIntervals[i + 1].start - 1)
                        {
                            freeIntervals.Add(new Master_Interval(busyIntervals[i].stop + 1,
                                busyIntervals[i + 1].start - 1, master.day.Date, master.masterID));
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        {
                            busyIntervals[i + 1] = new Master_Interval(busyIntervals[i].start,
                                Math.Max(busyIntervals[i].stop, busyIntervals[i + 1].stop), master.day.Date,
                                master.masterID);
                        }
                    }
                }

                if (busyIntervals[stop].stop != 287)
                {
                    freeIntervals.Add(new Master_Interval(busyIntervals[stop].stop + 1, 287, master.day.Date,
                        master.masterID));
                }
            }
            return freeIntervals;
        }
        public static List<Resource_Interval> get_free_Intervals(Resource resource)
        {

            List<Resource_Interval> busyIntervals = resource.blocked_intervals;
            List<Resource_Interval> freeIntervals = new List<Resource_Interval>();

            busyIntervals.Sort((x, y) => x.start.CompareTo(y.start));
            if (busyIntervals.Count == 0)
            {
                freeIntervals.Add(new Resource_Interval(0, 287, resource.day.Date,
                    resource.resourceID));
            }
            else
            {

                if (busyIntervals[0].start != 0)
                {
                    freeIntervals.Add(new Resource_Interval(0, busyIntervals[0].start - 1, resource.day.Date,
                        resource.resourceID));
                }


                int stop = busyIntervals.Count - 1;
                for (int i = 0; i < stop; i++)
                {
                    if (busyIntervals[i].stop < busyIntervals[i + 1].start)
                    {
                        if (busyIntervals[i].stop != busyIntervals[i + 1].start - 1)
                        {
                            freeIntervals.Add(new Resource_Interval(busyIntervals[i].stop + 1,
                                busyIntervals[i + 1].start - 1, resource.day.Date, resource.resourceID));
                        }
                        else
                        {
                            continue;
                        }
                    }
                    else
                    {
                        {
                            busyIntervals[i + 1] = new Resource_Interval(busyIntervals[i].start,
                                Math.Max(busyIntervals[i].stop, busyIntervals[i + 1].stop), resource.day.Date,
                                resource.resourceID);
                        }
                    }
                }

                if (busyIntervals[stop].stop != 287)
                {
                    freeIntervals.Add(new Resource_Interval(busyIntervals[stop].stop + 1, 287, resource.day.Date,
                        resource.resourceID));
                }
            }
            return freeIntervals;
        }



        //public  List<Quantum_Interval> get_concat2(List<Quantum_Interval> blocked)
        //{
        //    List<Quantum_Interval> outt = new List<Quantum_Interval>();
        //    Day_TimeLine day = new Day_TimeLine();
        //    Quantum_Interval interv;


        //        for (int j = 0; j < blocked.Count(); j++)
        //        {
        //            interv = ((Quantum_Interval)blocked[(j)]);
        //            for (int i = interv.start; i <= interv.stop; i++)
        //            {
        //                day.bool_quants[i] = false;
        //            }
        //        }

        //    Quantum_Interval cur_interval = null;
        //    for (int i = 0; i < day.bool_quants.Length; i++)
        //    {
        //        if (day.bool_quants[i])
        //        {
        //            if (cur_interval == null)
        //            {
        //                cur_interval = new Quantum_Interval(i);
        //            }
        //        }
        //        else
        //        {
        //            if (cur_interval != null)
        //            {
        //                cur_interval.setStop(i - 1);
        //                outt.Add(cur_interval);
        //                cur_interval = null;
        //            }
        //        }
        //    }

        //    if (cur_interval != null)
        //    {
        //        cur_interval.setStop(day.bool_quants.Length - 1);
        //        outt.Add(cur_interval);
        //        cur_interval = null;
        //    }


        //    return outt;
        //}



        //public static List<Quantum_Interval> prep_inp(int i)
        //{
        //    Random r= new Random();
        //    List<Quantum_Interval> tt=new List<Quantum_Interval>();
        //    for (int j = 0; j < i; j++)
        //    {
        //        int start = r.Next(0, 288);
        //        int stop = r.Next(start, 288);
        //        tt.Add(new Quantum_Interval(start,stop));
        //    }
        //    return tt;

        //}
    }
}
