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
        private Operation_Form operationForm;

        public Work_Form(int masterId, int resourceId)
        {
            InitializeComponent();
            Master_ID = masterId;
            Resource_ID = resourceId;

            operationForm=new Operation_Form(masterId);
            operationForm.TopLevel = false;
            operationForm.Parent = panel;
            operationForm.AutoSize = true;
            operationForm.Dock = DockStyle.Fill;
            operationForm.FormBorderStyle=FormBorderStyle.None;
            operationForm.Show();
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
                    operationForm.load_operation(CurentOperation_ID);
                }
               
            }
            cl.Close_Connection();


        }

        public void tick()
        {
            try
            {
                Date = Convert.ToDateTime(timeINBox.Text);
                operationForm.Date = Date;
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

       
       

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Date = Convert.ToDateTime(timeINBox.Text);
                Date = Date.AddMinutes(1);
                operationForm.Date = Date;
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
                operationForm.load_operation(oper_id);
            }
            
        }

     

        void load_status(DateTime tm, TextBox tb)
        {
            tb.BackColor=Color.GreenYellow;
            tb.Text = tm.ToString("HH:mm");
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
