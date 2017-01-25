using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMB_FX
{
    public class Date_Converter
    {
        public static int Date_To_Index(DateTime date)
        {

            TimeSpan span = date - date.Date;
            return (int) span.TotalMinutes/5;
           
        }

        public static string DateToStartDay(DateTime date)
        {
            return date.Date.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static string DateToStopDay(DateTime date)
        {
            return date.Date.Add(new TimeSpan(23,59,59)).ToString("yyyy-MM-dd HH:mm:ss");
        }
    }



    public class Day_TimeLine
    {
       public bool[] bool_quants;
        public bool[,] double_bool_quants;

    public Day_TimeLine()
        {
            this.bool_quants = new bool[288];
            this.double_bool_quants = new bool[288,2];
            for (int i = 0; i < bool_quants.Length; i++)
            {
                bool_quants[i] = true;
            }
        }

    }


 


    public class Quantum_Interval :IComparable<Quantum_Interval>
    {
        public int start;
        public int stop;
        public int length;

        public Quantum_Interval(int start, int stop)
        {
            this.start = start;
            this.stop = stop;
            this.length = stop - start + 1;
        }

        public Quantum_Interval(int start)
        {
            this.start = start;
        }

        public Quantum_Interval(DateTime start, DateTime stop)
        {
            this.start = Date_Converter.Date_To_Index(start);
            this.stop = Date_Converter.Date_To_Index(stop);
            this.length = this.stop - this.start + 1;
        }

        public void setStop(int stop)
        {
            this.stop = stop;
            this.length = stop - start + 1;
        }
        
        public int CompareTo(Quantum_Interval other)
        {
            if (start <= other.start)
            {
                return -1;
            }
            else
            {
                if (start == other.start)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }
    }

    public class Interval : Quantum_Interval
    {
        public DateTime start_date;
        public DateTime stop_date;

        public Interval(DateTime startDate, DateTime stopDate) : base(startDate, stopDate)
        {
            
        }

        public Interval(int start, int stop) : base(start, stop)
        {
        }
}


    public class Resource_Interval : Interval
    {
int resouceID;


        public Resource_Interval(DateTime startDate, DateTime stopDate, int resouceId) : base(startDate, stopDate)
        {
            resouceID = resouceId;
        }


        public Resource_Interval(int start, int stop, int resouceId) : base(start, stop)
        {
            resouceID = resouceId;
        }


    public void print()
    {
       Console.WriteLine(
           "ResourceInterval\t start: " + start + "\t    stop: " + stop + "    " + "length: " + length + "\t    " + "resourceID: " + resouceID);
    }
}

    public class Master_Interval : Interval
    {
    int masterID;

        public Master_Interval(DateTime startDate, DateTime stopDate, int masterId) : base(startDate, stopDate)
        {
            masterID = masterId;
        }

        public Master_Interval(int start, int stop, int masterId) : base(start, stop)
        {
            masterID = masterId;
        }

     
    public void print()
    {
        Console.WriteLine("MasterInterval start: " + start + "    stop: " + stop + "    " + "length: " + length + "    " + "masterID: " + masterID);
    }
}

    public class Window_Interval : Interval
    {
    public Master_Interval master_interval;
    public Resource_Interval resource_interval;
    public int masterId;
    public int resourceId;


    public Window_Interval(int start, int stop, Master_Interval masterInterval, Resource_Interval resourceInterval) : base(start, stop)
    {
        master_interval = masterInterval;
        resource_interval = resourceInterval;
    }

    public Window_Interval(int start, int stop, Master_Interval masterInterval, Resource_Interval resourceInterval, int masterId, int resourceId) : base(start, stop)
    {
        master_interval = masterInterval;
        resource_interval = resourceInterval;
        this.masterId = masterId;
        this.resourceId = resourceId;
    }

    public Window_Interval(int start, int stop, int masterId, int resourceId) : base(start, stop)
    {
        this.masterId = masterId;
        this.resourceId = resourceId;
    }

    public void print()
    {
        Console.WriteLine("WindowInterval start: "+start+"   stop: "+stop+"   length: "+length+"  resourceID: "+resourceId+"   masterID: "+masterId);
    }
}
    
    public class Interval_Overlap_Class
    {

        public Quantum_Interval overlap(Interval master_interval, Interval resource_interval)
        {
            Quantum_Interval outt = new Quantum_Interval(0, 0);
            Quantum_Interval long_i;
            Quantum_Interval short_i;
            if (master_interval.length > resource_interval.length) { long_i = master_interval; short_i = resource_interval; }
            else { long_i = resource_interval; short_i = master_interval; };


            bool stop;
            bool start;
            bool left = false;
            bool right = false;
            bool center = false;
            // center
            stop = short_i.stop <= long_i.stop;
            start = short_i.start >= long_i.start;
            if (start && stop) center = true;
            //left
            start = short_i.start < long_i.stop;
            stop = short_i.stop >= long_i.stop;
            if (start && stop) left = true;
            //rightt
            start = short_i.start <= long_i.start;
            stop = short_i.stop > long_i.start;
            if (start && stop) right = true;
            if (center) outt = new Quantum_Interval(short_i.start, short_i.stop);
            if (left) outt = new Quantum_Interval(short_i.start, long_i.stop);
            if (right) outt = new Quantum_Interval(long_i.start, short_i.stop);

            if (outt.length != 0) { return outt; } else { return null; }
        }

        public static List<Master_Interval> get_free_Master_Intervals(Master master)
        {
            List<Quantum_Interval> outt = get_free_Quantum_Intervals(master.blocked_intervals,null);
            List<Master_Interval> outt_typed = new List<Master_Interval>();
            foreach (Quantum_Interval interv in outt)
            {
                outt_typed.Add(new Master_Interval(interv.start, interv.stop, master.masterID));
            }
            return outt_typed;
        }

        public static List<Resource_Interval> get_free_Resource_Intervals(Resource resource)
        {
            List<Quantum_Interval> outt = get_free_Quantum_Intervals(null,resource.blocked_intervals);
            List<Resource_Interval> outt_typed = new List<Resource_Interval>();
            foreach (Quantum_Interval interv in outt)
            {
                outt_typed.Add(new Resource_Interval(interv.start, interv.stop, resource.resourceID));
            }
            return outt_typed;
        }

        public static List<Quantum_Interval> get_free_Quantum_Intervals(List<Master_Interval> blocked_master_Intervals, List<Resource_Interval> blocked_resource_Intervals)
        {
            List<Quantum_Interval> outt = new List<Quantum_Interval>();
            Day_TimeLine day = new Day_TimeLine();
            Quantum_Interval interv;
            if (blocked_master_Intervals!=null)
            {
                for (int j = 0; j < blocked_master_Intervals.Count(); j++)
                {
                     interv = ((Quantum_Interval)blocked_master_Intervals[(j)]);
                    for (int i = interv.start; i <= interv.stop; i++)
                    {
                        day.bool_quants[i] = false;
                    }
                }
            }
            else
            {
                for (int j = 0; j < blocked_resource_Intervals.Count(); j++)
                {
                     interv = ((Quantum_Interval)blocked_resource_Intervals[(j)]);
                    for (int i = interv.start; i <= interv.stop; i++)
                    {
                        day.bool_quants[i] = false;
                    }
                }
            }
           


           

            Quantum_Interval cur_interval = null;
            for (int i = 0; i < day.bool_quants.Length; i++)
            {
                if (day.bool_quants[i])
                {
                    if (cur_interval == null)
                    {
                        cur_interval = new Quantum_Interval(i);
                    }
                }
                else
                {
                    if (cur_interval != null)
                    {
                        cur_interval.setStop(i - 1);
                        outt.Add(cur_interval);
                        cur_interval = null;
                    }
                }
            }

            if (cur_interval != null)
            {
                cur_interval.setStop(day.bool_quants.Length - 1);
                outt.Add(cur_interval);
                cur_interval = null;
            }


            return outt;
        }

        public static List<Window_Interval> overlap_master_and_resource(Master master, Resource resource)
        {
            List<Window_Interval> outt = new List<Window_Interval>();
            Day_TimeLine day = new Day_TimeLine();
            for (int j = 0; j < master.free_intervals.Count(); j++)
            {
                Master_Interval interv = master.free_intervals[(j)];
                for (int i = interv.start; i <= interv.stop; i++)
                {
                    day.double_bool_quants[i,0] = true;
                }
            }

            for (int j = 0; j < resource.free_intervals.Count(); j++)
            {
                Resource_Interval interv = resource.free_intervals[(j)];
                for (int i = interv.start; i <= interv.stop; i++)
                {
                    day.double_bool_quants[i,1] = true;
                }
            }

            Quantum_Interval cur_interval = null;
            for (int i = 0; i < day.double_bool_quants.Length/2; i++)
            {
                if (day.double_bool_quants[i,0] && day.double_bool_quants[i,1])
                {
                    if (cur_interval == null)
                    {
                        cur_interval = new Quantum_Interval(i);
                    }
                }
                else
                {
                    if (cur_interval != null)
                    {
                        cur_interval.setStop(i - 1);
                        outt.Add(new Window_Interval(cur_interval.start, cur_interval.stop, master.masterID, resource.resourceID));
                        cur_interval = null;
                    }
                }
            }

            if (cur_interval != null)
            {
                cur_interval.setStop(day.bool_quants.Length - 1);
                outt.Add(new Window_Interval(cur_interval.start, cur_interval.stop, master.masterID, resource.resourceID));
                cur_interval = null;
            }


            return outt;
        }

    }









    public class Day
    {
        List<Master> masters;
        List<Resource> resources;
        public string dateString;
        public DateTime day;
        public bool[] bool_flags;
        public object[] obj_mas;
        public List<Window_Interval> window_intervals;


       





        public Day(DateTime day,List<int>masterIds, List<int> resourceIds)
        {
            if (masterIds==null)
            {
                masterIds=new List<int>();
            }
            dateString = day.ToString("dd-MM");
            this.day = day;

            masters=new List<Master>();
            resources = new List<Resource>();

            foreach (int id in masterIds)
            {
                if(Master.check_existance(id,day)) masters.Add(new Master(id,day));
            }


            Resource resource2 = new Resource(2);
            List<Resource_Interval> blocked2 = new List<Resource_Interval>();
            blocked2.Add(new Resource_Interval(0, 3, 2));
            blocked2.Add(new Resource_Interval(5, 8, 2));
            resource2.blocked_intervals = blocked2;
            resource2.free_intervals = Interval_Overlap_Class.get_free_Resource_Intervals(resource2);



            Resource resource3 = new Resource(3);
            blocked2 = new List<Resource_Interval>();
            blocked2.Add(new Resource_Interval(3, 6, 3));
            blocked2.Add(new Resource_Interval(9, 10, 3));
            resource3.blocked_intervals = blocked2;
            resource3.free_intervals = Interval_Overlap_Class.get_free_Resource_Intervals(resource3);

            resources.Add(resource2);
            resources.Add(resource3);

            List<Window_Interval> curent;
            window_intervals = new List<Window_Interval>();

            for (int i = 0; i < masters.Count; i++)
            {
                for (int j = 0; j < resources.Count; j++)
                {
                    Console.WriteLine("overlaping m"+masters[i].masterID+" r"+resources[j].resourceID);
                    curent = Interval_Overlap_Class.overlap_master_and_resource(masters[i], resources[j]);
                    window_intervals.AddRange(curent);
                }
            }


            foreach (Window_Interval prnt in window_intervals)
            {
                prnt.print();
            }
            
            bool_flags = new bool[288];
            obj_mas = new Object[288];
            for (int i = 0; i < 288; i++)
            {
                obj_mas[i] = "X";
            }


            for (int i = 0; i < window_intervals.Count(); i++)
            {
                for (int j = window_intervals[i].start; j <= window_intervals[i].stop; j++)
                {
                    bool_flags[j] = true;
                    obj_mas[j] = "A";
                }
            }
            
        }
    }


    public class GUI_Show_Data
    {
        DataGridView dgv;
        int start;
        int stop;
    }

    //public class GUI_Data
    //{
    //    List<int> indexes;
    //    List<string> times;
    //    DataGridView dgv;
    //    public bool hide_non_work=false;
    //    int start=96;
    //    int stop=240;


    //    public GUI_Data(DataGridView dgv)
    //    {
    //        this.dgv = dgv;
    //    }

    //    public int size;
    //    DataGridView gdv;
    //    public List<Day> days;

    //    public void BuildGui(List<DateTime> dateTimes,List<int> masterIds,List<int> resourceIds)
    //    {
    //        build_Days(dateTimes,masterIds,resourceIds);
    //        fill_DGV();
    //    }

    //    public void build_Days(List<DateTime> dateTimes, List<int> masterIds, List<int> resourceIds)
    //    {
    //        days=new List<Day>();
    //        foreach (DateTime cur_day in dateTimes)
    //        {
    //            days.Add(new Day(cur_day,masterIds,resourceIds));
    //        }
    //    }


    //    public void build_columns()
    //    {
    //        if (size==0)
    //        {
    //            size = 12;
    //        }
    //        const int col = 288;
    //        dgv.Rows.Clear();
    //        dgv.Columns.Clear();
    //        {

    //            DateTime tm = new DateTime(1970, 1, 1, 0, 0, 0);

    //            DataGridViewColumn column = new DataGridViewColumn(new DataGridViewTextBoxCell());
    //            column.HeaderText = "date";
    //            column.DefaultCellStyle.Font=new Font(FontFamily.GenericSansSerif,size);
    //            column.HeaderCell.Style.Font= new Font(FontFamily.GenericSansSerif, size);
    //            column.Frozen = true;
    //            dgv.Columns.Add(column);


    //            if (hide_non_work)
    //            {
    //                tm = tm.AddMinutes(5*start);
    //                for (int i = start; i < stop; i++)
    //                {
    //                    column = new DataGridViewColumn(new DataGridViewTextBoxCell());
    //                    column.HeaderText = tm.ToString("HH:mm");
    //                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
    //                    column.DefaultCellStyle.Font = new Font(FontFamily.GenericSansSerif, size);
    //                    column.HeaderCell.Style.Font = new Font(FontFamily.GenericSansSerif, size);
    //                    dgv.Columns.Add(column);
    //                    tm = tm.AddMinutes(5);
    //                }
    //            }
    //            else
    //            {
    //                for (int i = 1; i < col + 1; i++)
    //                {
    //                    column = new DataGridViewColumn(new DataGridViewTextBoxCell());
    //                    column.HeaderText = tm.ToString("HH:mm");
    //                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
    //                    column.DefaultCellStyle.Font = new Font(FontFamily.GenericSansSerif, size);
    //                    column.HeaderCell.Style.Font = new Font(FontFamily.GenericSansSerif, size);
    //                    dgv.Columns.Add(column);
    //                    tm = tm.AddMinutes(5);
    //                }
    //            }

    //            }
    //        }


    //    public void fill_DGV()
    //    {
    //        const int col = 288;
    //        dgv.Rows.Clear();
    //        if (hide_non_work)
    //        {
    //            if (dgv.ColumnCount != stop-start+1)
    //            {
    //                build_columns();
    //            }
    //        }
    //        else
    //        {
    //            if (dgv.ColumnCount != 289)
    //            {
    //                build_columns();
    //            }
    //        }


    //        dgv.RowCount = days.Count;
    //        for (int i = 0; i < days.Count; i++)
    //        {
    //            dgv.Rows[i].Cells[0].Value = days[i].dateString;


    //            if (hide_non_work)
    //            {
    //                for (int k = start; k < stop ; k++)
    //                {
    //                    int j = k - start+1;
    //                    if (days[i].bool_flags[k])
    //                    {
    //                        dgv.Rows[i].Cells[j].Value = "";
    //                        dgv.Rows[i].Cells[j].Style.BackColor = Color.Green;
    //                    }
    //                    else
    //                    {
    //                        dgv.Rows[i].Cells[j].Value = "X";
    //                        dgv.Rows[i].Cells[j].Style.BackColor = Color.Red;
    //                    }
    //                }
    //            }
    //            else
    //            {
    //                for (int k = 1; k < col + 1; k++)
    //                {
    //                    int j = k - 1;
    //                    if (days[i].bool_flags[j])
    //                    {
    //                        dgv.Rows[i].Cells[k].Value = "";
    //                        dgv.Rows[i].Cells[k].Style.BackColor = Color.Green;
    //                    }
    //                    else
    //                    {
    //                        dgv.Rows[i].Cells[k].Value = "X";
    //                        dgv.Rows[i].Cells[k].Style.BackColor = Color.Red;
    //                    }
    //                }
    //            }

    //        }
    //    }


    //}

     

    public class GUI_Data
    {
        DataGridView dgv;
        public bool hide_non_work = false;
       
        public GUI_Data(DataGridView dgv)
        {
            this.dgv = dgv;
        }

        public int size;
        DataGridView gdv;
        public List<Day> days;

        public void BuildGui(List<DateTime> dateTimes, List<int> masterIds, List<int> resourceIds)
        {
            build_Days(dateTimes, masterIds, resourceIds);
            fill_DGV();
        }

        public void build_Days(List<DateTime> dateTimes, List<int> masterIds, List<int> resourceIds)
        {
            days = new List<Day>();
            foreach (DateTime cur_day in dateTimes)
            {
                days.Add(new Day(cur_day, masterIds, resourceIds));
            }
        }


        public void build_columns()
        {
           
            const int col = 288;
            dgv.Rows.Clear();
            dgv.Columns.Clear();
            {

                DateTime tm = new DateTime(1970, 1, 1, 0, 0, 0);

                DataGridViewColumn column = new DataGridViewColumn(new DataGridViewTextBoxCell());
                column.HeaderText = "date";
                //column.DefaultCellStyle.Font = new Font(FontFamily.GenericSansSerif, size);
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                column.HeaderCell.Style.Alignment=DataGridViewContentAlignment.BottomCenter;
                column.Frozen = true;
                dgv.Columns.Add(column);

                {
                    for (int i = 1; i < col + 1; i++)
                    {
                        column = new DataGridViewColumn(new DataGridViewTextBoxCell());
                        column.HeaderText = tm.Hour + "\n" + tm.ToString("mm");
                        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                        
                        dgv.Columns.Add(column);
                        tm = tm.AddMinutes(5);
                    }
                }

            }
        }


        public void fill_DGV()
        {
            const int col = 288;
            dgv.Rows.Clear();
            {
                if (dgv.ColumnCount != 288+1)
                {
                    build_columns();
                }
            }


            dgv.RowCount = days.Count;
            for (int i = 0; i < days.Count; i++)
            {
                dgv.Rows[i].Cells[0].Value = days[i].dateString;



                {
                    for (int k = 1; k < col + 1; k++)
                    {
                        int j = k - 1;
                        if (days[i].bool_flags[j])
                        {
                            dgv.Rows[i].Cells[k].Value = "";
                            dgv.Rows[i].Cells[k].Style.BackColor = Color.Green;
                        }
                        else
                        {
                            dgv.Rows[i].Cells[k].Value = "";
                            dgv.Rows[i].Cells[k].Style.BackColor = Color.Red;
                        }
                    }
                }

            }
        }


    }
    public class Master
    {
        public  int masterID;
        public List<Master_Interval> blocked_intervals;
        public List<Master_Interval> free_intervals;
        

        public Master(int masterID,DateTime day)
        {
            this.masterID = masterID;
            List<Master_Interval> blocked = new List<Master_Interval>();
            string master_day_section =
                " SELECT master_day_section.id,master_day_section.start,master_day_section.stop from master_day_section " +
                " inner join master_day on master_day.id=master_day_section.master_day_id" +
                " WHERE (" +
                " (master_day_section.status_id IN (SELECT master_day_section_status.id from master_day_section_status where master_day_section_status.availability=0) ) " +
                " AND " +
                " (master_day_section.start between '" + Date_Converter.DateToStartDay(day) + "' and '" + Date_Converter.DateToStopDay(day) + "') " +
                //and '"+ Date_Converter.DateToStopDay(day) + "'))";
                " AND " +
                " (master_day.master_id="+this.masterID+"))";
                SQL cl=new SQL();
            cl.ReadValues(master_day_section);
            while (cl.sqlDataReader.Read())
            {
                blocked.Add(new Master_Interval(cl.getDateTime(1),cl.getDateTime(2), this.masterID));
            }
            this.blocked_intervals = blocked;
            this.free_intervals = Interval_Overlap_Class.get_free_Master_Intervals(this);
        }

        public static bool check_existance(int id, DateTime day)
        {
            string zap =
                "select count(*) from master_day where ((master_day.master_id=0)and(master_day.date ='2016-11-17')and(master_day.status_id in (SELECT master_day_status.id from master_day_status where master_day_status.availability=1)))";
            int col = SQL.ReadValueInt32(zap);
            if (col == 0) { return false;}
            else { return true;}
        }

        public void print()
        {
            Console.WriteLine("master " + masterID);
            Console.WriteLine("blocked");
            foreach(Master_Interval fr in blocked_intervals) { fr.print(); }
            Console.WriteLine("free");
            foreach (Master_Interval fr in free_intervals) { fr.print(); }
            Console.WriteLine("\n\n");
        }
    }


    public class Resource
    {
        public List<Resource_Interval> blocked_intervals;
        public List<Resource_Interval> free_intervals;
        public int resourceID;

        public Resource(int resourceID)
        {
            this.resourceID = resourceID;
        }

        public void print()
        {
            Console.WriteLine("resource " + resourceID);
            Console.WriteLine("blocked");
            foreach (Resource_Interval fr in blocked_intervals) { fr.print(); }
            Console.WriteLine("free");
            foreach (Resource_Interval fr in free_intervals) { fr.print(); }
            Console.WriteLine("\n\n");
        }
    }








}
