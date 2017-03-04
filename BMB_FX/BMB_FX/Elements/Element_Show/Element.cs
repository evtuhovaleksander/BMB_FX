using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMB_FX.Element_Show
{
    public class Element
    {

        public string name;
        public string type;
        public bool cons;

        public bool fixed_val_flag;
        public string fixed_val;

        public bool show_flag;

        public Element(string name, string type, bool showFlag)
        {
            this.name = name;
            this.type = type;
            show_flag = showFlag;
            set_cons();
        }

        public Element(string name, string type, bool fixedValFlag, string fixedVal, bool showFlag)
        {
            this.name = name;
            this.type = type;
            
            fixed_val_flag = fixedValFlag;
            fixed_val = fixedVal;
            show_flag = showFlag;
            set_cons();
        }

        void set_cons()
        {
            cons = false;
            if ("datestringdouble".Contains(type)) cons = true;
        }
    }
    
    public class Simple_Join_Element:Element
    {
        public Simple_Join_Element(string name, bool showFlag, string innerTableName, string innerTableValName) : base(name, "int", showFlag)
        {
            inner_table_name = innerTableName;
            inner_table_val_name = innerTableValName;
        }

        public Simple_Join_Element(string name, bool fixedValFlag, string fixedVal, bool showFlag, string innerTableName, string innerTableValName) : base(name,"int", fixedValFlag, fixedVal, showFlag)
        {
            inner_table_name = innerTableName;
            inner_table_val_name = innerTableValName;
        }

        public string inner_table_name;
        public string inner_table_val_name;
        public string inner_table_queryPart;

        public ComboBox PrepareComboBox()
        {
            ComboBox cmb=new ComboBox();
            string zap = ""; 
            
                zap += "select " + inner_table_val_name + " from " + inner_table_name;
           
            cmb.DataSource = SQL.get_List_String(zap);
            return cmb;
        }

        public string set_innerJoin(string mainTable)
        {
           inner_table_queryPart = " left join " + inner_table_name + " on " + mainTable + "." + name + "=" +
                              inner_table_name + "." + "ID ";
            return inner_table_queryPart;
        }

        public int get_index(ComboBox cmb)
        {
            string q = "select ID from " + inner_table_name + " where "+inner_table_val_name+"=";
           // if (cons)
            {
               q+= "'" + cmb.SelectedItem.ToString() + "'";
            }
         //   else
            {
         //       q += cmb.SelectedItem.ToString();
            }
            return SQL.ReadValueInt32(q);
        }
    }

    public class SystemVal_Element:Element
    {
        public SystemVal_Element(string name, string sysTableName, string whoName) : base(name, "int", false)
        {
            sysTable_name = sysTableName;
            who_name = whoName;
           
        }

        //public SystemVal_Element(string name, bool fixedValFlag, string fixedVal, bool showFlag, string sysTableName, string whoName) : base(name, "int", fixedValFlag, fixedVal, showFlag)
        //{
        //    sysTable_name = sysTableName;
        //    who_name = whoName;
           
        //}

        string sysTable_name;
        string who_name;
        int ID;
    }

    public class Key_Element : Element
    {
        public Key_Element() : base("ID", "key", false)
        {
        }
    }

    public class Element_old
    {
        public Element_old(string name, bool cons, bool cmbox, string addtable, string addtableVal)
        {
            // this.table = table;
            this.name = name;
            this.cons = cons;
            this.cmbox = cmbox;
            this.addtable = addtable;
            this.addtableVal = addtableVal;

        }

        public Element_old(string name, bool cons)
        {
            // this.table = table;
            this.name = name;
            this.cons = cons;
            this.cmbox = false;
            this.addtable = "";
            this.addtableVal = "";

        }

        public string name;
        public bool cons;
        public string addtableVal;
        public bool cmbox;
        public string addtable;
        public string innerpart;
    }
}
