using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMB_FX.ORM;
using System.Drawing;
using BMB_FX.Element_Show;

namespace BMB_FX
{
    public class GroupService
    {
        public List<Operation> Operations;
        private DataGridView dgv;
        public GroupService(DataGridView dgv,int gr_serv_id)
        {
            this.dgv = dgv;

            string q =
                "SELECT gss.Sequence, gss.Service_ID from group_service_sequence gss where gss.GroupService_ID= " +
                gr_serv_id+ "  ORDER BY gss.Sequence ";
            SQL cl=new SQL();
            cl.ReadValues(q);
            Operations = new List<Operation>();
            while (cl.sqlDataReader.Read())
            {
                Operations.Add(new Operation(cl.getInt32(1)));
            }
            cl.Close_Connection();

            
            

            dgv.RowCount = Operations.Count;
            for (int i = 0; i < Operations.Count; i++)
            {
                dgv.Rows[i].Cells[1].Value = i;
                dgv.Rows[i].Cells[0].Value = Operations[i].ServiceID;
                dgv.Rows[i].Cells[2].Value = Operations[i].ServiceName;
                dgv.Rows[i].Cells[3].Value = Operations[i].Length;
            }
        }
    }

    public class Operation
    {

        public int ServiceID;
        public string ServiceName;
        public int Length;
        public Operation(int serviceId)
        {
            ServiceID = serviceId;
            ServiceName = Service_ORM.get_Name_by_id(ServiceID);
            Length = Service_ORM.get_gap_duration(ServiceID);
        }
    }

    public class Master_Gui_Container
    {
        TabControl tab;
        public List<Master_Gui> masterGuis;

        public Master_Gui_Container(TabControl tab, GroupService groupService, Action act )
        {
            this.tab = tab;
            tab.TabPages.Clear();

            masterGuis = new List<Master_Gui>();

            foreach (Operation oper in groupService.Operations)
            {
                TabPage pg = new TabPage();
                pg.Text = oper.ServiceName;
                tab.TabPages.Add(pg);
                masterGuis.Add(new Master_Gui(oper, pg));
            }
        }
    }

    public class Master_Gui
    {
        DataGridView_BMB dgv;
        public Dictionary<string, int> Column_To_ID;
        public Dictionary<int, string> ID_To_Column;
        List<Master_Info> masters;
        public List<int> masterIds;

        public Master_Gui(Operation operation, TabPage page )
        {

            dgv = new DataGridView_BMB(page);
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            //dgv.CellContentClick = += new System.Windows.Forms.DataGridViewCellEventHandler(act); ;
            dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.check_selected);

            masters = new List<Master_Info>();

            List<int> ids = Master_ORM.get_id_where_service(operation.ServiceID);
            foreach (int tm in ids)
            {
                masters.Add(new Master_Info(tm));
            }



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
                this.dgv.Rows[i].Cells[Column_To_ID["Main_Index"]].Value = null;
                this.dgv.Rows[i].Cells[Column_To_ID["MasterSelecter"]].Value = false;
            }
        }


        public void check_selected(object sender, DataGridViewCellEventArgs e)
        {
            masterIds = new List<int>();

            masters[e.RowIndex].selected = !masters[e.RowIndex].selected;
            dgv.Rows[e.RowIndex].Cells[Column_To_ID["MasterSelecter"]].Value = masters[e.RowIndex].selected;


            for (int i = 0; i < masters.Count; i++)
            {

                if (masters[i].selected)
                {
                    masterIds.Add(masters[i].master_id);
                }
            }
        }
    }

    public class Resource_Gui_Container
    {
        TabControl tab;
        public List<Resource_Gui> resourceGuis;

        public Resource_Gui_Container(TabControl tab, GroupService groupService)
        {
            this.tab = tab;
            tab.TabPages.Clear();

            resourceGuis = new List<Resource_Gui>();

            foreach (Operation oper in groupService.Operations)
            {
                TabPage pg = new TabPage();
                pg.Text = oper.ServiceName;
                tab.TabPages.Add(pg);
                resourceGuis.Add(new Resource_Gui(oper, pg));
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
        public Resource_Gui(Operation oper, TabPage page)
        {
            dgv = new DataGridView_BMB(page);
            dgv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.check_selected);
            resource = new List<Resource_Info>();

            List<int> ids = Resource_ORM.get_id_where_service(oper.ServiceID);
            foreach (int tm in ids)
            {
                resource.Add(new Resource_Info(tm));
            }

            // this.dgv = dgv;

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

        public void check_selected(object sender, DataGridViewCellEventArgs e)
        {
            resourceIds = new List<int>();

            resource[e.RowIndex].selected = !resource[e.RowIndex].selected;
            dgv.Rows[e.RowIndex].Cells[Column_To_ID["ResourceSelecter"]].Value = resource[e.RowIndex].selected;


            for (int i = 0; i < resource.Count; i++)
            {

                if (resource[i].selected)
                {
                    resourceIds.Add(resource[i].resource_id);
                }
            }

        }


    }

    public class Group_Operation_Project
    {
        public DateTime Date;
       public List<Sequence> Window_Sequences;
       


        public Group_Operation_Project(List<Sequence> windowSequences,DateTime t)
        {
           
            Window_Sequences = windowSequences;
            for (int i = 0; i < windowSequences.Count; i++)
            {
               Window_Sequences[i].calc_Penalty(); 
            }
            Date = t;
        }



        public TimeLineDay Get_Primary_Gui()
        {
            TimeLineDay tld = new TimeLineDay();
            tld.date_str = Date.ToString("dd-MM");
            tld.bool_mas = new bool[288];
            tld.length_mas = new bool[288];
            for (int i = 0; i < Window_Sequences.Count; i++)
            {
                tld.bool_mas[Window_Sequences[i].S[0].start] = true;
            }
            return tld;
        }

      

        public TimeLineDay Draw_Project(int project_id)
        {
            Window_Interval[] Sequence = Window_Sequences[project_id].S;
            TimeLineDay tld = new TimeLineDay();
            tld.spec_color = true;

            tld.bool_mas = new bool[288];
            tld.char_mas = new char[288];
            tld.color_mas = new Color[288];

            for (int i = 0; i < 288; i++)
            {
                tld.bool_mas[i] = false;
                tld.color_mas[i] = Color.Red;
                tld.char_mas[i] = ' ';
            }


            for (int i = 0; i < Sequence.Length; i++)
            {
                for (int j = Sequence[i].start; j <= Sequence[i].stop; j++)
                {
                    tld.bool_mas[j] = true;
                    tld.color_mas[j] = Color.CornflowerBlue;
                    tld.char_mas[j] = i.ToString()[0];
                }

            }

            for (int i = 0; i < Sequence.Length - 1; i++)
            {

                for (int j = Sequence[i].stop + 1; j < Sequence[i + 1].start; j++)
                {
                    tld.bool_mas[j] = true;
                    tld.color_mas[j] = Color.Yellow;
                    tld.char_mas[j] = i.ToString()[0];
                }

            }



            return tld;
        }
    }

    public class Head_Master_Class
    {
        Master_Gui_Container master_GuiContainer;
        Resource_Gui_Container resource_GuiContainer;
        GroupService groupService;
        DateTime day;
        private List<List<Window_Interval>> Operation_Windows;

        public Head_Master_Class(Master_Gui_Container masterGuiContainer, Resource_Gui_Container resourceGuiContainer, GroupService groupService, DateTime day)
        {
            master_GuiContainer = masterGuiContainer;
            resource_GuiContainer = resourceGuiContainer;
            this.groupService = groupService;
            this.day = day;
            get_Operation_Windows();
        }

        public void Sort()
        {
            for (int i = 0; i < Operation_Windows.Count; i++)
            {
                Operation_Windows[i].Sort((x, y) => x.start.CompareTo(y.start));
            }
        }

     

        public Group_Operation_Project Get_OperationProject(bool filter)
        {
            for (int i = 0; i < Operation_Windows.Count; i++)
            {
                Operation_Windows[i].Sort((x, y) => x.start.CompareTo(y.start));
            }



            List<Sequence> Projects = new List<Sequence>();
            for (int i = 0; i < Operation_Windows[0].Count; i++) // итерация по всем окнам 0го этапа
            {
                for (int j = Operation_Windows[0][i].start; j < Operation_Windows[0][i].stop; j++)// итерация по квантам окна
                {
                    if (j == 50)
                    {
                    }
                    if (Operation_Windows[0][i].in_window(j + groupService.Operations[0].Length - 1))
                    {
                        Sequence CurentProject = new Sequence(groupService.Operations.Count);
                        CurentProject.S[0] = new Operation_Window_Interval(Operation_Windows[0][i], j, j + groupService.Operations[0].Length - 1,false,0);


                        int offset = groupService.Operations[0].Length;
                        for (int k = 1; k < groupService.Operations.Count; k++)// подберем в секвенцию 2е и далее окна
                        {
                            for (int l = 0; l < Operation_Windows[k].Count; l++)//по итым окнам
                            {



                                List<Sequence> win_sequences = new List<Sequence>();
                                for (int m = Operation_Windows[k][l].start; m <= Operation_Windows[k][l].stop; m++) // по квантам итого окна
                                {
                                    if (Operation_Windows[k][l].in_window(m + groupService.Operations[k].Length - 1))
                                    {
                                        if (m > CurentProject.S[k - 1].stop)
                                        {
                                            CurentProject.S[k] = new Operation_Window_Interval(Operation_Windows[k][l], m, m + groupService.Operations[k].Length - 1,true,m-1- CurentProject.S[k-1].stop);
                                            if (k + 1 == groupService.Operations.Count)
                                            {
                                                //Sequences.Add(Sequence);
                                                bool er = false;
                                                for (int z = 0; z < CurentProject.S.Length; z++)
                                                {
                                                    if (CurentProject.S[z] == null)
                                                    {
                                                        er = true;
                                                    }
                                                    else
                                                    {
                                                        if (CurentProject.S[z].length != groupService.Operations[z].Length)
                                                        {
                                                            er = true;
                                                        }
                                                        else
                                                        {

                                                        }
                                                    }
                                                }
                                                if (!er)
                                                {
                                                    Sequence cseq=new Sequence(CurentProject.S.Length);
                                                    for (int n = 0; n < CurentProject.S.Length; n++)
                                                    {
                                                        cseq.S[n] = CurentProject.S[n];
                                                    }
                                                    if(cseq.is_Valid()) win_sequences.Add(cseq);
                                                }

                                            }


                                        }
                                       
                                        
                                    }
                                }
                                Projects.AddRange(win_sequences);
                            }
                            offset += groupService.Operations[k].Length;
                        }



                        

                    }




                }
            }

            return new Group_Operation_Project(Projects,day);

        }

        public void get_Operation_Windows()
        {
            Operation_Windows = new List<List<Window_Interval>>();
            for (int i = 0; i < groupService.Operations.Count; i++)
            {
                Operation_Windows.Add(get_window_intervals(master_GuiContainer.masterGuis[i].masterIds, resource_GuiContainer.resourceGuis[i].resourceIds, groupService.Operations[i]));
            }

        }

        public List<Window_Interval> get_window_intervals(List<int> masterIds,
           List<int> resourceIds, Operation oper)
        {


            if (masterIds == null) masterIds = new List<int>();
            if (resourceIds == null) resourceIds = new List<int>();


            List<Master> masters = new List<Master>();
            foreach (int id in masterIds)
            {
                if (Master.check_existance(id, day)) masters.Add(new Master(id, day));
            }

            List<Resource> resources = new List<Resource>();
            foreach (int id in resourceIds)
            {
                if (Resource.check_existance(id, day)) resources.Add(new Resource(id, day));
            }

            List<Window_Interval> curent;
            List<Window_Interval> window_intervals = new List<Window_Interval>();

            for (int i = 0; i < masters.Count; i++)
            {
                for (int j = 0; j < resources.Count; j++)
                {
                    Console.WriteLine("overlaping m" + masters[i].masterID + " r" + resources[j].resourceID);
                    curent = Interval_Overlap_Class.overlap_master_and_resource(masters[i], resources[j]);
                    foreach (Window_Interval cur_wind in curent)
                    {
                        if (cur_wind.length >= oper.Length) window_intervals.Add(cur_wind);
                    }

                }
            }


            foreach (Window_Interval prnt in window_intervals)
            {
                prnt.print();
            }



            return window_intervals;
        }





    }

    public class Head_Container
    {
        public GroupService GroupService;
        public Master_Gui_Container masterGuiContainer;
        public Resource_Gui_Container resourceGuiContainer;


        List<Head_Master_Class> HMC_list;
        public List<Group_Operation_Project> GOP_List;
        private List<Sequence> ORM;

        public TimeLineDay Draw_Project(int project_id)
        {
            Window_Interval[] Sequence = ORM[project_id].S;
            TimeLineDay tld = new TimeLineDay();
            tld.spec_color = true;

            tld.bool_mas = new bool[288];
            tld.char_mas = new char[288];
            tld.color_mas = new Color[288];

            for (int i = 0; i < 288; i++)
            {
                tld.bool_mas[i] = false;
                tld.color_mas[i] = Color.Red;
                tld.char_mas[i] = ' ';
            }


            for (int i = 0; i < Sequence.Length; i++)
            {
                for (int j = Sequence[i].start; j <= Sequence[i].stop; j++)
                {
                    tld.bool_mas[j] = true;
                    tld.color_mas[j] = Color.CornflowerBlue;
                    tld.char_mas[j] = i.ToString()[0];
                }

            }

            for (int i = 0; i < Sequence.Length - 1; i++)
            {

                for (int j = Sequence[i].stop + 1; j < Sequence[i + 1].start; j++)
                {
                    tld.bool_mas[j] = true;
                    tld.color_mas[j] = Color.Yellow;
                    tld.char_mas[j] = i.ToString()[0];
                }

            }



            return tld;
        }
        public List<TimeLineDay> set_HMC_list_getTLD(List<DateTime> lst )
        {
            HMC_list = new List<Head_Master_Class>();
            for (int i = 0; i < lst.Count; i++)
            {
                HMC_list.Add(new Head_Master_Class(masterGuiContainer, resourceGuiContainer, GroupService, lst[i]));
            }
            set_GOP_List(true);
            return get_TimeLineData();
        }

        public void set_GOP_List(bool filter)
        {
            GOP_List=new List<Group_Operation_Project>();
            for (int i = 0; i < HMC_list.Count; i++)
            {
                GOP_List.Add(HMC_list[i].Get_OperationProject(filter));
            }
        }

        public List<TimeLineDay> get_TimeLineData()
        {
            List<TimeLineDay> tld = new List<TimeLineDay>();
            for (int i = 0; i < GOP_List.Count; i++)
            {
                tld.Add(GOP_List[i].Get_Primary_Gui());
            }
            return tld;
        }

        public void set_Spec_Windows(DataGridView dgv, int st_index, int day_index, bool master, bool resource,
            bool stop)
        {
            if (st_index != -1)
            {
                dgv.Columns.Clear();
                DataGridViewColumn clmn; //

                for (int i = 0; i < GroupService.Operations.Count; i++)
                {
                    clmn = new DataGridViewColumn(new DataGridViewTextBoxCell());
                    clmn.HeaderText = "ProjectID";
                    dgv.Columns.Add(clmn);

                    clmn = new DataGridViewColumn(new DataGridViewTextBoxCell());
                    clmn.HeaderText = "Date";
                    dgv.Columns.Add(clmn);


                    clmn = new DataGridViewColumn(new DataGridViewTextBoxCell());
                    clmn.HeaderText = "Старт";
                    dgv.Columns.Add(clmn);

                    clmn = new DataGridViewColumn(new DataGridViewTextBoxCell());
                    clmn.HeaderText = GroupService.Operations[i].ServiceName;
                    dgv.Columns.Add(clmn);

                    if (master)
                    {
                        clmn = new DataGridViewColumn(new DataGridViewTextBoxCell());
                        clmn.HeaderText = "Мастер";
                        dgv.Columns.Add(clmn);
                    }

                    if (resource)
                    {
                        clmn = new DataGridViewColumn(new DataGridViewTextBoxCell());
                        clmn.HeaderText = "Ресурс";
                        dgv.Columns.Add(clmn);
                    }

                    if (stop)
                    {
                        clmn = new DataGridViewColumn(new DataGridViewTextBoxCell());
                        clmn.HeaderText = "Стоп";
                        dgv.Columns.Add(clmn);
                    }


                    clmn = new DataGridViewColumn(new DataGridViewTextBoxCell());
                    clmn.HeaderText = "Ожидание";
                    dgv.Columns.Add(clmn);
                }

                dgv.Columns[dgv.ColumnCount - 1].Visible = false;
                clmn = new DataGridViewColumn(new DataGridViewTextBoxCell());
                clmn.HeaderText = "Penalty";
                dgv.Columns.Add(clmn);
                ORM=new List<Sequence>();


                // заполнение
                int row_count = 0;
                for (int j = 0; j < GOP_List.Count; j++)
                {
                    for (int i = 0; i < GOP_List[j].Window_Sequences.Count; i++)
                    {
                        if (GOP_List[j].Window_Sequences[i].S[0].start == st_index)
                        {
                            row_count++;
                            ORM.Add(GOP_List[j].Window_Sequences[i]);
                        }
                    }
                }





                dgv.RowCount = row_count;
                ORM.Sort((x, y) => x.Penalty.CompareTo(y.Penalty));

              
                {

                    int row = 0;
                    for (int i = 0; i < ORM.Count; i++)
                    {
                        if (ORM[i].S[0].start == st_index)
                        {
                            
                            int cell = 0;
                            for (int j = 0; j < GroupService.Operations.Count; j++)
                            {
                                dgv.Rows[row].Cells[cell].Value = i;
                                cell++;
                                dgv.Rows[row].Cells[cell].Value = ORM[i].S[0].start_date.ToString("yyyy-MM-dd");
                                cell++;

                                dgv.Rows[row].Cells[cell].Value = ORM[i].S[j].start;
                                cell++;
                                dgv.Rows[row].Cells[cell].Value = GroupService.Operations[j].ServiceName;
                                cell++;

                                if (master)
                                {
                                    dgv.Rows[row].Cells[cell].Value = ORM[i].S[j].masterId;
                                    cell++;
                                }

                                if (resource)
                                {
                                    dgv.Rows[row].Cells[cell].Value = ORM[i].S[j].resourceId;
                                    cell++;
                                }

                                if (stop)
                                {
                                    dgv.Rows[row].Cells[cell].Value = ORM[i].S[j].stop;
                                    cell++;
                                }

                                if (j != GroupService.Operations.Count - 1)
                                {
                                    dgv.Rows[row].Cells[cell].Value = (ORM[i].S[j + 1].start -
                                                                       ORM[i].S[j].stop) - 1;
                                    cell++;
                                }
                                else
                                {
                                    cell++;
                                    
                                    dgv.Rows[row].Cells[cell].Value = ORM[i].Penalty;
                                }
                            }
                            row++;
                        }
                    }
                }


            }
        }

        public List<TimeLineDay> Draw_Project_GetTLD(int project_id, DateTime date)
        {
            List<TimeLineDay> tld = new List<TimeLineDay>();
            
            
            
             
            for (int i = 0; i < GOP_List.Count; i++)
            {
                if (GOP_List[i].Date.Date==date.Date)
                {
                    tld.Add(Draw_Project(project_id));
                }
                else
                {
                    tld.Add(GOP_List[i].Get_Primary_Gui());
                }
            }
            return tld;
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


}



//public void req(Window_Interval interval)
//{


//}

//public Group_Operation_Project Get_OperationProject2(bool filter)
//{
//    for (int i = 0; i < Operation_Windows.Count; i++)
//    {
//        Operation_Windows[i].Sort((x, y) => x.start.CompareTo(y.start));
//    }



//    List<Window_Interval[]> Sequences = new List<Window_Interval[]>();
//    for (int i = 0; i < Operation_Windows[0].Count; i++) // итерация по всем окнам 0го этапа
//    {
//        for (int j = Operation_Windows[0][i].start; j < Operation_Windows[0][i].stop; j++)// итерация по квантам окна
//        {
//            if (j == 154)
//            {
//            }
//            if (Operation_Windows[0][i].in_window(j + GroupService.Operations[0].Length - 1))
//            {
//                Window_Interval[] Sequence = new Window_Interval[GroupService.Operations.Count];
//                Sequence[0] = new Window_Interval(Operation_Windows[0][i], j, j + GroupService.Operations[0].Length - 1);


//                int offset = GroupService.Operations[0].Length;
//                for (int k = 1; k < GroupService.Operations.Count; k++)// подберем в секвенцию 2е и далее окна
//                {
//                    int min = 999;
//                    for (int l = 0; l < Operation_Windows[k].Count; l++)
//                    {
//                        int difference = 0;
//                        if (Operation_Windows[k][l].start >= j + offset)
//                        {
//                            difference = Operation_Windows[k][l].start - j + offset;
//                            if (!Operation_Windows[k][l].in_window(j + offset + GroupService.Operations[k].Length - 1)) continue;
//                            if (filter)
//                            {
//                                if (difference < min)
//                                {
//                                    min = difference;
//                                    Sequence[k] = new Window_Interval(Operation_Windows[k][l], j + offset, j + offset + GroupService.Operations[k].Length - 1);
//                                }
//                            }
//                            else
//                            {
//                                if (difference < min)
//                                {
//                                    min = difference;
//                                }

//                                Sequence[k] = new Window_Interval(Operation_Windows[k][l], j + offset, j + offset + GroupService.Operations[k].Length - 1);
//                            }
//                        }
//                        else
//                        {
//                            if (!Operation_Windows[k][l].in_window(j + offset + GroupService.Operations[k].Length - 1)) continue;
//                            if (filter)
//                            {
//                                if (difference < min)
//                                {
//                                    min = difference;
//                                    Sequence[k] = new Window_Interval(Operation_Windows[k][l], Operation_Windows[k][l].start, Operation_Windows[k][l].start + GroupService.Operations[k].Length - 1);
//                                }
//                            }
//                            else
//                            {
//                                if (difference < min)
//                                {
//                                    min = difference;
//                                }

//                                Sequence[k] = new Window_Interval(Operation_Windows[k][l], Operation_Windows[k][l].start, Operation_Windows[k][l].start + GroupService.Operations[k].Length - 1);
//                            }
//                        }
//                    }
//                    offset += GroupService.Operations[k].Length;
//                }



//                bool er = false;
//                for (int k = 0; k < Sequence.Length; k++)
//                {
//                    if (Sequence[k] == null)
//                    {
//                        er = true;
//                    }
//                    else
//                    {
//                        if (Sequence[k].length != GroupService.Operations[k].Length)
//                        {
//                            er = true;
//                        }
//                        else
//                        {

//                        }
//                    }
//                }
//                if (!er) Sequences.Add(Sequence);

//            }




//        }
//    }

//    return new Group_Operation_Project(GroupService, Sequences);

//}

//public void Get_Spec_Windows(DataGridView dgv, int st_index, bool master, bool resource, bool stop)
//{
//    dgv.Columns.Clear();
//    DataGridViewColumn clmn;//

//    for (int i = 0; i < GroupService.Operations.Count; i++)
//    {
//        clmn = new DataGridViewColumn(new DataGridViewTextBoxCell());
//        clmn.HeaderText = "ProjectID";
//        dgv.Columns.Add(clmn);


//        clmn = new DataGridViewColumn(new DataGridViewTextBoxCell());
//        clmn.HeaderText = "Старт";
//        dgv.Columns.Add(clmn);

//        clmn = new DataGridViewColumn(new DataGridViewTextBoxCell());
//        clmn.HeaderText = GroupService.Operations[i].ServiceName;
//        dgv.Columns.Add(clmn);

//        if (master)
//        {
//            clmn = new DataGridViewColumn(new DataGridViewTextBoxCell());
//            clmn.HeaderText = "Мастер";
//            dgv.Columns.Add(clmn);
//        }

//        if (resource)
//        {
//            clmn = new DataGridViewColumn(new DataGridViewTextBoxCell());
//            clmn.HeaderText = "Ресурс";
//            dgv.Columns.Add(clmn);
//        }

//        if (stop)
//        {
//            clmn = new DataGridViewColumn(new DataGridViewTextBoxCell());
//            clmn.HeaderText = "Стоп";
//            dgv.Columns.Add(clmn);
//        }


//        clmn = new DataGridViewColumn(new DataGridViewTextBoxCell());
//        clmn.HeaderText = "Ожидание";
//        dgv.Columns.Add(clmn);
//    }

//    dgv.Columns[dgv.ColumnCount - 1].Visible = false;



//    // заполнение
//    int row_count = 0;

//    for (int i = 0; i < Window_Sequences.Count; i++)
//    {
//        if (Window_Sequences[i][0].start == st_index)
//        {
//            row_count++;
//        }
//    }

//    dgv.RowCount = row_count;
//    int row = 0;
//    for (int i = 0; i < Window_Sequences.Count; i++)
//    {
//        if (Window_Sequences[i][0].start == st_index)
//        {
//            Window_Interval[] seq = Window_Sequences[i];
//            int cell = 0;
//            for (int j = 0; j < GroupService.Operations.Count; j++)
//            {
//                dgv.Rows[row].Cells[cell].Value = i;
//                cell++;


//                dgv.Rows[row].Cells[cell].Value = Window_Sequences[i][j].start;
//                cell++;
//                dgv.Rows[row].Cells[cell].Value = GroupService.Operations[j].ServiceName;
//                cell++;

//                if (master)
//                {
//                    dgv.Rows[row].Cells[cell].Value = Window_Sequences[i][j].masterId;
//                    cell++;
//                }

//                if (resource)
//                {
//                    dgv.Rows[row].Cells[cell].Value = Window_Sequences[i][j].resourceId;
//                    cell++;
//                }

//                if (stop)
//                {
//                    dgv.Rows[row].Cells[cell].Value = Window_Sequences[i][j].stop;
//                    cell++;
//                }

//                if (j != GroupService.Operations.Count - 1)
//                {
//                    dgv.Rows[row].Cells[cell].Value = (Window_Sequences[i][j + 1].start -
//                                                     Window_Sequences[i][j].stop) - 1;
//                    cell++;
//                }
//            }
//            row++;
//        }
//    }
//}





//public class TimeLine_Gui
//{
//    public DataGridView dgv;
//    public bool hide_non_work = false;
//    public int length;
//    public TimeLine_Gui(DataGridView dgv,int leng)
//    {
//        this.dgv = dgv;
//        this.length = leng;
//    }


//    public void resize_dgv(int s)
//    {
//        if (dgv != null)
//        {
//            if (dgv.ColumnCount != 289) build_columns(s);
//        }
//        for (int i = 1; i < 289; i++)
//        {



//            if ((i - 1)%12 != 0)
//            {
//                dgv.Columns[i].HeaderCell.Style.Font = new Font(FontFamily.GenericSansSerif, s);
//            }
//            else
//            {
//                dgv.Columns[i].HeaderCell.Style.Font = new Font(FontFamily.GenericSansSerif, size);
//            }
//        }
//    }

//    public int size;
//    DataGridView gdv;
//    public List<Day_Old> days;

//    public void BuildGui(List<DateTime> dateTimes, List<int> masterIds, List<int> resourceIds,bool hide,int size)
//    {
//        build_Days(dateTimes, masterIds, resourceIds);
//        fill_DGV(hide,size);
//    }

//    public void build_Days(List<DateTime> dateTimes, List<int> masterIds, List<int> resourceIds)
//    {
//        days = new List<Day_Old>();
//        foreach (DateTime cur_day in dateTimes)
//        {
//            days.Add(new Day_Old(cur_day, masterIds, resourceIds, length));
//        }
//    }




//    public void build_columns(int size_m)
//    {

//        const int col = 288;
//        dgv.Rows.Clear();
//        dgv.Columns.Clear();

//        size = 8;
//        DateTime tm = new DateTime(1970, 1, 1, 0, 0, 0);

//        DataGridViewColumn column = new DataGridViewColumn(new DataGridViewTextBoxCell());
//        column.HeaderText = "date";
//        column.DefaultCellStyle.Font = new Font(FontFamily.GenericSansSerif, size);
//        column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
//        column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
//        column.Frozen = true;

//        dgv.Columns.Add(column);

//            for (int i = 1; i < col + 1; i++)
//            {

//                column = new DataGridViewColumn(new DataGridViewTextBoxCell());

//                if ((i - 1)%12 != 0)
//                {
//                    column.HeaderCell.Style.Font = new Font(FontFamily.GenericSansSerif, size_m);
//                }
//                else
//                {
//                column.HeaderCell.Style.Font = new Font(FontFamily.GenericSansSerif, size);
//            }
//                column.HeaderText = tm.Hour + "\n-\n" + tm.ToString("mm");
//                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
//            column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

//            dgv.Columns.Add(column);
//                tm = tm.AddMinutes(5);
//            }
//    }


//    public void fill_DGV(bool hide_m,int size)
//    {

//        const int col = 288;

//        dgv.Rows.Clear();
//        {
//            if (dgv.ColumnCount != 288 + 1)
//            {
//                build_columns(size);
//            }
//        }

//        for (int i = 0; i < col + 1; i++) dgv.Columns[i].Visible = true;
//        dgv.RowCount = days.Count;
//        for (int i = 0; i < days.Count; i++)
//        {
//            dgv.Rows[i].Cells[0].Value = days[i].dateString;
//            days[i].rebuild_bool_mas(length);
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
//                        dgv.Rows[i].Cells[k].Value = "";
//                        dgv.Rows[i].Cells[k].Style.BackColor = Color.Red;
//                    }

//                    if(days[i].bool_length_flags[j])
//                    {
//                        dgv.Rows[i].Cells[k].Value = "";
//                        dgv.Rows[i].Cells[k].Style.BackColor = Color.Tomato;
//                    }
//                }
//            }


//        }

//        if(hide_m)
//        for (int k = 1; k < col + 1; k++)
//        {
//            int j = k - 1;
//            bool hide = true;
//            for (int i = 0; i < days.Count; i++)
//            {
//                bool a =!days[i].bool_flags[j];
//                bool b = days[i].bool_length_flags[j];
//                hide = hide &&( a||b);
//                if (days[i].bool_length_flags[j])
//                {
//                }
//            }
//            if (!hide)
//            {
//         //       break;
//            }
//            else
//            {
//                dgv.Columns[k].Visible = false;
//            }
//        }
//        //for (int k = col; k > 0; k--)
//        //{
//        //    int j = k - 1;
//        //    bool hide = false;
//        //    for (int i = 0; i < days.Count; i++)
//        //    {
//        //        hide = hide || days[i].bool_flags[j];
//        //    }
//        //    if (hide)
//        //    {
//        //        break;
//        //    }
//        //    else
//        //    {
//        //        dgv.Columns[k-1].Visible = false;
//        //    }
//        //}




//    }


//}

//public class Window_Interval_ALL_Gui
//{
//    DataGridView dgv;
//    private TimeLine_Gui timelineGui;

//    public Window_Interval_ALL_Gui(DataGridView dgv, TimeLine_Gui timeline)
//    {
//        this.dgv = dgv;
//        timelineGui = timeline;
//        Fill_Windows_All_Dgv();

//    }

//    public void Fill_Windows_All_Dgv()
//    {



//        List<Window_Interval> windowIntervals=new List<Window_Interval>();
//        foreach (Day_Old vr in timelineGui.days)
//        {
//            windowIntervals.AddRange(vr.window_intervals);
//        }

//        if (dgv.ColumnCount != 9)
//        {
//            this.dgv.Rows.Clear();
//            this.dgv.Columns.Clear();

//            DataGridViewColumn tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
//            tmp.HeaderText = "id";
//            this.dgv.Columns.Add(tmp);

//            tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
//            tmp.HeaderText = "master_ID";
//            this.dgv.Columns.Add(tmp);

//            tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
//            tmp.HeaderText = "resource_ID";
//            this.dgv.Columns.Add(tmp);

//            tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
//            tmp.HeaderText = "start";
//            this.dgv.Columns.Add(tmp);

//            tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
//            tmp.HeaderText = "stop";
//            this.dgv.Columns.Add(tmp);

//            tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
//            tmp.HeaderText = "star_index";
//            this.dgv.Columns.Add(tmp);

//            tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
//            tmp.HeaderText = "stop_index";
//            this.dgv.Columns.Add(tmp);

//            tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
//            tmp.HeaderText = "length";
//            this.dgv.Columns.Add(tmp);


//            DataGridViewCheckBoxColumn tmp2 = new DataGridViewCheckBoxColumn();
//            tmp2.HeaderText = "select";
//            this.dgv.Columns.Add(tmp2);




//        }


//        if (windowIntervals.Count != 0)
//        {
//            this.dgv.RowCount = windowIntervals.Count;
//        }
//        else
//        {
//            this.dgv.Rows.Clear();
//        }

//        for (int i = 0; i < windowIntervals.Count; i++)
//        {
//            this.dgv.Rows[i].Cells[0].Value = i;
//            this.dgv.Rows[i].Cells[1].Value = windowIntervals[i].masterId;
//            this.dgv.Rows[i].Cells[2].Value = windowIntervals[i].resourceId;
//            this.dgv.Rows[i].Cells[3].Value = windowIntervals[i].start_date;
//            this.dgv.Rows[i].Cells[4].Value = windowIntervals[i].stop_date;
//            this.dgv.Rows[i].Cells[5].Value = windowIntervals[i].start;
//            this.dgv.Rows[i].Cells[6].Value = windowIntervals[i].stop;
//            this.dgv.Rows[i].Cells[7].Value = windowIntervals[i].length;
//            this.dgv.Rows[i].Cells[8].Value = windowIntervals[i].enabled;
//        }
//    }

//    public void check_selected(bool hide,int size)
//    {

//        int index = 0;
//        for (int i = 0; i < timelineGui.days.Count; i++)
//        {
//            for (int j = 0; j < timelineGui.days[i].window_intervals.Count; j++)
//            {
//                if (Convert.ToBoolean(dgv.Rows[index].Cells[0].Value) == true)
//                {
//                    timelineGui.days[i].window_intervals[j].enabled = true;
//                }
//                else
//                {
//                    timelineGui.days[i].window_intervals[j].enabled = false;
//                }
//                index++;
//            }
//        }
//        Fill_Windows_All_Dgv();
//        timelineGui.fill_DGV(hide,size);
//    }
//    public void set_selected(int row,bool hide,int size)
//    {

//        int index = 0;
//        for (int i = 0; i < timelineGui.days.Count; i++)
//        {
//            for (int j = 0; j < timelineGui.days[i].window_intervals.Count; j++)
//            {
//                if (row==index)
//                {
//                    timelineGui.days[i].window_intervals[j].enabled = !timelineGui.days[i].window_intervals[j].enabled;
//                }

//                index++;
//            }
//        }
//        Fill_Windows_All_Dgv();
//        timelineGui.fill_DGV(hide, size);
//    }
//}

//public class Window_Interval_Specified_Gui
//{
//    public struct windowInterval_AddInfo
//    {
//        public Window_Interval window;
//        public int requered_length;
//        public int start_penalty;
//        public int stop_penalty;
//        public int actual_start;
//        public int actual_stop;
//    }

//    DataGridView dgv;
//    List<windowInterval_AddInfo> windowIntervals;




//    public Window_Interval_Specified_Gui(DataGridView dgv, Day_Old dayOld, int win_start_index, int length)
//    {
//        windowIntervals = new List<windowInterval_AddInfo>();
//        foreach (Window_Interval interval in dayOld.window_intervals)
//        {
//            if (interval.length >= length && interval.start <= win_start_index && interval.stop >= win_start_index&&interval.enabled)
//            {
//                windowInterval_AddInfo cur_windowADD = new windowInterval_AddInfo();
//                cur_windowADD.window = interval;
//                cur_windowADD.requered_length = length;
//                cur_windowADD.start_penalty = win_start_index - interval.start;
//                cur_windowADD.stop_penalty = interval.stop - (win_start_index + length - 1);
//                cur_windowADD.actual_start = win_start_index;
//                cur_windowADD.actual_stop = win_start_index + length;
//                windowIntervals.Add(cur_windowADD);
//            }
//        }




//        this.dgv = dgv;

//        this.dgv.Rows.Clear();

//        if (this.dgv.ColumnCount != 10)
//        {
//            this.dgv.Columns.Clear();

//            DataGridViewColumn tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
//            tmp.HeaderText = "id";
//            this.dgv.Columns.Add(tmp);

//            tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
//            tmp.HeaderText = "master_ID";
//            this.dgv.Columns.Add(tmp);

//            tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
//            tmp.HeaderText = "resource_ID";
//            this.dgv.Columns.Add(tmp);

//            tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
//            tmp.HeaderText = "start";
//            this.dgv.Columns.Add(tmp);

//            tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
//            tmp.HeaderText = "stop";
//            this.dgv.Columns.Add(tmp);

//            tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
//            tmp.HeaderText = "star_index";
//            this.dgv.Columns.Add(tmp);

//            tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
//            tmp.HeaderText = "stop_index";
//            this.dgv.Columns.Add(tmp);


//            tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
//            tmp.HeaderText = "length";
//            this.dgv.Columns.Add(tmp);

//            tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
//            tmp.HeaderText = "start penalty";
//            this.dgv.Columns.Add(tmp);

//            tmp = new DataGridViewColumn(new DataGridViewTextBoxCell());
//            tmp.HeaderText = "stop penalty";
//            this.dgv.Columns.Add(tmp);


//        }



//        this.dgv.RowCount = windowIntervals.Count;
//        if (windowIntervals.Count != 0)
//        {
//            this.dgv.RowCount = windowIntervals.Count;
//        }
//        else
//        {
//            this.dgv.Rows.Clear();
//        }

//        for (int i = 0; i < windowIntervals.Count; i++)
//        {
//            this.dgv.Rows[i].Cells[0].Value = i;
//            this.dgv.Rows[i].Cells[1].Value = windowIntervals[i].window.masterId;
//            this.dgv.Rows[i].Cells[2].Value = windowIntervals[i].window.resourceId;
//            this.dgv.Rows[i].Cells[3].Value = windowIntervals[i].window.start_date;
//            this.dgv.Rows[i].Cells[4].Value = windowIntervals[i].window.stop_date;
//            this.dgv.Rows[i].Cells[5].Value = windowIntervals[i].window.start;
//            this.dgv.Rows[i].Cells[6].Value = windowIntervals[i].window.stop;
//            this.dgv.Rows[i].Cells[7].Value = windowIntervals[i].window.length;
//            this.dgv.Rows[i].Cells[8].Value = windowIntervals[i].start_penalty;
//            this.dgv.Rows[i].Cells[9].Value = windowIntervals[i].stop_penalty;

//        }
//    }

//    public void Window_Draw(int ind,TimeLine_Gui gui,bool hide,int size)
//    {
//        DataGridView dgView = gui.dgv;
//        gui.fill_DGV(hide,size);



//        for (int i = 0; i < dgView.RowCount; i++)
//        {
//            if (dgView.Rows[i].Cells[0].Value.ToString() ==
//                windowIntervals[ind].window.start_date.ToString("dd-MM"))
//            {
//                for (int j = windowIntervals[ind].window.start; j <= windowIntervals[ind].window.stop; j++)
//                {
//                    dgView.Rows[i].Cells[j+1].Style.BackColor=Color.Aqua;
//                }

//                for (int j = windowIntervals[ind].actual_start; j <= windowIntervals[ind].actual_stop; j++)
//                {
//                    dgView.Rows[i].Cells[j + 1].Style.BackColor = Color.Blue;
//                }

//            }
//        }
//    }

//    public void Add_To_Base()
//    {
//        for (int i = 0; i < dgv.RowCount; i++)
//        {
//            if (dgv.Rows[i].Selected)
//            {
//                DateTime start =
//                    windowIntervals[i].window.start_date.Date.AddMinutes(5*windowIntervals[i].actual_start);
//                DateTime stop =
//                   windowIntervals[i].window.start_date.Date.AddMinutes((5 * windowIntervals[i].actual_stop)-1);
//                Operation_ORM.test_add_Operation(windowIntervals[i].window.masterId, windowIntervals[i].window.resourceId,start,stop);
//            }
//        }
//    }
//}