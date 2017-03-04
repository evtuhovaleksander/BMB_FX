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

namespace BMB_FX
{
    public partial class Item_Load_Form : Form
    {
        public Item_Load_Form()
        {
            InitializeComponent();
            masterRbut.Checked = true;
            dgv.build_columns();
        }

 

        private void Item_Load_Form_Load(object sender, EventArgs e)
        {

        }

        private void masterRbut_CheckedChanged(object sender, EventArgs e)
        {
            if (masterRbut.Checked)
            {
                cmBox.DataSource = SQL.get_DataSourceForCmBox("select Master from master");
            }
            else
            {
                cmBox.DataSource = SQL.get_DataSourceForCmBox("select Resource from resource");
            }
        }

        private void Load_but_Click(object sender, EventArgs e)
        {
            List<DateTime> ls = new List<DateTime>();
            int i = 0;
            DateTime st = Start_dateTimePicker.Value.Date;
            while (st <= Stop_dateTimePicker.Value.Date && i < 7)
            {
                ls.Add(st);
                st = st.AddDays(1);
                i++;
            }
            List<TimeLineDay> tldList=new List<TimeLineDay>();

            for (int j = 0; j < ls.Count; j++)
            {
                TimeLineDay tld=new TimeLineDay(ls[j]);
                tld.bool_mas = new bool[288];
                tld.char_mas = new char[288];
                tld.color_mas = new Color[288];
                tld.length_mas = new bool[288];
                tld.oper_mas=new int[288];
                for (int k = 0; k < 288; k++)
                {
                    tld.bool_mas[k] = true;
                    tld.color_mas[k] = Color.DarkGreen;
                    tld.char_mas[k] = ' ';
                    tld.oper_mas[k] = 0;
                }



                
                if (masterRbut.Checked)
                {
                    int id = Master_ORM.get_id_where_master(cmBox.SelectedItem.ToString());
                    if (SQL.ReadValueInt32("select id from master_day where Master_ID=" + id + " and Date='"+ls[j].ToString("yyyy-MM-dd")+"'")>0)
                    {
                        //tldList.Add(tld);
                    }
                    else
                    {
                        SQL cl = new SQL();
                        cl.ReadValues("SELECT Gap_Start,Gap_Stop,ID from operation where (Master_ID=" + id + " and Gap_Start BETWEEN '" + ls[j].ToString("yyyy-MM-dd") + "' and '" + ls[j].AddDays(1).ToString("yyyy-MM-dd") + "')");
                        while (cl.sqlDataReader.Read())
                        {
                            for (int k = Date_Converter.Date_To_Index(cl.getDateTime(0)); k <= Date_Converter.Date_To_Index(cl.getDateTime(1)); k++)
                            {
                                tld.bool_mas[k] = false;
                                tld.color_mas[k]=Color.Red;
                                tld.oper_mas[k] = cl.getInt32(2);
                            }
                        }
                        cl.Close_Connection();
                        cl.Create_Connection();
                        cl.Open_Connection();
                        cl.ReadValues("select Start,Stop,Status from master_day_block where(Master_ID=" + id + " and Start BETWEEN '" +ls[j].ToString("yyyy-MM-dd") + "' and '" + ls[j].AddDays(1).ToString("yyyy-MM-dd") + "')");
                        while (cl.sqlDataReader.Read())
                        {
                            for (int k = Date_Converter.Date_To_Index(cl.getDateTime(0)); k <= Date_Converter.Date_To_Index(cl.getDateTime(1)); k++)
                            {
                                tld.bool_mas[k] = false;
                                tld.color_mas[k] = Color.Red;
                                tld.oper_mas[k] = -cl.getInt32(2);
                            }
                        }
                        cl.Close_Connection();
                        tldList.Add(tld);
                    }
                }
                else
                {
                    int id = Resource_ORM.get_id_where_res(cmBox.SelectedItem.ToString());
                    if (SQL.ReadValueInt32("select id from resource_day where Resource_ID=" + id + " and Date='" + ls[j].ToString("yyyy-MM-dd") + "'") > 0)
                    {
                        //tldList.Add(tld);
                    }
                    else
                    {
                        SQL cl = new SQL();
                        cl.ReadValues("SELECT Gap_Start,Gap_Stop,ID from operation where (Resource_ID=" + id + " and Gap_Start BETWEEN '" + ls[j].ToString("yyyy-MM-dd") + "' and '" + ls[j].AddDays(1).ToString("yyyy-MM-dd") + "')");
                        while (cl.sqlDataReader.Read())
                        {
                            for (int k = Date_Converter.Date_To_Index(cl.getDateTime(0)); k <= Date_Converter.Date_To_Index(cl.getDateTime(1)); k++)
                            {
                                tld.bool_mas[k] = false;
                                tld.color_mas[k] = Color.Red;
                                tld.oper_mas[k] = cl.getInt32(2);
                            }
                        }
                        cl.Close_Connection();
                        cl.Create_Connection();
                        cl.Open_Connection();
                        cl.ReadValues("select Start,Stop,Status from resource_day_block where(Resource_ID=" + id + " and Start BETWEEN '" + ls[j].ToString("yyyy-MM-dd") + "' and '" + ls[j].AddDays(1).ToString("yyyy-MM-dd") + "')");
                        while (cl.sqlDataReader.Read())
                        {
                            for (int k = Date_Converter.Date_To_Index(cl.getDateTime(0)); k <= Date_Converter.Date_To_Index(cl.getDateTime(1)); k++)
                            {
                                tld.bool_mas[k] = false;
                                tld.color_mas[k] = Color.Red;
                                tld.oper_mas[k] = -cl.getInt32(2);
                            }
                        }
                        cl.Close_Connection();
                        tldList.Add(tld);
                    }
                }



                
            }
            dgv.TimeLineMas = tldList;
            dgv.BuildGui();


        }
    }
}
