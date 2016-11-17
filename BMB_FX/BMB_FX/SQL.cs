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
                sqlConnection = new MySqlConnection(Properties.Settings.Default.BaseConnectionString);
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

        public static object ReadValueStatic(string queue)
        {
            SQL cl = new SQL();
            cl.comand = new MySqlCommand(queue, cl.sqlConnection);
            return cl.comand.ExecuteScalar();
        }

        public object ReadValue(string queue)
        {
            comand = new MySqlCommand(queue, sqlConnection);
            return comand.ExecuteScalar();
        }

        public void prepare_DataAdapter(string queue)
        {
            SqlDataAdapter = new MySqlDataAdapter(new MySqlCommand(queue, sqlConnection));
            comandBuilder = new MySqlCommandBuilder(SqlDataAdapter);
            SqlDataAdapter.UpdateCommand = comandBuilder.GetUpdateCommand();
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
    }
}
