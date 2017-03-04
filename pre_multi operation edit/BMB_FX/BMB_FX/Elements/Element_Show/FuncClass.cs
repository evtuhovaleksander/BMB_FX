using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BMB_FX.Element_Show
{
    static class FuncClass
    {

        //public static DateTime get_Date(string inp)
        //{
        //    if (inp == "")
        //    {
        //        return new DateTime(1900);
        //    }
        //    else
        //    {
        //        try
        //        {
        //            return Convert.ToDateTime(inp);
        //        }
        //        catch (Exception)
        //        {
        //            return new DateTime(1900);
        //        }
        //    }

        //}

        public static ComboBox PrepareComboBox(ComboBox inp, Element el,string MainTable)
        {


            string zap = ""; ;
            if (el.cmbox)
            {
                zap += "select " + el.addtableVal + " from "+el.addtable;
            }
            else
            {
                zap += "select " + el.name + " from "+ MainTable;
            }

            
            inp.DataSource = SQL.get_List_String(zap);
            return inp;
        }

        //public static void check_excel(Button ExcelBut)
        //{
        //    int i = 0;
        //    foreach (var VARIABLE in Process.GetProcesses())
        //    {
        //        Console.WriteLine(VARIABLE.ProcessName);
        //        if (VARIABLE.ProcessName.Contains("XCEL")) i++;

        //    }
        //    if (i != 0)
        //    {
        //        if (
        //            MessageBox.Show("Найдено " + i + " копий работающих программы Excel \n Закрыть их?", "Warning",
        //                MessageBoxButtons.YesNo) == DialogResult.Yes)
        //        {
        //            foreach (var VARIABLE in Process.GetProcesses())
        //            {
        //                Console.WriteLine(VARIABLE.ProcessName);
        //                if (VARIABLE.ProcessName.Contains("XCEL")) VARIABLE.Kill();
        //            }
        //        }
        //        else
        //        {
        //            ExcelBut.BackColor = Color.Red;
        //        }
        //    }
        //    else
        //    {
        //        ExcelBut.BackColor = Color.Green;
        //    }
        //}

        //public static bool Check_without_Fill_DGV(XLS_Class xls, int start, int stop, int col, string table, string name, bool xls_marker)
        //{
           
        //    List<string> lst = check(xls, start, stop, col, table, name,xls_marker);

        //    if (lst.Count != 0)
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }

        //}

        //public static bool Check_Both(XLS_Class xls, int start, int stop, int col, string table, string name)
        //{
        //    return Check_without_Fill_DGV(xls, start, stop, col, table, name, true) &&
        //           Check_without_Fill_DGV(xls, start, stop, col, table, name, false);
        //}

        //public static List<string> check(XLS_Class xls, int start, int stop, int col, string table, string name,bool xls_marker )
        //{
        //    List<string> rett = new List<string>();

        //    string element;
        //    if (xls_marker)
        //    {
        //        if (name != "Owner")
        //        {
        //            element = "xls" + name;
        //        }
        //        else
        //        {
        //            element = name;
        //        }

        //    }
        //    else
        //    {
        //        element = name;
        //    }
        //    for (int i = start; i < stop; i++)
        //    {
        //        if (
        //            SQL_Class.ReadValueInt32("select count(*) from " + table + "  where " + element + " like '%" +
        //                                     xls.read_val(i, col).ToString() + "%'") <= 0)
        //        {
        //            if (!rett.Contains(xls.read_val(i, col).ToString())) rett.Add(xls.read_val(i, col).ToString());
        //        }
        //    }
        //    return rett;
        //}

        //public static Compare_Element get_Element(int id)
        //{
        //    string zap = "Select itemtable.ID,itemtable.Serial,itemtable.Serial2," +
        //                "itemtable.Mark,itemtable.Type,itemtable.Status,itemtable.Place," +
        //                "itemtable.Text,itemtable.Text2,itemtable.Text3,itemtable.Text4,itemtable.Text5,itemtable.Text6 " +
        //                ",itemtable.Place2, itemtable.Prise, itemtable.OS, itemtable.Date, itemtable.Owner,itemtable.Status2 from itemtable where itemtable.ID=" + id;
        //    SQL_Class cl = new SQL_Class();
        //    cl.ReadValues(zap);

        //    Compare_Element el = null;
        //    while (cl.SQL_DataReader.Read())
        //    {
        //       el = new Compare_Element();

        //        el.ID = cl.get_int(0);

        //        el.Serial = cl.get_string(1);
        //        el.Serial2 = cl.get_string(2);

        //        el.Markid = cl.get_int(3);
        //        el.Typeid = cl.get_int(4);
        //        el.Statusid = cl.get_int(5);
        //        el.Placeid = cl.get_int(6);

        //        el.Place2id = cl.get_int(13);
        //        el.Prise = cl.get_string(14);
        //        el.OSID = cl.get_int(15);
        //        el.date = cl.SQL_DataReader.GetDateTime(16);
        //        el.Status2id = cl.get_int(18);
        //        el.OwnerID = cl.get_int(17);
        //        el.Text = cl.get_string(7);
        //        el.Text2 = cl.get_string(8);
        //        el.Text3 = cl.get_string(9);
        //        el.Text4 = cl.get_string(10);
        //        el.Text5 = cl.get_string(11);
        //        el.Text6 = cl.get_string(12);


        //        el.read_other_names_base();
               
        //    }
        //    cl.Manualy_Close_Connection2();
        //    return el;
        //}

        //public static bool add_Element(Compare_Element el)
        //{
        //    string zap = "insert into itemtable (itemtable.Serial,itemtable.Serial2," +
        //                 "itemtable.Mark,itemtable.Type,itemtable.Status,itemtable.Place," +
        //                 "itemtable.Text,itemtable.Text2,itemtable.Text3,itemtable.Text4,itemtable.Text5,itemtable.Text6 " +
        //                 ",itemtable.Place2, itemtable.Prise, itemtable.OS, itemtable.Date,itemtable.Owner,itemtable.Status2)";
        //    zap += " values(" +
        //           "'" + el.Serial + "'," +
        //           "'" + el.Serial2 + "'," +
        //           el.Markid + "," +
        //           el.Typeid + "," +
        //           el.Statusid + "," +
        //           el.Placeid + "," +
        //           "'" + el.Text + "'," +
        //           "'" + el.Text2 + "'," +
        //           "'" + el.Text3 + "'," +
        //           "'" + el.Text4 + "'," +
        //           "'" + el.Text5 + "'," +
        //           "'" + el.Text6 + "'," +
        //           el.Place2id + "," +
        //           "'" + el.Prise + "'," +
        //           el.OSID + "," +
        //           "'" + el.date + "',"+el.OwnerID+","+el.Status2id+")";

        //    try
        //    {
        //        return SQL_Class.Execute(zap);
        //    }
        //    catch (Exception)
        //    {
        //        return false;
        //    }

        //}

        //public static DataTable get_dataTable(string where)
        //{
            
        //    MySqlCommand sqlCom = new MySqlCommand(where, SQL_Class.SQL_Connection);
        //    sqlCom.ExecuteNonQuery();
        //    MySqlDataAdapter dataAdapter = new MySqlDataAdapter(sqlCom);
        //    DataTable dt = new DataTable();
        //    dataAdapter.Fill(dt);
        //    return dt;
        //}

        //public static Color get_color_from_table(Color inp)
        //{
        //   ColorDialog dlg= new ColorDialog();
        //    if (dlg.ShowDialog() == DialogResult.Yes)
        //    {
        //        return dlg.Color;
        //    }
        //    else
        //    {
        //        return inp;
        //    }
        //}

    }
}
