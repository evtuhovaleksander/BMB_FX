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
        public int Request_ID;
        
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

    
        

        private void Add_Work_Button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("OK");
            int id = OUT_Project;
            for (int i = 0; i < HC.GOP_List.Count; i++)
            {
                if (HC.GOP_List[i].Date.Date == OUT_Date.Date)
                {
                    Sequence sequence = HC.GOP_List[i].Window_Sequences[OUT_Project];
                    string text = "";
                    text+="Для клиента:"+Client_ORM.get_name_where_id(Client_ID)+" SystemID("+Client_ID+")\n";
                    text += "Добавление групповой операции: " +
                            SQL.ReadValueStatic("select GroupService from group_service where ID=" + Gr_Service_ID) +
                            "  SystemID("+Gr_Service_ID+")";
                    text += "\n\n";
                    for (int j = 0; j < sequence.S.Length; j++)
                    {
                        int masterID = sequence.S[j].masterId;
                        string master = Master_ORM.get_master_where_id(masterID);

                        int resourceID = sequence.S[j].resourceId;
                        string resource = Resource_ORM.get_res_where_id(resourceID);

                        int serviceID = HC.GroupService.Operations[j].ServiceID;
                        string service = HC.GroupService.Operations[j].ServiceName;

                        

                        DateTime start = sequence.S[j].start_date;
                        DateTime stop = sequence.S[j].stop_date;
                        text += "Этап "+j+" :";
                        text += "\n";
                        text += "Процедура "+service+"  SystemID("+serviceID+")";
                        text += "\n";
                        text += "Мастер " + master + "  SystemID(" + masterID + ")";
                        text += "\n";
                        text += "Ресурс " + resource + "  SystemID(" + resourceID + ")";
                        text += "\n";
                        text += "Начало окна " + start.ToString("yyyy-MM-dd HH:mm:ss") + "  SystemID(" + sequence.S[j].start + ")"; text += "\n";
                        text += "Конец окна " + stop.ToString("yyyy-MM-dd HH:mm:ss") + "  SystemID(" + sequence.S[j].stop + ")"; text += "\n";
                        text += "Длительность процедуры " +sequence.S[j].length*5+ "минут  System(" + sequence.S[j].length + "квантов)"; text += "\n";
                        if (j != sequence.S.Length-1)
                        {
                            int w = (sequence.S[j + 1].start - sequence.S[j].stop - 1);
                            int waiting = 5 * w;
                            text += "Далее ожидание " + waiting + " минут  System(" + w + "квантов)"; text += "\n";
                        }
                        text += "\n\n";
                        
                    }



                    if (MessageBox.Show(text, "Add oper?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        int key = Randomizer.get_int();
                        int max = SQL.ReadValueInt32("select max(Group_ID) from group_operation");
                        max++;
                        for (int j = 0; j < sequence.S.Length; j++)
                        {
                            int masterID = sequence.S[j].masterId;
                            int resourceID = sequence.S[j].resourceId;
                            
                            string start = sequence.S[j].start_date.ToString("yyyy-MM-dd HH:mm:ss");
                            string stop = sequence.S[j].stop_date.ToString("yyyy-MM-dd HH:mm:ss");

                            
                            string q =
                                "insert into operation (Request_ID,Master_ID,Resource_ID,Gap_Start,Gap_Stop,Rate,canceled,Comment) " +
                                "VALUES (" + Request_ID + "," + masterID + "," + resourceID + ",'" + start + "','" +
                                stop + "',-1,0,'"+key+"')";
                            SQL.Execute(q);
                        }
                        if (sequence.S.Length > 1)
                        {
                            SQL cl = new SQL();
                            List<int> seq = new List<int>();
                            cl.ReadValues("select ID from operation where Comment='" + key + "' order by ID");
                            while (cl.sqlDataReader.Read())
                            {
                                seq.Add(cl.getInt32(0));
                            }


                            for (int j = 0; j < seq.Count; j++)
                            {
                                string q = "insert into group_operation (Group_ID,Operation_ID,Sequence) " +
                                           "VALUES(" + max + "," + seq[j] + "," + j + ") ";
                                SQL.Execute(q);
                                q = "update operation set Comment='' where ID=" + seq[j];
                                SQL.Execute(q);
                            }
                        }
                    }
                }
            }
            
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
                OUT_Project = project_id;
                OUT_Date = Convert.ToDateTime(Spec_Windows_DGV.SelectedRows[0].Cells[1].Value);
            }
            
        }

        int OUT_Project;
        DateTime OUT_Date;
    }
}
