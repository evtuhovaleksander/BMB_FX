using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMB_FX.CoordinationWindow.Search_Window;

namespace BMB_FX
{
    public class Date_Converter
    {
        public static int Date_To_Index(DateTime date)
        {

            TimeSpan span = date - date.Date;
            return (int)span.TotalMinutes / 5;

        }

        public static string DateToStartDay(DateTime date)
        {
            return date.Date.ToString("yyyy-MM-dd HH:mm:ss");
        }

        public static string DateToStopDay(DateTime date)
        {
            return date.Date.Add(new TimeSpan(23, 59, 59)).ToString("yyyy-MM-dd HH:mm:ss");
        }
    }



    public class Day_TimeLine
    {
        public bool[] bool_quants;
        public bool[,] double_bool_quants;

        public Day_TimeLine()
        {
            this.bool_quants = new bool[288];
            this.double_bool_quants = new bool[288, 2];
            for (int i = 0; i < bool_quants.Length; i++)
            {
                bool_quants[i] = true;
            }
        }

    }







    public class Interval : IComparable<Interval>
    {
        public int start;
        public int stop;
        public int length;
        public DateTime start_date;
        public DateTime stop_date;

        public Interval(DateTime start, DateTime stop)
        {
            this.start = Date_Converter.Date_To_Index(start);
            this.stop = Date_Converter.Date_To_Index(stop);
            this.length = this.stop - this.start + 1;
            start_date = start;
            stop_date = stop;
        }

        public Interval(int start, int stop, DateTime day)
        {
            this.start = start;
            this.stop = stop;
            this.length = this.stop - this.start + 1;
            start_date = day.AddMinutes(5 * start);
            stop_date = day.AddMinutes(5 * stop);
        }


        public Interval(int start, DateTime startDate)
        {
            this.start = start;
            this.start_date = startDate;
        }



        public void setStop(int stop)
        {
            this.stop = stop;
            this.length = stop - start + 1;
            this.stop_date = this.start_date.AddMinutes(5 * length);
        }


        public int CompareTo(Interval other)
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


    public class Resource_Interval : Interval
    {
        public int resouceID;


        public Resource_Interval(int start, int stop, DateTime day, int resouceId) : base(start, stop, day)
        {
            resouceID = resouceId;
        }

        public Resource_Interval(DateTime start, DateTime stop, int resouceId) : base(start, stop)
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
        public int masterID;

        public Master_Interval(int start, int stop, DateTime day, int masterId) : base(start, stop, day)
        {
            masterID = masterId;
        }

        public Master_Interval(DateTime start, DateTime stop, int masterId) : base(start, stop)
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

        
        public int masterId;
        public int resourceId;
        public bool enabled = true;

        public Window_Interval(int start, int stop, DateTime day, int master, int reso) : base(start, stop, day)
        {
            
            masterId = master;
            resourceId = reso;
            enabled = true;
        }

        public Window_Interval(Window_Interval old,int start,int stop):base(start,stop,old.start_date.Date)
        {
            masterId = old.masterId;
            resourceId = old.resourceId;

            enabled = true;
        }

        public bool in_window(int i)
        {
            return ((i >= start) && (i <= stop));
        }

        public void print()
        {
            Console.WriteLine("WindowInterval start: " + start + "   stop: " + stop + "   length: " + length + "  resourceID: " + resourceId + "   masterID: " + masterId);
        }
       
    }

    public class Operation_Window_Interval : Window_Interval
    {
        public Operation_Window_Interval(Window_Interval old, int start, int stop, bool hasPrevious, int delayTillPrevious) : base(old, start, stop)
        {
            has_previous = hasPrevious;
            delay_till_previous = delayTillPrevious;
            parent = old;
            start_penalty = start - old.start - 1;
            stop_penalty = old.stop - stop - 1;
        }

        public bool has_previous;
        public int delay_till_previous;
        public int start_penalty;
        public int stop_penalty;
        
        Window_Interval parent;

        
    }

    public class Sequence
    {
        public Sequence(int length)
        {
            S=new Operation_Window_Interval[length];
            
        }

        public Operation_Window_Interval[] S;
        public int Penalty;

        public bool is_Valid()
        {
           
            if (S.Length > 1)
            {
                for (int i = 0; i < S.Length; i++)
                {
                    if (S[i].has_previous)
                    {
                        if (S[i].delay_till_previous >= Master_Mind.max_wait_time) return false;
                    }
                }
            }
            return true;
        }

        public void calc_Penalty()
        {
            Penalty = 0;
            List<int> masters=new List<int>();
            List<int> resources=new List<int>();
            for (int i = 0; i < S.Length; i++)
            {
                Operation_Window_Interval curInterval = S[i];
                if (curInterval.has_previous)
                {
                    Penalty += curInterval.delay_till_previous*Master_Mind.wait_penalty_coef;
                }
                Penalty += (curInterval.start_penalty%Master_Mind.delay_cycle)*Master_Mind.delay_penalty_coef;
                Penalty += (curInterval.stop_penalty % Master_Mind.delay_cycle) * Master_Mind.delay_penalty_coef;
                if (!masters.Contains(curInterval.masterId)) masters.Add(curInterval.masterId);
                if (!masters.Contains(curInterval.resourceId)) resources.Add(curInterval.resourceId);
            }
            Penalty += masters.Count*Master_Mind.master_penalty;
            Penalty += resources.Count * Master_Mind.resource_penalty;
        }
    }







    public class Master
    {
        public int masterID;
        public List<Master_Interval> blocked_intervals;
        public List<Master_Interval> free_intervals;
        public DateTime day;

        public Master(int masterID, DateTime day)
        {
            this.day = day;
            this.masterID = masterID;
            List<Master_Interval> blocked = new List<Master_Interval>();
            string master_day_block =
                " SELECT mds.ID,mds.Start,mds.Stop from master_day_block mds" +
                " inner join master_day md on md.ID=mds.MasterDay_ID" +
                " WHERE (" +


                " (mds.Start between '" + Date_Converter.DateToStartDay(day) + "' and '" + Date_Converter.DateToStopDay(day) + "') " +
                " AND " +
                " (md.Master_ID=" + this.masterID + "))";
            SQL cl = new SQL();
            cl.ReadValues(master_day_block);
            while (cl.sqlDataReader.Read())
            {
                blocked.Add(new Master_Interval(cl.getDateTime(1), cl.getDateTime(2), this.masterID));
            }
            cl.Close_Connection();

            master_day_block =
                            " SELECT o.ID,o.Gap_Start,o.Gap_Stop from operation o" +
                            " " +
                            " WHERE (" +


                            " (o.Gap_Start between '" + Date_Converter.DateToStartDay(day) + "' and '" + Date_Converter.DateToStopDay(day) + "') " +
                            " AND " +
                            " (o.Master_ID=" + this.masterID + "))";
            cl = new SQL();
            cl.ReadValues(master_day_block);
            while (cl.sqlDataReader.Read())
            {
                blocked.Add(new Master_Interval(cl.getDateTime(1), cl.getDateTime(2), this.masterID));
            }
            cl.Close_Connection();



            this.blocked_intervals = blocked;
            this.free_intervals = Overlapper.get_free_Intervals(this);



            string master_day_section_old =
                " SELECT master_day_section.id,master_day_section.start,master_day_section.stop from master_day_section " +
                " inner join master_day on master_day.id=master_day_section.master_day_id" +
                " WHERE (" +
                " (master_day_section.status_id IN (SELECT master_day_section_status.id from master_day_section_status where master_day_section_status.availability=0) ) " +
                " AND " +
                " (master_day_section.start between '" + Date_Converter.DateToStartDay(day) + "' and '" + Date_Converter.DateToStopDay(day) + "') " +
                " AND " +
                " (master_day.Master_ID=" + this.masterID + "))";


        }

        public static bool check_existance(int id, DateTime day)
        {
            string zap =
                "select count(*) from master_day where ((master_day.master_id=" + id + ")and(master_day.date ='" +
                day.ToString("yyyy-MM-dd") + "'))";//"and(master_day.status_id in (SELECT master_day_status.id from master_day_status where master_day_status.availability=1)))");
            int col = SQL.ReadValueInt32(zap);
            if (col == 0) { return true; }
            else { return false; } // ожидаем корекции
        }

        public void print()
        {
            Console.WriteLine("master " + masterID);
            Console.WriteLine("blocked");
            foreach (Master_Interval fr in blocked_intervals) { fr.print(); }
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
        public DateTime day;
        public Resource(int resourceID)
        {
            this.resourceID = resourceID;
        }

        public Resource(int resourceID, DateTime day)
        {
            this.day = day;
            this.resourceID = resourceID;
            List<Resource_Interval> blocked = new List<Resource_Interval>();
            string resource_day_section =
                " SELECT rds.ID,rds.Start,rds.Stop from resource_day_block rds" +
                " inner join resource_day rd on rd.ID=rds.ResourceDay_id" +
                " WHERE (" +
                " " +
                "  " +
                " (rds.Start between '" + Date_Converter.DateToStartDay(day) + "' and '" + Date_Converter.DateToStopDay(day) + "') " +
                //and '"+ Date_Converter.DateToStopDay(day) + "'))";
                " AND " +
                " (rd.Resource_ID=" + this.resourceID + "))";
            SQL cl = new SQL();
            cl.ReadValues(resource_day_section);
            while (cl.sqlDataReader.Read())
            {
                blocked.Add(new Resource_Interval(cl.getDateTime(1), cl.getDateTime(2), this.resourceID));
            }
            cl.Close_Connection();


            resource_day_section =
               " SELECT o.ID,o.Gap_Start,o.Gap_Stop from operation o" +
               " " +
               " WHERE (" +
               " " +
               "  " +
               " (o.Gap_Start between '" + Date_Converter.DateToStartDay(day) + "' and '" + Date_Converter.DateToStopDay(day) + "') " +
               //and '"+ Date_Converter.DateToStopDay(day) + "'))";
               " AND " +
               " (o.Resource_ID=" + this.resourceID + "))";
            cl = new SQL();
            cl.ReadValues(resource_day_section);
            while (cl.sqlDataReader.Read())
            {
                blocked.Add(new Resource_Interval(cl.getDateTime(1), cl.getDateTime(2), this.resourceID));
            }
            cl.Close_Connection();

            this.blocked_intervals = blocked;
            this.free_intervals = Overlapper.get_free_Intervals(this);
        }

        public static bool check_existance(int id, DateTime day)
        {
            string zap =
                "select count(*) from resource_day where ((resource_day.resource_id=" + id + ")and(resource_day.date ='" + day.ToString("yyyy-MM-dd") + "'))";
            int col = SQL.ReadValueInt32(zap);
            if (col == 0)
            {
                return true;
            }
            else
            {
                return false; // проверить код
            }
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




//public Window_Interval overlap(Interval master_interval, Interval resource_interval)
//{
//    Quantum_Interval outt = new Quantum_Interval(0, 0);
//    Quantum_Interval long_i;
//    Quantum_Interval short_i;
//    if (master_interval.length > resource_interval.length) { long_i = master_interval; short_i = resource_interval; }
//    else { long_i = resource_interval; short_i = master_interval; };


//    bool stop;
//    bool start;
//    bool left = false;
//    bool right = false;
//    bool center = false;
//    // center
//    stop = short_i.stop <= long_i.stop;
//    start = short_i.start >= long_i.start;
//    if (start && stop) center = true;
//    //left
//    start = short_i.start < long_i.stop;
//    stop = short_i.stop >= long_i.stop;
//    if (start && stop) left = true;
//    //rightt
//    start = short_i.start <= long_i.start;
//    stop = short_i.stop > long_i.start;
//    if (start && stop) right = true;
//    if (center) outt = new Quantum_Interval(short_i.start, short_i.stop);
//    if (left) outt = new Quantum_Interval(short_i.start, long_i.stop);
//    if (right) outt = new Quantum_Interval(long_i.start, short_i.stop);

//    if (outt.length != 0) { return outt; } else { return null; }
//}





//public static List<Quantum_Interval> get_free_Quantum_Intervals(List<Master_Interval> blocked_master_Intervals, List<Resource_Interval> blocked_resource_Intervals)
//{
//    List<Quantum_Interval> outt = new List<Quantum_Interval>();
//    Day_TimeLine day = new Day_TimeLine();
//    Quantum_Interval interv;
//    if (blocked_master_Intervals!=null)
//    {
//        for (int j = 0; j < blocked_master_Intervals.Count(); j++)
//        {
//             interv = ((Quantum_Interval)blocked_master_Intervals[(j)]);
//            for (int i = interv.start; i <= interv.stop; i++)
//            {
//                day.bool_quants[i] = false;
//            }
//        }
//    }
//    else
//    {
//        for (int j = 0; j < blocked_resource_Intervals.Count(); j++)
//        {
//             interv = ((Quantum_Interval)blocked_resource_Intervals[(j)]);
//            for (int i = interv.start; i <= interv.stop; i++)
//            {
//                day.bool_quants[i] = false;
//            }
//        }
//    }





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

//    public class Day_Operation
//    {
//        //List<Master> masters;
//        //List<Resource> resources;

//        //public DateTime day;
//        //public List<Window_Interval> window_intervals;

//        //public Day_Operation(DateTime day, List<int> masterIds, List<int> resourceIds)
//        //{
//        //    this.day = day;

//        //    if (masterIds == null) masterIds = new List<int>();
//        //    if (resourceIds == null) resourceIds = new List<int>();


//        //    masters = new List<Master>();
//        //    foreach (int id in masterIds)
//        //    {
//        //        if (Master.check_existance(id, day)) masters.Add(new Master(id, day));
//        //    }

//        //    resources = new List<Resource>();
//        //    foreach (int id in resourceIds)
//        //    {
//        //        if (Resource.check_existance(id, day)) resources.Add(new Resource(id, day));
//        //    }

//        //    List<Window_Interval> curent;
//        //    window_intervals = new List<Window_Interval>();

//        //    for (int i = 0; i < masters.Count; i++)
//        //    {
//        //        for (int j = 0; j < resources.Count; j++)
//        //        {
//        //            Console.WriteLine("overlaping m" + masters[i].masterID + " r" + resources[j].resourceID);
//        //            curent = Interval_Overlap_Class.overlap_master_and_resource(masters[i], resources[j]);
//        //            window_intervals.AddRange(curent);
//        //        }
//        //    }


//        //    foreach (Window_Interval prnt in window_intervals)
//        //    {
//        //        prnt.print();
//        //    }




//        //}

//        public static List<Window_Interval> get_window_intervals(DateTime day, List<int> masterIds,
//            List<int> resourceIds)
//        {


//            if (masterIds == null) masterIds = new List<int>();
//            if (resourceIds == null) resourceIds = new List<int>();


//            List<Master> masters  = new List<Master>();
//            foreach (int id in masterIds)
//            {
//                if (Master.check_existance(id, day)) masters.Add(new Master(id, day));
//            }

//            List<Resource> resources = new List<Resource>();
//            foreach (int id in resourceIds)
//            {
//                if (Resource.check_existance(id, day)) resources.Add(new Resource(id, day));
//            }

//            List<Window_Interval> curent;
//            List<Window_Interval>  window_intervals = new List<Window_Interval>();

//            for (int i = 0; i < masters.Count; i++)
//            {
//                for (int j = 0; j < resources.Count; j++)
//                {
//                    Console.WriteLine("overlaping m" + masters[i].masterID + " r" + resources[j].resourceID);
//                    curent = Interval_Overlap_Class.overlap_master_and_resource(masters[i], resources[j]);
//                    window_intervals.AddRange(curent);
//                }
//            }


//            foreach (Window_Interval prnt in window_intervals)
//            {
//                prnt.print();
//            }



//return window_intervals;
//        }

//    }







//public class Day_Old
//{
//    List<Master> masters;
//    List<Resource> resources;
//    public string dateString;
//    public DateTime day;
//    public bool[] bool_flags;
//    public bool[] bool_length_flags;
//    public object[] obj_mas;
//    public List<Window_Interval> window_intervals;
//    private int length;





//    //public Day_Old(DateTime day, List<int> masterIds, List<int> resourceIds,int len)
//    //{
//    //    this.day = day;
//    //    dateString = day.ToString("dd-MM");
//    //    this.length = len;

//    //    if (masterIds == null) masterIds = new List<int>();
//    //    if (resourceIds == null) resourceIds = new List<int>();


//    //    masters = new List<Master>();
//    //    foreach (int id in masterIds)
//    //    {
//    //        if (Master.check_existance(id, day)) masters.Add(new Master(id, day));
//    //    }

//    //    resources = new List<Resource>();
//    //    foreach (int id in resourceIds)
//    //    {
//    //        if (Resource.check_existance(id, day)) resources.Add(new Resource(id, day));
//    //    }

//    //    List<Window_Interval> curent;
//    //    window_intervals = new List<Window_Interval>();

//    //    for (int i = 0; i < masters.Count; i++)
//    //    {
//    //        for (int j = 0; j < resources.Count; j++)
//    //        {
//    //            Console.WriteLine("overlaping m" + masters[i].masterID + " r" + resources[j].resourceID);
//    //            curent = Interval_Overlap_Class.overlap_master_and_resource(masters[i], resources[j]);
//    //            window_intervals.AddRange(curent);
//    //        }
//    //    }


//    //    foreach (Window_Interval prnt in window_intervals)
//    //    {
//    //        prnt.print();
//    //    }

//    //    rebuild_bool_mas(length);

//    //    // булевы флаги


//    //}

//    public void rebuild_bool_mas(int length)
//    {
//        bool_flags = new bool[288];
//        bool_length_flags = new bool[288];
//        obj_mas = new Object[288];
//        for (int i = 0; i < 288; i++)
//        {
//            obj_mas[i] = "X";
//        }


//        for (int i = 0; i < window_intervals.Count(); i++)
//        {
//            if (window_intervals[i].enabled)
//            {
//                for (int j = window_intervals[i].start; j <= window_intervals[i].stop; j++)
//                {
//                    bool_flags[j] = true;
//                    obj_mas[j] = "A";
//                }
//                for (int j = window_intervals[i].stop-length+2; j <= window_intervals[i].stop; j++)
//                {
//                    if (j >= 0 && j < bool_flags.Length)
//                    {
//                        bool_length_flags[j] = true;

//                    }
//                }
//            }

//        }
//    }

//}


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
//    public List<Day_Old> days;

//    public void BuildGui(List<DateTime> dateTimes,List<int> masterIds,List<int> resourceIds)
//    {
//        build_Days(dateTimes,masterIds,resourceIds);
//        fill_DGV();
//    }

//    public void build_Days(List<DateTime> dateTimes, List<int> masterIds, List<int> resourceIds)
//    {
//        days=new List<Day_Old>();
//        foreach (DateTime cur_day in dateTimes)
//        {
//            days.Add(new Day_Old(cur_day,masterIds,resourceIds));
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




//public Day_Old(DateTime day,List<int>masterIds, List<int> resourceIds)
//{
//    if (masterIds==null)
//    {
//        masterIds=new List<int>();
//    }
//    dateString = day.ToString("dd-MM");
//    this.day = day;

//    masters=new List<Master>();
//    resources = new List<Resource>();

//    foreach (int id in masterIds)
//    {
//        if(Master.check_existance(id,day)) masters.Add(new Master(id,day));
//    }






//    Resource resource2 = new Resource(2);
//    List<Resource_Interval> blocked2 = new List<Resource_Interval>();
//    blocked2.Add(new Resource_Interval(0, 3, 2));
//    blocked2.Add(new Resource_Interval(5, 8, 2));
//    resource2.blocked_intervals = blocked2;
//    resource2.free_intervals = Interval_Overlap_Class.get_free_Resource_Intervals(resource2);



//    Resource resource3 = new Resource(3);
//    blocked2 = new List<Resource_Interval>();
//    blocked2.Add(new Resource_Interval(3, 6, 3));
//    blocked2.Add(new Resource_Interval(9, 10, 3));
//    resource3.blocked_intervals = blocked2;
//    resource3.free_intervals = Interval_Overlap_Class.get_free_Resource_Intervals(resource3);


//    resources.Add(resource2);
//    resources.Add(resource3);







//    List<Window_Interval> curent;
//    window_intervals = new List<Window_Interval>();

//    for (int i = 0; i < masters.Count; i++)
//    {
//        for (int j = 0; j < resources.Count; j++)
//        {
//            Console.WriteLine("overlaping m"+masters[i].masterID+" r"+resources[j].resourceID);
//            curent = Interval_Overlap_Class.overlap_master_and_resource(masters[i], resources[j]);
//            window_intervals.AddRange(curent);
//        }
//    }


//    foreach (Window_Interval prnt in window_intervals)
//    {
//        prnt.print();
//    }

//    bool_flags = new bool[288];
//    obj_mas = new Object[288];
//    for (int i = 0; i < 288; i++)
//    {
//        obj_mas[i] = "X";
//    }


//    for (int i = 0; i < window_intervals.Count(); i++)
//    {
//        for (int j = window_intervals[i].start; j <= window_intervals[i].stop; j++)
//        {
//            bool_flags[j] = true;
//            obj_mas[j] = "A";
//        }
//    }

//}



//public class GUI_Show_Data
//{
//    DataGridView dgv;
//    int start;
//    int stop;
//}