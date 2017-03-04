using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;

using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMB_FX.Element_Show;
using BMB_FX.ORM;
using MySql.Data.MySqlClient;

namespace BMB_FX
{
    public partial class Window_Search : Form
    {
        private Head_Container HC;
        public int Gr_Service_ID;
        public int Client_ID;
        
        public Window_Search()
        {
            InitializeComponent();
             HC= new Head_Container();
        }

        public void Load_Form()
        {
            HC.GroupService= new GroupService(GroupServiceDGV,Gr_Service_ID);
            HC.masterGuiContainer = new Master_Gui_Container(MasterTabControll, HC.GroupService,null);
            HC.resourceGuiContainer = new Resource_Gui_Container(ResourceTabControll, HC.GroupService);
        }

        
       

        private void Service_CmBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

       

      
       
        //public void order_BuildGui(int size)
        //{
        //    List<DateTime> dates = new List<DateTime>();
        //    DateTime start = Day_Start_Picker.Value.Date;
        //    DateTime stop = Day_Stop_Picker.Value.Date;
        //    do
        //    {
        //      dates.Add(start);
        //      start=start.AddDays(1);
        //    } while (start<=stop);}
        

        private void Add_Work_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
        }

      

      

     
    
        private void button4_Click_1(object sender, EventArgs e)
        {
            Load_Form();
        }

      
        private void button5_Click(object sender, EventArgs e)
        {
            List<DateTime> ls= new List<DateTime>();
            int i = 0;
            DateTime st = Day_Start_Picker.Value.Date;
            while (st <= Day_Stop_Picker.Value.Date && i < 7)
            {
                ls.Add(st);
                st=st.AddDays(1);
                i++;
            } 

                TimeLine_DGV.TimeLineMas = HC.set_HMC_list_getTLD(ls);
            TimeLine_DGV.BuildGui();
        }

        private void Window_Search_Load(object sender, EventArgs e)
        {
            Load_Form();
        }

        private void TimeLine_DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            HC.set_Spec_Windows(Spec_Windows_DGV, e.ColumnIndex - 1,e.RowIndex, true, true, true);
            Refresh();
        }

        private void Spec_Windows_DGV_SelectionChanged(object sender, EventArgs e)
        {
            if (Spec_Windows_DGV.SelectedRows.Count == 1)
            {
                int project_id = Convert.ToInt32(Spec_Windows_DGV.SelectedRows[0].Cells[0].Value);
                TimeLine_DGV.TimeLineMas = HC.Draw_Project_GetTLD(project_id,Convert.ToDateTime(Spec_Windows_DGV.SelectedRows[0].Cells[1].Value));
                TimeLine_DGV.BuildGui();
            }
            
        }
    }
}
