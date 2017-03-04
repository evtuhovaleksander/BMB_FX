using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMB_FX.ORM;
using NAudio.Midi;

namespace BMB_FX
{
    public partial class Work_Form : Form
    {
        private int Master_ID;
        private int Resource_ID;
        private int CurentOperation_ID;
        private DateTime Gap_Start;
        private DateTime Gap_Stop;


        public Work_Form(int masterId, int resourceId)
        {
            InitializeComponent();
            Master_ID = masterId;
            Resource_ID = resourceId;
            LoadData();
            timer.Start();
        }

        private DateTime Date;
        

        private void Maximize_But_Click(object sender, EventArgs e)
        {
            Size = new Size(910, Size.Height);
        }

        private void Minimize_But_Click(object sender, EventArgs e)
        {
            Size = new Size(484, Size.Height);
        }

       

        private void Work_Form_SizeChanged(object sender, EventArgs e)
        {
            Text = "Work_Form " + Size.Width + " x " + Size.Height;
        }

        public void LoadData()
        {
            string query = "select o.ID,r.Client_ID,s.GroupService,o.Gap_Start,o.Gap_Stop,o.canceled from operation o " +
                           "left join request r  on r.ID=o.Request_ID " +
                           "left join group_service s  on r.GroupService_ID=s.ID " +
                           "where o.Master_ID=" + Master_ID + " and o.Resource_ID=" + Resource_ID +
                           " and o.Gap_Start between '" + Date.ToString("yyyy-MM-dd") + "' and '" +
                           Date.AddDays(1).ToString("yyyy-MM-dd") + "'";
            
            dgv.load_Data(query);
            dgv.Columns[5].Visible = false;
            for (int i = 0; i < dgv.RowCount; i++)
            {
                if (dgv.Rows[i].Cells[5].Value.ToString() == "1")
                {
                    for (int j = 0; j < dgv.ColumnCount; j++)
                    {
                        dgv.Rows[i].Cells[j].Style.BackColor=Color.Tomato;
                    }
                    
                }
            }


            SQL cl= new SQL();
            cl.ReadValues(query);
            while (cl.sqlDataReader.Read())
            {
                if (Date > cl.getDateTime(3) && Date <= cl.getDateTime(4))
                {
                    CurentOperation_ID = cl.getInt32(0);
                    load_operation(CurentOperation_ID);
                }
               
            }
            cl.Close_Connection();


        }

        public void tick()
        {
            try
            {
                Date = Convert.ToDateTime(timeINBox.Text);
                timeOUTBox.Text = Date.ToString("yyyy-MM-dd HH:mm:ss");
                LoadData();
            }
            catch (Exception ex)
            {
               
            }
        }


        private void timer_Tick(object sender, EventArgs e)
        {
            button1_Click(null, null);
        }

        private void tickBut_Click(object sender, EventArgs e)
        {
            tick();
        }

        public bool check_status_set(int stage_id)
        {
            string query =
               "select Count(*) from operation_stage op where op.Operation_ID=" + CurentOperation_ID + "  and op.Stage_ID= "+stage_id;
            return (SQL.ReadValueInt32(query) == 0);

        }

        void set_status(int stage_id,string comment)
        {
            if (check_status_set(stage_id))
            {
                string query = "insert into operation_stage (Operation_ID,Date,Stage_ID,Comment) values (" +
                               CurentOperation_ID + ",'" + Date.ToString("yyyy-MM-dd HH:mm:ss") + "'," + stage_id + ",'" +
                               comment + "')";
                SQL.Execute(query);
            }
        }

        private void Master_But_Click(object sender, EventArgs e)
        {
            if (master_Status_TBox.Text == "")
            {
                int id = ScannerForm.Scan();
                if (id ==Master_ID)
                {
                    master_Status_TBox.Text = Date.ToString("HH:mm");
                    master_Status_TBox.BackColor=Color.GreenYellow;
                    set_status(2,"manual");
                }
            }
        }

      

        private void Client_But_Click(object sender, EventArgs e)
        {
            int id=Client_ORM.get_id_where_Name(Client_TBox.Text);
            if (client_Status_TBox.Text == ""&&master_Status_TBox.Text!="")
            {
                int i = ScannerForm.Scan();
                if (id ==i)
                {
                    client_Status_TBox.Text = Date.ToString("HH:mm");
                    client_Status_TBox.BackColor = Color.GreenYellow;
                    set_status(3, "manual");
                }
            }
        }

       
        private void Operation_Begin_But_Click(object sender, EventArgs e)
        {
            if (begin_Status_TBox.Text == "" && client_Status_TBox.Text != "" && master_Status_TBox.Text != "")
            {
                begin_Status_TBox.Text = Date.ToString("HH:mm");
                begin_Status_TBox.BackColor = Color.GreenYellow;
                set_status(4, "manual");
            }
        }

       


        private void Operation_End_But_Click(object sender, EventArgs e)
        {
            if (end_Status_TBox.Text == "" && begin_Status_TBox.Text != "" && client_Status_TBox.Text != "" && master_Status_TBox.Text != "")
            {
                end_Status_TBox.Text = Date.ToString("HH:mm");
                end_Status_TBox.BackColor = Color.GreenYellow;
                set_status(5, "manual");
            }
        }

      

        private void Client_Leave_But_Click(object sender, EventArgs e)
        {
            if (client_leave_Status_TBox.Text==""&&end_Status_TBox.Text != "" && begin_Status_TBox.Text != "" && client_Status_TBox.Text != "" && master_Status_TBox.Text != "")
            {
                client_leave_Status_TBox.Text = Date.ToString("HH:mm");
                client_leave_Status_TBox.BackColor = Color.GreenYellow;
                set_status(6, "manual");
            }
        }
      

        private void End_Job_But_Click(object sender, EventArgs e)
        {
            if (end_job_Status_TBox.Text==""&&client_leave_Status_TBox.Text != "" && end_Status_TBox.Text != "" && begin_Status_TBox.Text != "" && client_Status_TBox.Text != "" && master_Status_TBox.Text != "")
            {
                end_job_Status_TBox.Text = Date.ToString("HH:mm");
                end_job_Status_TBox.BackColor = Color.GreenYellow;
                set_status(7, "manual");
            }
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Date = Convert.ToDateTime(timeINBox.Text);
                Date = Date.AddMinutes(1);
                timeOUTBox.Text = Date.ToString("yyyy-MM-dd HH:mm:ss");
                timeINBox.Text= Date.ToString("yyyy-MM-dd HH:mm:ss");
                LoadData();
            }
            catch (Exception ex)
            {

            }
        }

        private void Work_Form_Load(object sender, EventArgs e)
        {

        }

        private void dgv_SelectionChanged(object sender, EventArgs e)
        {
            if(!Auto_RBut.Checked)
            if (dgv.SelectedRows.Count == 1)
            {
                int oper_id = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
                load_operation(oper_id);
            }
            
        }

        public void load_operation(int oper_id)
        {
            string query = "select o.ID,r.Client_ID,s.GroupService,o.Gap_Start,o.Gap_Stop,s.ID,o.canceled from operation o " +
                           "left join request r  on r.ID=o.Request_ID " +
                           "left join group_service s  on r.GroupService_ID=s.ID " +
                           "where o.ID="+oper_id;
            SQL cl = new SQL();
            cl.ReadValues(query);
            cl.Read();
            if (!cl.getBool(6))
            {
                cancel_label.Visible = false;
            }
            else
            {
                cancel_label.Visible = true;
            }
            CurentOperation_ID = cl.getInt32(0);

                    Gap_Start = cl.getDateTime(3);
                    Gap_Stop = cl.getDateTime(4);
                    Order_TBox.Text = CurentOperation_ID.ToString();

                    Client_TBox.Text = cl.getString(1);
                    Service_TBox.Text = cl.getString(2);
                    Gap_Start_TBox.Text = Gap_Start.ToString("HH:mm");
                    Gap_Stop_TBox.Text = Gap_Stop.ToString("HH:mm");


            if (Date > cl.getDateTime(3) && Date <= cl.getDateTime(4))
            {
                Gap_Start = cl.getDateTime(3);
                Gap_Stop = cl.getDateTime(4);
                int id = cl.getInt32(5);
                int max = Service_ORM.get_gap_duration(id);
                progressBar.Maximum = max * 5;

                TimeSpan sp = (Gap_Stop - Date);
                int i = Convert.ToInt32(Math.Truncate(sp.TotalMinutes));
                progressBar.Value = Math.Abs(i);
            }
            else
            {
                progressBar.Value = progressBar.Minimum;
            }

            cl.Close_Connection();
            clear_all_status();
            query =
                "select op.ID,op.Date,op.Stage_ID,s.Stage from operation_stage op inner join stages s on s.ID=op.Stage_ID where op.Operation_ID=" +
                CurentOperation_ID;
            cl = new SQL();
            cl.ReadValues(query);
            while (cl.sqlDataReader.Read())
            {
                switch (cl.getInt32(2))
                {
                    case 2:
                        load_status(cl.getDateTime(1),master_Status_TBox);
                    break;

                    case 3:
                        load_status(cl.getDateTime(1), client_Status_TBox);
                        break;

                    case 4:
                        load_status(cl.getDateTime(1), begin_Status_TBox);
                        break;

                    case 5:
                        load_status(cl.getDateTime(1), end_Status_TBox);
                        break;

                    case 6:
                        load_status(cl.getDateTime(1), client_leave_Status_TBox);
                        break;

                    case 7:
                        load_status(cl.getDateTime(1), end_job_Status_TBox);
                        break;
                }
            }
            cl.Close_Connection();
        }

        void load_status(DateTime tm, TextBox tb)
        {
            tb.BackColor=Color.GreenYellow;
            tb.Text = tm.ToString("HH:mm");
        }

        void clear_status(TextBox tb)
        {
            tb.Text = "";
            tb.BackColor=Color.Gray;
        }

        void clear_all_status()
        {
            clear_status(master_Status_TBox);
            clear_status(client_Status_TBox);
            clear_status(begin_Status_TBox);
            clear_status(end_Status_TBox);
            clear_status(client_leave_Status_TBox);
            clear_status(end_job_Status_TBox);
        }

        private void Auto_RBut_CheckedChanged(object sender, EventArgs e)
        {
            if (Auto_RBut.Checked)
            {
                dgv.ClearSelection();
                dgv.Enabled = false;
                timer.Start();
            }
            else
            {
                dgv.ClearSelection();
                dgv.Enabled = true;
                timer.Stop();
            }
        }

        private void Red_But_Click(object sender, EventArgs e)
        {
            if (!Auto_RBut.Checked)
                if (dgv.SelectedRows.Count == 1)
                {
                    int oper_id = Convert.ToInt32(dgv.SelectedRows[0].Cells[0].Value);
                    cancel_job(oper_id);
                }
        }

        void cancel_job(int oper_id)
        {
            if (SQL.ReadValueInt32("select count(*) from group_operation where Operation_ID=" + oper_id) == 0)
            {
                SQL.Execute("update operation set canceled=1 where ID="+oper_id);
            }
            else
            {
                int group_id =
                    SQL.ReadValueInt32("SELECT  go.Group_ID from group_operation go where go.Operation_ID=" + oper_id);
                    int sequence= SQL.ReadValueInt32("SELECT  go.Sequence from group_operation go where go.Operation_ID=" + oper_id);
                SQL.Execute(
                    "UPDATE operation o set o.canceled=1 where o.ID in(select go.Operation_ID from group_operation go where go.Group_ID="+group_id+" and go.Sequence>="+sequence+" )");

            }
            LoadData();
        }


    }
}
