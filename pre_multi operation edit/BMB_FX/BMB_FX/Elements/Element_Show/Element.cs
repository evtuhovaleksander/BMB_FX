using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMB_FX.Element_Show
{
    public class Element
    {
        public Element(string name, bool cons, bool cmbox, string addtable, string addtableVal)
        {
            // this.table = table;
            this.name = name;
            this.cons = cons;
            this.cmbox = cmbox;
            this.addtable = addtable;
            this.addtableVal = addtableVal;

        }

        public Element(string name, bool cons)
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
