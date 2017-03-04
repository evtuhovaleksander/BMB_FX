using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BMB_FX
{
    public class SQL
    {
        public SQL()
        {
            Create_Connection();
            Open_Connection();
        }

        public MySqlConnection sqlConnection;
        public MySqlDataReader sqlDataReader;
        public MySqlDataAdapter SqlDataAdapter;
        public MySqlCommand comand;
        public DataTable_BMB table;
        MySqlCommandBuilder comandBuilder; 

        public void Create_Connection() 
        {
            try
            {
                sqlConnection = new MySqlConnection(Properties.Settings.Default.BaseConnectionString2);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Open_Connection()
        {
            try
            {
                if (sqlConnection.State != ConnectionState.Open) sqlConnection.Open();
            }
            catch (Exception)
            {
               throw;
            }
            
        }

        public void Close_Connection()
        {
            if(sqlConnection.State==ConnectionState.Open)sqlConnection.Close();
        }


        public static object ReadValueStatic(string queue)
        {
            SQL cl = new SQL();
            cl.comand = new MySqlCommand(queue, cl.sqlConnection);

            object rettt= cl.comand.ExecuteScalar();
            if (rettt != null) rettt = rettt.GetType().ToString();
            object rett = cl.comand.ExecuteScalar();
            if (rettt == null) { rett = null;}else { if (rettt.ToString() == "System.DBNull") rett = null;}
            cl.Close_Connection();
            cl.sqlConnection.Close();
            return rett;
        }

        public static void Execute(string queue)
        {
            SQL cl = new SQL();
            cl.comand = new MySqlCommand(queue, cl.sqlConnection);
            cl.comand.ExecuteNonQuery();
            cl.sqlConnection.Close();
            
        }
        
        public object ReadValue(string queue)
        {
            comand = new MySqlCommand(queue, sqlConnection);
            return comand.ExecuteScalar();
        }

        public static int ReadValueInt32(string queue)
        {
            return ConvertToInt32(SQL.ReadValueStatic(queue));
        }

        public static double ReadValueDouble(string queue)
        {
            return ConvertToDouble(SQL.ReadValueStatic(queue));
        }

        public static int ConvertToInt32(object obj)
        {
            if (obj == null)
            {
                return -1;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        public static double ConvertToDouble(object obj)
        {
            if (obj == null)
            {
                return -1;
            }
            else
            {
                return Convert.ToDouble(obj);
            }
        }
        public void prepare_DataAdapter(string queue)
        {
            SqlDataAdapter = new MySqlDataAdapter(new MySqlCommand(queue, sqlConnection));
            comandBuilder = new MySqlCommandBuilder(SqlDataAdapter);
          
        }

        public void prepare_DataTable()
        {
            table=new DataTable_BMB();
            SqlDataAdapter.Fill(table);
        }

        public int upload_Data()
        {
            table.back_translate_Columns();
            int rett= SqlDataAdapter.Update(table);
            table.translate_Columns();
            return rett;
        }

        public string get_Translation(string eng_lang)
        {
            string queue = "select rus_name from translation where eng_name ='"+eng_lang+"'";
            object obj = ReadValue(queue);
            if (obj == null)
            {
                return eng_lang;
            }
            else
            {
                return obj.ToString();
            }
        }

        public string get_Back_Translation(string rus_lang)
        {
            string queue = "select eng_name from translation where rus_name ='" + rus_lang + "'";
            object obj = ReadValue(queue);
            if (obj == null)
            {
                return rus_lang;
            }
            else
            {
                return obj.ToString();
            }
        }

        public void ReadValues(string queue)
        {
            comand = new MySqlCommand(queue, sqlConnection);
            sqlDataReader = comand.ExecuteReader();
        }

        public static List<string> get_DataSourceForCmBox(string queue)
        {
            List<string> rett= new List<string>();
            SQL cl=new SQL();
            cl.ReadValues(queue);
            while(cl.sqlDataReader.Read()) rett.Add(cl.sqlDataReader.GetString(0));
            cl.sqlConnection.Close();
            return rett;
        }

        public static List<string> get_List_String(string queue)
        {
            List<string> rett = new List<string>();
            SQL cl = new SQL();
            cl.ReadValues(queue);
            while (cl.sqlDataReader.Read()) rett.Add(cl.getString(0));
            cl.sqlConnection.Close();
            return rett;
        }
        public static List<int> get_List_Int(string queue)
        {
            List<int> rett = new List<int>();
            SQL cl = new SQL();
            cl.ReadValues(queue);
            while (cl.sqlDataReader.Read()) rett.Add(cl.getInt32(0));
            cl.sqlConnection.Close();
            return rett;
        }

        public int getInt32(int ind)
        {
            if (sqlDataReader.IsDBNull(ind))
            {
                return -1;
            }
            else
            {
                object o = sqlDataReader.GetString(ind);
                return sqlDataReader.GetInt32(ind);
            }
        }

        public int getDouble(int ind)
        {
            if (sqlDataReader.IsDBNull(ind))
            {
                return -1;
            }
            else
            {
                object o = sqlDataReader.GetDouble(ind);
                return sqlDataReader.GetInt32(ind);
            }
        }

        public bool getBool(int ind)
        {
            if (sqlDataReader.IsDBNull(ind))
            {
                return false;
            }
            else
            {
                if (sqlDataReader.GetInt32(ind) == 1)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        public string getString(int ind)
        {
            if (sqlDataReader.IsDBNull(ind))
            {
                return "null";
            }
            else
            {
                return sqlDataReader.GetString(ind);
            }
        }

        public DateTime getDateTime(int ind)
        {
            if (sqlDataReader.IsDBNull(ind))
            {
                return new DateTime(1970,0,1);
            }
            else
            {
                return sqlDataReader.GetDateTime(ind);
            }
        }

        public void Read()
        {
            sqlDataReader.Read();
        }
    }
}
