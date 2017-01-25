using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMB_FX
{
    public class Master_Gui
    {
        DataGridView dgv;
        List<Master_Info> masters;
        public List<int> masterIds; 
        public Master_Gui(int serviceId,DataGridView dgv)
        {
           
            masters=new List<Master_Info>();
            string queue = "select master.id from master inner join master_service on master_service.master_id=master.id  where (master_service.service_id="+serviceId+")";
            SQL cl = new SQL();
            cl.ReadValues(queue);
            while (cl.sqlDataReader.Read())
            {
                masters.Add(new Master_Info(cl.getInt32(0)));
            }
            cl.sqlConnection.Close();

            this.dgv = dgv;

            this.dgv.Rows.Clear();
            this.dgv.Columns.Clear();

            DataGridViewColumn tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
            tmp.HeaderText = "id";
            this.dgv.Columns.Add(tmp);
            DataGridViewCheckBoxColumn tmp2=new DataGridViewCheckBoxColumn();
            tmp2.HeaderText = "select";
            this.dgv.Columns.Add(tmp2);

            this.dgv.RowCount = masters.Count;
            for (int i = 0; i < masters.Count; i++)
            {
                this.dgv.Rows[i].Cells[0].Value = masters[i].master_id;
                this.dgv.Rows[i].Cells[1].Value = false;
            }
        }

        public void check_selected(int ind)
        {
            masterIds=new List<int>();

            masters[ind].selected = !masters[ind].selected;//Convert.ToBoolean(dgv.Rows[i].Cells[1].Value);
            dgv.Rows[ind].Cells[1].Value = masters[ind].selected;


            for (int i = 0; i < masters.Count; i++)
            {
               
                if (masters[i].selected)
                {
                   masterIds.Add(masters[i].master_id); 
                }
            }

        }

       
    }

    public class Window_Interval_ALL_Gui
    {
        DataGridView dgv;
        List<Window_Interval> windowIntervals;

        public Window_Interval_ALL_Gui(DataGridView dgv,List<Day> days )
        {
            List<Window_Interval> windowIntervals=new List<Window_Interval>();

            foreach (Day cur_day in days)
            {
               windowIntervals.AddRange(cur_day.window_intervals);
            }

            this.windowIntervals=windowIntervals;
            
            this.dgv = dgv;

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
                this.dgv.Rows[i].Cells[8].Value = true;
            }
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
        }

        DataGridView dgv;
        List<windowInterval_AddInfo> windowIntervals;


        

        public Window_Interval_Specified_Gui(DataGridView dgv, Day day,int win_start_index,int length)
        {
            windowIntervals=new List<windowInterval_AddInfo>();
            foreach (Window_Interval interval in day.window_intervals)
            {
                if (interval.length>=length&&interval.start <= win_start_index && interval.stop >= win_start_index)
                {
                    windowInterval_AddInfo cur_windowADD=new windowInterval_AddInfo();
                    cur_windowADD.window = interval;
                    cur_windowADD.requered_length = length;
                    cur_windowADD.start_penalty = win_start_index - interval.start;
                    cur_windowADD.stop_penalty = interval.stop - (win_start_index + length - 1);
                    windowIntervals.Add(cur_windowADD);
                }

            
            }
           

            

            this.dgv = dgv;

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

            tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
            tmp.HeaderText = "start penalty";
            this.dgv.Columns.Add(tmp);

            tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
            tmp.HeaderText = "stop penalty";
            this.dgv.Columns.Add(tmp);






            this.dgv.RowCount = windowIntervals.Count;
            if (windowIntervals.Count!=0)
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
        int master_id;
        bool selected;
    }

    public class Window_Interval_Info
    {

    }
}
