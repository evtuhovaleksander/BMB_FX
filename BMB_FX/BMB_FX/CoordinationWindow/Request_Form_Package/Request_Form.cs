using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMB_FX.CoordinationWindow;
using BMB_FX.Element_Show;
using BMB_FX.ORM;

namespace BMB_FX.Request_Form_Package
{
    public partial class Request_Form : Form
    {
        private int Client_id;
        private string Client;
        public Coordination_Form parent;
        public Request_Form()
        {
            InitializeComponent();
            prepare_dgv();


        }

        void prepare_dgv()
        {
            int i = 0;
            dgv.ColumnsDictionary=new Dictionary<string, int>();
            dgv.Columns.Clear();
            
            dgv.addTextColumn("RequestID",i);//0
            dgv.Columns[i].Visible = false;
            i++;

            dgv.addTextColumn("ClientID",i);
            dgv.Columns[i].Visible = false;
            i++;

            dgv.addTextColumn("Client",i);
            dgv.Columns[i].Visible = false;
            i++;

            dgv.addTextColumn("ServiceID",i);
            dgv.Columns[i].Visible = false;
            i++;

            dgv.addTextColumn("Service",i);//4
            i++;

            dgv.addTextColumn("PrefDateTime",i);
            i++;

            dgv.addCheckColumn("hasOperation",i);
            i++;
            dgv.addTextColumn("OperationID", i);//7
            dgv.Columns[i].Visible = false;
            i++;

            dgv.addButtonColumn("viewOperation",i);
            i++;
            dgv.addButtonColumn("addOperation", i);
            i++;
            dgv.addCheckColumn("OperationCanceled", i);//10
            i++;
            dgv.addButtonColumn("reorderOperation", i);//11
            i++;



        }

        public void load_Data(int ClientID)
        {
            this.Client_id = ClientID;
            Client = Client_ORM.get_name_where_id(ClientID);
            dgv.Rows.Clear();
            string query =
                "select req.ID,  req.Client_ID,cl.Client,   req.GroupService_ID,gser.GroupService,   req.PrefDateTime    from request req "+
                "   inner join client cl on cl.ID=req.Client_ID"+
                "   inner join group_service gser on gser.ID=req.GroupService_ID"+
                "   where req.Client_ID=" +
                ClientID;
            SQL cl=new SQL();
            cl.ReadValues(query);
            while (cl.sqlDataReader.Read())
            {
                dgv.Rows.Add(new DataGridViewRow());
                dgv.Rows[dgv.RowCount - 1].Cells[0].Value = cl.getInt32(0);

                dgv.Rows[dgv.RowCount - 1].Cells[1].Value = cl.getInt32(1);
                dgv.Rows[dgv.RowCount - 1].Cells[2].Value = cl.getString(2);

                dgv.Rows[dgv.RowCount - 1].Cells[3].Value = cl.getInt32(3);
                dgv.Rows[dgv.RowCount - 1].Cells[4].Value = cl.getString(4);


                dgv.Rows[dgv.RowCount - 1].Cells[5].Value = cl.getDateTime(5);



                int col= SQL.ReadValueInt32("select Count(*) from operation where Request_ID=" + cl.getInt32(0));
                if (col > 1)
                {
                    SQL cl2= new SQL();
                    cl2.ReadValues("select ID from operation where Request_ID=" + cl.getInt32(0));
                    string ids = "";
                    while (cl2.sqlDataReader.Read())
                    {
                        ids += "" + cl2.getInt32(0) + ",";
                    }
                    ids = ids.Substring(0, ids.Length - 1);
                    dgv.Rows[dgv.RowCount - 1].Cells[6].Value = true;
                    dgv.Rows[dgv.RowCount - 1].Cells[7].Value = ids;
                }
                else
                {
                    if (col == 0)
                    {
                        dgv.Rows[dgv.RowCount - 1].Cells[6].Value = false;
                        dgv.Rows[dgv.RowCount - 1].Cells[7].Value = null;
                    }
                    else
                    {
                        int c = SQL.ReadValueInt32("select ID from operation where Request_ID=" + cl.getInt32(0));
                        if (c != -1)
                        {

                            dgv.Rows[dgv.RowCount - 1].Cells[6].Value = true;
                            dgv.Rows[dgv.RowCount - 1].Cells[7].Value = c;
                            int cc = SQL.ReadValueInt32("select canceled from operation where Request_ID=" + cl.getInt32(0));
                            if (cc == 1)
                            {
                                dgv.Rows[dgv.RowCount - 1].Cells[10].Value = true;
                            }
                            else
                            {
                                dgv.Rows[dgv.RowCount - 1].Cells[10].Value = false;
                            }


                        }
                    }
                }
               
                
                

            }
        }

        private void Add_Request_But_Click(object sender, EventArgs e)
        {
           
            List<Element> elements = new List<Element>();
            elements.Add(new Key_Element());
            elements.Add(new Simple_Join_Element("Client_ID",true,Client,true,"client","Client"));
            elements.Add(new Simple_Join_Element("GroupService_ID",true,"group_service", "GroupService"));
            elements.Add(new Element("PrefDateTime","date",true));
            elements.Add(new Element("Comment", "string", true));
            
            Table table = new Table(elements, null, "request");
            FormBuilder.Prepare_Form_To_Add(table,new Point(50,50));
            load_Data(Client_id);
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                if (e.ColumnIndex == 9)
                {
                    if (dgv.Rows[e.RowIndex].Cells[9].Value != null)
                    {
                        if (!Convert.ToBoolean(dgv.Rows[e.RowIndex].Cells[9].Value))
                            parent.load_request_to_winsearch_form(Client_id, Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[3].Value), Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value));

                    }
                    else
                    {
                        
                            parent.load_request_to_winsearch_form(Client_id, Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[3].Value), Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value));

                    }
                }
                if (e.ColumnIndex == 8)
                {
                    if (dgv.Rows[e.RowIndex].Cells[6].Value != null)
                    {
                        if (Convert.ToBoolean(dgv.Rows[e.RowIndex].Cells[6].Value))
                        {
                            
                            string str = dgv.Rows[e.RowIndex].Cells[7].Value.ToString();
                            string[] strs = str.Split(',');
                            for (int i = 0; i < strs.Length; i++)
                            {
                                if (strs[i] != "")
                                {
                                    int id = Convert.ToInt32(strs[i]);
                                    Operation_Form.ShowOperation_Info(id);
                                }
                                
                            }

                        }
                       // d_request_to_winsearch_form(Client_id, Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[3].Value), Convert.ToInt32(dgv.Rows[e.RowIndex].Cells[0].Value));

                    }
                    
                }
            }
        }

        private void Request_Form_Load(object sender, EventArgs e)
        {

        }
    }
}
