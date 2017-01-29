using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMB_FX.ORM;
using MySql.Data.MySqlClient;

namespace BMB_FX
{
    public partial class Window_Search : Form
    {
        TimeLine_Gui guiData=null;
        Master_Gui masterGui;
        Resource_Gui resourceGui;
        Window_Interval_ALL_Gui WindowIntervalAllGui;
        Window_Interval_Specified_Gui WindowIntervalSpecifiedGui;
        public Window_Search()
        {
            InitializeComponent();
            Service_CmBox.DataSource = Service_ORM.get_Services();
            Service_CmBox_SelectedIndexChanged(null, null);
            guiData =new TimeLine_Gui(Window_DGV);
        }

       

        private void Service_CmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = -1;
            if (Service_CmBox.SelectedItem != null) ind = Service_ORM.get_id_where_service(Service_CmBox.SelectedItem.ToString());
            if (ind != -1)
            {
                masterGui = new Master_Gui(ind, Master_DGV);
                resourceGui=new Resource_Gui(ind,Resource_DGV);
                length_Tbox.Text = Service_ORM.get_gap_duration(ind).ToString();
            }
        

        }

       

        private void Master_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            masterGui.check_selected(e.RowIndex);
           // order_BuildGui();
        }
       
        public void order_BuildGui()
        {
            List<DateTime> dates = new List<DateTime>();
            DateTime start = Day_Start_Picker.Value.Date;
            DateTime stop = Day_Stop_Picker.Value.Date;
            do
            {
              dates.Add(start);
              start=start.AddDays(1);
            } while (start<=stop);


            
            guiData.BuildGui(dates, masterGui.masterIds, resourceGui.resourceIds);
            WindowIntervalAllGui = new Window_Interval_ALL_Gui(allwindows_dgv, guiData);
        }


        private void Window_DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1&&e.ColumnIndex!=-1&&e.ColumnIndex>=1)
            {

                WindowIntervalSpecifiedGui = new Window_Interval_Specified_Gui(winintervalSpec_DGV,guiData.days[e.RowIndex],e.ColumnIndex-1,Convert.ToInt32(length_Tbox.Text));
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            order_BuildGui();
        }

        private void Resource_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            resourceGui.check_selected(e.RowIndex);
        }

        private void allwindows_dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==8) WindowIntervalAllGui.set_selected(e.RowIndex);
        }

        private void winintervalSpec_DGV_SelectionChanged(object sender, EventArgs e)
        {
            if (winintervalSpec_DGV.SelectedRows.Count == 1)
            {

                for (int i = 0; i < winintervalSpec_DGV.RowCount; i++)
                {
                    if (winintervalSpec_DGV.Rows[i].Selected)
                    {
                        WindowIntervalSpecifiedGui.Window_Draw(i,guiData);
                    }
                }
                
            }
        }

        private void Add_Work_Button_Click(object sender, EventArgs e)
        {
           WindowIntervalSpecifiedGui.Add_To_Base();
            MessageBox.Show("OK");
            order_BuildGui();
        }
    }
}
