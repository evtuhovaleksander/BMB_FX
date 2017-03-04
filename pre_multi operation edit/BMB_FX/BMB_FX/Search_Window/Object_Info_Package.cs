using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMB_FX.ORM;
using System.Drawing;

namespace BMB_FX
{
    public class Master_Gui
    {
        DataGridView dgv;
        public Dictionary<string, int> Column_To_ID;
        public Dictionary<int, string> ID_To_Column;
        List<Master_Info> masters;
        public List<int> masterIds;
        public Master_Gui(int serviceId, DataGridView dgv)
        {

            masters = new List<Master_Info>();

            List<int> ids = Master_ORM.get_id_where_service(serviceId);
            foreach (int tm in ids)
            {
                masters.Add(new Master_Info(tm));
            }

            this.dgv = dgv;

            this.dgv.Rows.Clear();
            this.dgv.Columns.Clear();

            Column_To_ID = new Dictionary<string, int>();
            ID_To_Column = new Dictionary<int, string>();



            DataGridViewColumn tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
            tmp.HeaderText = "id";
            this.dgv.Columns.Add(tmp);
            Column_To_ID.Add("ID", 0);
            ID_To_Column.Add(0, "ID");

            tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
            tmp.HeaderText = "Main_Index";
            this.dgv.Columns.Add(tmp);
            Column_To_ID.Add("Main_Index", 1);
            ID_To_Column.Add(1, "Main_Index");

            DataGridViewCheckBoxColumn tmp2 = new DataGridViewCheckBoxColumn();
            tmp2.Name = "MasterSelecter";
            tmp2.HeaderText = "MasterSelecter";
            this.dgv.Columns.Add(tmp2);
            Column_To_ID.Add("MasterSelecter", 2);
            ID_To_Column.Add(2, "MasterSelecter");


            this.dgv.RowCount = masters.Count;
            for (int i = 0; i < masters.Count; i++)
            {
                this.dgv.Rows[i].Cells[Column_To_ID["ID"]].Value = masters[i].master_id;
                this.dgv.Rows[i].Cells[Column_To_ID["Main_Index"]].Value = masters[i].master_id;
                this.dgv.Rows[i].Cells[Column_To_ID["MasterSelecter"]].Value = false;
            }


        }

        public void check_selected(int ind)
        {
            masterIds = new List<int>();

            masters[ind].selected = !masters[ind].selected;
            dgv.Rows[ind].Cells[Column_To_ID["MasterSelecter"]].Value = masters[ind].selected;


            for (int i = 0; i < masters.Count; i++)
            {

                if (masters[i].selected)
                {
                    masterIds.Add(masters[i].master_id);
                }
            }

        }

    }

    public class Resource_Gui
    {
        DataGridView dgv;
        public Dictionary<string, int> Column_To_ID;
        public Dictionary<int, string> ID_To_Column;
        List<Resource_Info> resource;
        public List<int> resourceIds;
        public Resource_Gui(int serviceId, DataGridView dgv)
        {

            resource = new List<Resource_Info>();

            List<int> ids = Resource_ORM.get_id_where_service(serviceId);
            foreach (int tm in ids)
            {
                resource.Add(new Resource_Info(tm));
            }

            this.dgv = dgv;

            this.dgv.Rows.Clear();
            this.dgv.Columns.Clear();

            Column_To_ID = new Dictionary<string, int>();
            ID_To_Column = new Dictionary<int, string>();



            DataGridViewColumn tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
            tmp.HeaderText = "id";
            this.dgv.Columns.Add(tmp);
            Column_To_ID.Add("ID", 0);
            ID_To_Column.Add(0, "ID");



            DataGridViewCheckBoxColumn tmp2 = new DataGridViewCheckBoxColumn();
            tmp2.Name = "ResourceSelecter";
            tmp2.HeaderText = "ResourceSelecter";
            this.dgv.Columns.Add(tmp2);
            Column_To_ID.Add("ResourceSelecter", 1);
            ID_To_Column.Add(1, "ResourceSelecter");


            this.dgv.RowCount = resource.Count;
            for (int i = 0; i < resource.Count; i++)
            {
                this.dgv.Rows[i].Cells[Column_To_ID["ID"]].Value = resource[i].resource_id;

                this.dgv.Rows[i].Cells[Column_To_ID["ResourceSelecter"]].Value = false;
            }


        }

        public void check_selected(int ind)
        {
            resourceIds = new List<int>();

            resource[ind].selected = !resource[ind].selected;
            dgv.Rows[ind].Cells[Column_To_ID["ResourceSelecter"]].Value = resource[ind].selected;


            for (int i = 0; i < resource.Count; i++)
            {

                if (resource[i].selected)
                {
                    resourceIds.Add(resource[i].resource_id);
                }
            }

        }


    }




    public class TimeLine_Gui
    {
        public DataGridView dgv;
        public bool hide_non_work = false;
        public int length;
        public TimeLine_Gui(DataGridView dgv,int leng)
        {
            this.dgv = dgv;
            this.length = leng;
        }


        public void resize_dgv(int s)
        {
            if (dgv != null)
            {
                if (dgv.ColumnCount != 289) build_columns(s);
            }
            for (int i = 1; i < 289; i++)
            {

               

                if ((i - 1)%12 != 0)
                {
                    dgv.Columns[i].HeaderCell.Style.Font = new Font(FontFamily.GenericSansSerif, s);
                }
                else
                {
                    dgv.Columns[i].HeaderCell.Style.Font = new Font(FontFamily.GenericSansSerif, size);
                }
            }
        }

        public int size;
        DataGridView gdv;
        public List<Day> days;

        public void BuildGui(List<DateTime> dateTimes, List<int> masterIds, List<int> resourceIds,bool hide,int size)
        {
            build_Days(dateTimes, masterIds, resourceIds);
            fill_DGV(hide,size);
        }

        public void build_Days(List<DateTime> dateTimes, List<int> masterIds, List<int> resourceIds)
        {
            days = new List<Day>();
            foreach (DateTime cur_day in dateTimes)
            {
                days.Add(new Day(cur_day, masterIds, resourceIds, length));
            }
        }


       

        public void build_columns(int size_m)
        {

            const int col = 288;
            dgv.Rows.Clear();
            dgv.Columns.Clear();

            size = 8;
            DateTime tm = new DateTime(1970, 1, 1, 0, 0, 0);

            DataGridViewColumn column = new DataGridViewColumn(new DataGridViewTextBoxCell());
            column.HeaderText = "date";
            column.DefaultCellStyle.Font = new Font(FontFamily.GenericSansSerif, size);
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
            column.Frozen = true;

            dgv.Columns.Add(column);
            
                for (int i = 1; i < col + 1; i++)
                {
                    
                    column = new DataGridViewColumn(new DataGridViewTextBoxCell());

                    if ((i - 1)%12 != 0)
                    {
                        column.HeaderCell.Style.Font = new Font(FontFamily.GenericSansSerif, size_m);
                    }
                    else
                    {
                    column.HeaderCell.Style.Font = new Font(FontFamily.GenericSansSerif, size);
                }
                    column.HeaderText = tm.Hour + "\n-\n" + tm.ToString("mm");
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

                dgv.Columns.Add(column);
                    tm = tm.AddMinutes(5);
                }
        }


        public void fill_DGV(bool hide_m,int size)
        {
           
            const int col = 288;
            
            dgv.Rows.Clear();
            {
                if (dgv.ColumnCount != 288 + 1)
                {
                    build_columns(size);
                }
            }

            for (int i = 0; i < col + 1; i++) dgv.Columns[i].Visible = true;
            dgv.RowCount = days.Count;
            for (int i = 0; i < days.Count; i++)
            {
                dgv.Rows[i].Cells[0].Value = days[i].dateString;
                days[i].rebuild_bool_mas(length);
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

                        if(days[i].bool_length_flags[j])
                        {
                            dgv.Rows[i].Cells[k].Value = "";
                            dgv.Rows[i].Cells[k].Style.BackColor = Color.Tomato;
                        }
                    }
                }
                

            }

            if(hide_m)
            for (int k = 1; k < col + 1; k++)
            {
                int j = k - 1;
                bool hide = true;
                for (int i = 0; i < days.Count; i++)
                {
                    bool a =!days[i].bool_flags[j];
                    bool b = days[i].bool_length_flags[j];
                    hide = hide &&( a||b);
                    if (days[i].bool_length_flags[j])
                    {
                    }
                }
                if (!hide)
                {
             //       break;
                }
                else
                {
                    dgv.Columns[k].Visible = false;
                }
            }
            //for (int k = col; k > 0; k--)
            //{
            //    int j = k - 1;
            //    bool hide = false;
            //    for (int i = 0; i < days.Count; i++)
            //    {
            //        hide = hide || days[i].bool_flags[j];
            //    }
            //    if (hide)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        dgv.Columns[k-1].Visible = false;
            //    }
            //}




        }


    }

    public class Window_Interval_ALL_Gui
    {
        DataGridView dgv;
        private TimeLine_Gui timelineGui;

        public Window_Interval_ALL_Gui(DataGridView dgv, TimeLine_Gui timeline)
        {
            this.dgv = dgv;
            timelineGui = timeline;
            Fill_Windows_All_Dgv();
           
        }

        public void Fill_Windows_All_Dgv()
        {



            List<Window_Interval> windowIntervals=new List<Window_Interval>();
            foreach (Day vr in timelineGui.days)
            {
                windowIntervals.AddRange(vr.window_intervals);
            }

            if (dgv.ColumnCount != 9)
            {
                this.dgv.Rows.Clear();
                this.dgv.Columns.Clear();

                DataGridViewColumn tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
                tmp.HeaderText = "id";
                this.dgv.Columns.Add(tmp);

                tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
                tmp.HeaderText = "master_ID";
                this.dgv.Columns.Add(tmp);

                tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
                tmp.HeaderText = "resource_ID";
                this.dgv.Columns.Add(tmp);

                tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
                tmp.HeaderText = "start";
                this.dgv.Columns.Add(tmp);

                tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
                tmp.HeaderText = "stop";
                this.dgv.Columns.Add(tmp);

                tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
                tmp.HeaderText = "star_index";
                this.dgv.Columns.Add(tmp);

                tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
                tmp.HeaderText = "stop_index";
                this.dgv.Columns.Add(tmp);

                tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
                tmp.HeaderText = "length";
                this.dgv.Columns.Add(tmp);


                DataGridViewCheckBoxColumn tmp2 = new DataGridViewCheckBoxColumn();
                tmp2.HeaderText = "select";
                this.dgv.Columns.Add(tmp2);

               


            }


            if (windowIntervals.Count != 0)
            {
                this.dgv.RowCount = windowIntervals.Count;
            }
            else
            {
                this.dgv.Rows.Clear();
            }

            for (int i = 0; i < windowIntervals.Count; i++)
            {
                this.dgv.Rows[i].Cells[0].Value = i;
                this.dgv.Rows[i].Cells[1].Value = windowIntervals[i].masterId;
                this.dgv.Rows[i].Cells[2].Value = windowIntervals[i].resourceId;
                this.dgv.Rows[i].Cells[3].Value = windowIntervals[i].start_date;
                this.dgv.Rows[i].Cells[4].Value = windowIntervals[i].stop_date;
                this.dgv.Rows[i].Cells[5].Value = windowIntervals[i].start;
                this.dgv.Rows[i].Cells[6].Value = windowIntervals[i].stop;
                this.dgv.Rows[i].Cells[7].Value = windowIntervals[i].length;
                this.dgv.Rows[i].Cells[8].Value = windowIntervals[i].enabled;
            }
        }

        public void check_selected(bool hide,int size)
        {

            int index = 0;
            for (int i = 0; i < timelineGui.days.Count; i++)
            {
                for (int j = 0; j < timelineGui.days[i].window_intervals.Count; j++)
                {
                    if (Convert.ToBoolean(dgv.Rows[index].Cells[0].Value) == true)
                    {
                        timelineGui.days[i].window_intervals[j].enabled = true;
                    }
                    else
                    {
                        timelineGui.days[i].window_intervals[j].enabled = false;
                    }
                    index++;
                }
            }
            Fill_Windows_All_Dgv();
            timelineGui.fill_DGV(hide,size);
        }
        public void set_selected(int row,bool hide,int size)
        {

            int index = 0;
            for (int i = 0; i < timelineGui.days.Count; i++)
            {
                for (int j = 0; j < timelineGui.days[i].window_intervals.Count; j++)
                {
                    if (row==index)
                    {
                        timelineGui.days[i].window_intervals[j].enabled = !timelineGui.days[i].window_intervals[j].enabled;
                    }
                  
                    index++;
                }
            }
            Fill_Windows_All_Dgv();
            timelineGui.fill_DGV(hide, size);
        }
    }

    public class Window_Interval_Specified_Gui
    {
        public struct windowInterval_AddInfo
        {
            public Window_Interval window;
            public int requered_length;
            public int start_penalty;
            public int stop_penalty;
            public int actual_start;
            public int actual_stop;
        }

        DataGridView dgv;
        List<windowInterval_AddInfo> windowIntervals;




        public Window_Interval_Specified_Gui(DataGridView dgv, Day day, int win_start_index, int length)
        {
            windowIntervals = new List<windowInterval_AddInfo>();
            foreach (Window_Interval interval in day.window_intervals)
            {
                if (interval.length >= length && interval.start <= win_start_index && interval.stop >= win_start_index&&interval.enabled)
                {
                    windowInterval_AddInfo cur_windowADD = new windowInterval_AddInfo();
                    cur_windowADD.window = interval;
                    cur_windowADD.requered_length = length;
                    cur_windowADD.start_penalty = win_start_index - interval.start;
                    cur_windowADD.stop_penalty = interval.stop - (win_start_index + length - 1);
                    cur_windowADD.actual_start = win_start_index;
                    cur_windowADD.actual_stop = win_start_index + length;
                    windowIntervals.Add(cur_windowADD);
                }
            }




            this.dgv = dgv;

            this.dgv.Rows.Clear();

            if (this.dgv.ColumnCount != 10)
            {
                this.dgv.Columns.Clear();

                DataGridViewColumn tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
                tmp.HeaderText = "id";
                this.dgv.Columns.Add(tmp);

                tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
                tmp.HeaderText = "master_ID";
                this.dgv.Columns.Add(tmp);

                tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
                tmp.HeaderText = "resource_ID";
                this.dgv.Columns.Add(tmp);

                tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
                tmp.HeaderText = "start";
                this.dgv.Columns.Add(tmp);

                tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
                tmp.HeaderText = "stop";
                this.dgv.Columns.Add(tmp);

                tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
                tmp.HeaderText = "star_index";
                this.dgv.Columns.Add(tmp);

                tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
                tmp.HeaderText = "stop_index";
                this.dgv.Columns.Add(tmp);


                tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
                tmp.HeaderText = "length";
                this.dgv.Columns.Add(tmp);

                tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
                tmp.HeaderText = "start penalty";
                this.dgv.Columns.Add(tmp);

                tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
                tmp.HeaderText = "stop penalty";
                this.dgv.Columns.Add(tmp);


            }



            this.dgv.RowCount = windowIntervals.Count;
            if (windowIntervals.Count != 0)
            {
                this.dgv.RowCount = windowIntervals.Count;
            }
            else
            {
                this.dgv.Rows.Clear();
            }

            for (int i = 0; i < windowIntervals.Count; i++)
            {
                this.dgv.Rows[i].Cells[0].Value = i;
                this.dgv.Rows[i].Cells[1].Value = windowIntervals[i].window.masterId;
                this.dgv.Rows[i].Cells[2].Value = windowIntervals[i].window.resourceId;
                this.dgv.Rows[i].Cells[3].Value = windowIntervals[i].window.start_date;
                this.dgv.Rows[i].Cells[4].Value = windowIntervals[i].window.stop_date;
                this.dgv.Rows[i].Cells[5].Value = windowIntervals[i].window.start;
                this.dgv.Rows[i].Cells[6].Value = windowIntervals[i].window.stop;
                this.dgv.Rows[i].Cells[7].Value = windowIntervals[i].window.length;
                this.dgv.Rows[i].Cells[8].Value = windowIntervals[i].start_penalty;
                this.dgv.Rows[i].Cells[9].Value = windowIntervals[i].stop_penalty;

            }
        }

        public void Window_Draw(int ind,TimeLine_Gui gui,bool hide,int size)
        {
            DataGridView dgView = gui.dgv;
            gui.fill_DGV(hide,size);



            for (int i = 0; i < dgView.RowCount; i++)
            {
                if (dgView.Rows[i].Cells[0].Value.ToString() ==
                    windowIntervals[ind].window.start_date.ToString("dd-MM"))
                {
                    for (int j = windowIntervals[ind].window.start; j <= windowIntervals[ind].window.stop; j++)
                    {
                        dgView.Rows[i].Cells[j+1].Style.BackColor=Color.Aqua;
                    }

                    for (int j = windowIntervals[ind].actual_start; j <= windowIntervals[ind].actual_stop; j++)
                    {
                        dgView.Rows[i].Cells[j + 1].Style.BackColor = Color.Blue;
                    }

                }
            }
        }

        public void Add_To_Base()
        {
            for (int i = 0; i < dgv.RowCount; i++)
            {
                if (dgv.Rows[i].Selected)
                {
                    DateTime start =
                        windowIntervals[i].window.start_date.Date.AddMinutes(5*windowIntervals[i].actual_start);
                    DateTime stop =
                       windowIntervals[i].window.start_date.Date.AddMinutes((5 * windowIntervals[i].actual_stop)-1);
                    Operation_ORM.test_add_Operation(windowIntervals[i].window.masterId, windowIntervals[i].window.resourceId,start,stop);
                }
            }
        }
    }




    public class Master_Info
    {
        public int master_id;
        public bool selected;

        public Master_Info(int masterId)
        {
            master_id = masterId;
        }
    }

    public class Resource_Info
    {
        public int resource_id;
        public bool selected;

        public Resource_Info(int resourceId)
        {
            resource_id = resourceId;
        }
    }

    public class Window_Interval_Info
    {

    }
}
