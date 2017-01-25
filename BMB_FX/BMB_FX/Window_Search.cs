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
using MySql.Data.MySqlClient;

namespace BMB_FX
{
    public partial class Window_Search : Form
    {
        GUI_Data guiData=null;
        Master_Gui masterGui;
        Window_Interval_ALL_Gui WindowIntervalAllGui;
        Window_Interval_Specified_Gui WindowIntervalSpecifiedGui;
        public Window_Search()
        {
            InitializeComponent();
            Service_CmBox.DataSource = SQL.get_DataSourceForCmBox("SELECT name from service");
            int ind = SQL.ReadValueInt32("select id from service where name='" + Service_CmBox.SelectedItem + "'");
            if (ind != -1)
            {
                masterGui = new Master_Gui(ind, Master_DGV);
            }
            guiData =new GUI_Data(Window_DGV);
        }

        private void Window_Search_Load(object sender, EventArgs e)
        {
           
        }

        private void Service_CmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ind = SQL.ReadValueInt32("select id from service where name='" + Service_CmBox.SelectedItem + "'");
            if (ind != -1)
            {
                length_Tbox.Text = "1";//=SQL.ReadValueInt32("select ")
                get_masters_and_resources(ind);
            }
        }

        public void get_masters_and_resources(int serice_id)
        {
            masterGui=new Master_Gui(serice_id,Master_DGV);
        }

        private void Master_DGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            masterGui.check_selected(e.RowIndex);
         order_BuildGui();
        }
       
        public void order_BuildGui()
        {
            List<DateTime> dates = new List<DateTime>();
            dates.Add(new DateTime(2016, 11, 17));//"тип из дейт пикера"
            guiData.BuildGui(dates, masterGui.masterIds, new List<int>());
            WindowIntervalAllGui = new Window_Interval_ALL_Gui(allwindows_dgv, guiData.days);
        }

        private void Window_DGV_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex!=-1&&e.ColumnIndex!=-1&&e.ColumnIndex>=1)
            {

                WindowIntervalSpecifiedGui = new Window_Interval_Specified_Gui(winintervalSpec_DGV,guiData.days[e.RowIndex],e.ColumnIndex-1,Convert.ToInt32(length_Tbox.Text));
            }
        }
    }
}
