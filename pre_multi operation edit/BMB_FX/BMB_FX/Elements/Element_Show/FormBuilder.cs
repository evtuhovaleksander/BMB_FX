using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BMB_FX.Element_Show
{
    public class FormBuilder
    {
        const int fill_width = 200;
        const int label_width = 70;
        Table tbl;
        EditForm frm;
        List<object> fill_elements;
        List<object> label_elements;
        public FormBuilder(Table inp, Point pnt, int id)
        {
            int q = 0, w = 0;
            tbl = inp;
            frm = new EditForm(id, this);
            fill_elements = new List<object>(tbl.el_list.Count);
            label_elements = new List<object>(tbl.el_list.Count);
            for (int i = 0; i < tbl.el_list.Count; i++)
            {
                label_elements.Add(new TextBox());
                ((TextBox)label_elements[i]).Parent = frm;
                ((TextBox)label_elements[i]).Width = label_width;
                ((TextBox)label_elements[i]).Text = tbl.el_list[i].name;
                ((TextBox)label_elements[i]).Location = new Point(pnt.X, pnt.Y + w);


                if (!tbl.el_list[i].cmbox)
                {
                    fill_elements.Add(new TextBox());
                    ((TextBox)fill_elements[i]).Parent = frm;
                    ((TextBox)fill_elements[i]).Width = fill_width;
                    ((TextBox)fill_elements[i]).Text = "";
                    ((TextBox)fill_elements[i]).Location = new Point(pnt.X + ((TextBox)label_elements[i]).Width + 5, pnt.Y + w);
                }
                else
                {
                    fill_elements.Add(new ComboBox());
                    ((ComboBox)fill_elements[i]).Parent = frm;
                    ((ComboBox)fill_elements[i]).Width = fill_width;
                    ((ComboBox)fill_elements[i]).Text = "";
                    ((ComboBox)fill_elements[i]).Location = new Point(pnt.X + ((TextBox)label_elements[i]).Width + 5, pnt.Y + w);
                    fill_elements[i] = FuncClass.PrepareComboBox(((ComboBox)fill_elements[i]), tbl.el_list[i],tbl.Table_Name);
                }
                w += ((TextBox)label_elements[i]).Height + 3;
            }
            frm.Height = pnt.Y + w + 100;
        }

        public static void Prepare_Form_To_Add(Table inp, Point pnt)
        {
            FormBuilder bld = new FormBuilder(inp, pnt, 0);

            bld.frm.Add_But.Visible = true;
            bld.frm.Show();
        }

        public List<string> agregate_parameters()
        {
            List<string> lst = new List<string>();
            for (int i = 0; i < fill_elements.Count; i++)
            {
                if (!tbl.el_list[i].cmbox)
                {

                    lst.Add(((TextBox)fill_elements[i]).Text);
                }
                else
                {

                    lst.Add(((ComboBox)fill_elements[i]).SelectedIndex.ToString());

                }
            }
            return lst;
        }

        public void Add_To_Base()
        {
            SQL.Execute(tbl.make_Insert_Queue(agregate_parameters()));
            frm.Close();
        }
        public void Save_To_Base()
        {
            SQL.Execute(tbl.make_Update_Queue(agregate_parameters(), frm.ID));
            frm.Close();
        }
        public void Delete_To_Base()
        {
            SQL.Execute(tbl.make_Delete_Queue(frm.ID));
            frm.Close();
        }
        public static void Prepare_Form_To_Edit(Table inp, Point pnt, int id)
        {
            FormBuilder bld = new FormBuilder(inp, pnt, id);
            bld.Load_Element(id);
            bld.frm.Save_But.Visible = true;
            bld.frm.Delete_But.Visible = true;
            bld.frm.Show();
        }
        public static void Prepare_Form_To_Show(Table inp, Point pnt, int id)
        {
            FormBuilder bld = new FormBuilder(inp, pnt, id);
            bld.Load_Element(id);
            bld.frm.Save_But.Visible = false;
            bld.frm.Delete_But.Visible = false;
            
            bld.frm.Show();
        }
        public void Load_Element(int id)
        {
            string zap = tbl.make_Read_Queue_For_Edit_Form(tbl.Table_Name + ".ID=" + id);
            SQL cl = new SQL();
            cl.ReadValues(zap);
            cl.Read();
            for (int i = 0; i < tbl.el_list.Count; i++)
            {
                if (tbl.el_list[i].cmbox)
                {
                    int index = cl.getInt32(i);
                    ((ComboBox)fill_elements[i]).SelectedIndex = index;
                }
                else
                {

                    ((TextBox)fill_elements[i]).Text = cl.getString(i);
                }
            }
            cl.Close_Connection();
        }
    }
}
