using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BMB_FX.Element_Show
{
    public class Table
    {
        public Table(List<Element> elList, DataGridView_BMB DGV, string tab_name)
        {
            el_list = elList;
            dgv = DGV;
            Table_Name = tab_name;
            Inner_Part = "";
            foreach (Element tmp in elList)
            {
                if (tmp.cmbox && (!Inner_Part.Contains(tmp.addtable)))
                    Inner_Part += " left join " + tmp.addtable + " on " + Table_Name + "." + tmp.name + "=" +
                                  tmp.addtable + "." + "ID ";
            }
        }

        public List<Element> el_list;
        public DataGridView_BMB dgv;
        public string Table_Name;
        public string Inner_Part;


        public string make_Read_Queue_For_DGV()
        {
            string zap = "Select ";

            for (int i = 0; i < el_list.Count; i++)
            {
                if (i != 0) zap += ", ";
                if (el_list[i].cmbox)
                {
                    zap += el_list[i].addtable + ".";
                    zap += el_list[i].addtableVal + " ";

                }
                else
                {
                    zap += Table_Name + ".";
                    zap += el_list[i].name + " ";
                }
                
            }
            zap += "from " + Table_Name + " ";
            zap += Inner_Part;
            return zap;
        }

        //public string make_Read_Queue_For_DGV(string where)
        //{
        //    string zap = "Select ";

        //    for (int i = 0; i < el_list.Count; i++)
        //    {
        //        if (i != 0) zap += ", ";
        //        if (el_list[i].cmbox)
        //        {
        //            zap += el_list[i].addtable + ".";

        //        }
        //        else
        //        {
        //            zap += Table_Name + ".";
        //        }
        //        zap += el_list[i].name + " ";
        //    }
        //    zap += "from " + Table_Name + "  ";
        //    zap += Inner_Part + " where " + where;
        //    return zap;
        //}

        //public string make_Read_Queue_For_Edit_Form()
        //{
        //    string zap = "Select ";

        //    for (int i = 0; i < el_list.Count; i++)
        //    {
        //        if (i != 0) zap += ", ";
        //        zap += Table_Name + ".";

        //        zap += el_list[i].name + " ";
        //    }
        //    zap += "from " + Table_Name + " ";
        //    zap += Inner_Part;
        //    return zap;
        //}

        public string make_Read_Queue_For_Edit_Form(string where)
        {
            return make_Read_Queue_For_DGV()+ " where " + where;
             
        }

        public string make_Insert_Queue(List<string> parameters)
        {
            string zap = "insert into " + Table_Name + " (";

            for (int i = 1; i < el_list.Count; i++)
            {
                if (i != 1) zap += ", ";
                zap += Table_Name + ".";
                zap += el_list[i].name + " ";
                
            }
            zap += ") values (";
            for (int i = 1; i < el_list.Count; i++)
            {
                if (i != 1) zap += ", ";
                if (el_list[i].cons) zap += "'";
                zap += parameters[i];
                if (el_list[i].cons) zap += "'";
            }
            zap += ")";
            return zap;
        }

        public string make_Update_Queue(List<string> parameters, int id)
        {
            string zap = "update " + Table_Name + " set ";

            for (int i = 0; i < el_list.Count; i++)
            {
                if (i != 0) zap += ", ";
                zap += Table_Name + ".";
                zap += el_list[i].name + " =";
                if (el_list[i].cons) zap += "'";
                zap += parameters[i];
                if (el_list[i].cons) zap += "'";
            }
            zap += " where ID=" + id;

            return zap;
        }

        public string make_Delete_Queue(int id)
        {
            string zap = "delete * from " + Table_Name + " where ID=" + id;
            return zap;
        }

        public void LoadData()
        {
            LoadData(get_firstPartOfRequest());
        }

        public string get_firstPartOfRequest()
        {
            return make_Read_Queue_For_DGV().Replace("inner", "left");
        }

        public void LoadData(string queue)
        {
            dgv.load_Data(queue);
            dgv.Refresh();
        }

    }



}
