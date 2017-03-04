using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace BMB_FX
{
    public class DataGridView_TimeLine : DataGridView
    {
        public List<TimeLineDay> TimeLineMas;
        const int ColumnsCount = 288;
        const int HeaderCharSizeBig=6;
        const int HeaderCharSizeSmall = 6;
        bool HideColumns = false;


        public void BuildGui()
        {
            Rows.Clear();
            {
                if (ColumnCount != 288 + 1)
                {
                    build_columns();
                }
            }

            for (int i = 0; i < ColumnsCount + 1; i++) Columns[i].Visible = true;
            RowCount = TimeLineMas.Count;
            for (int i = 0; i < TimeLineMas.Count; i++)
            {
                Rows[i].Cells[0].Value = TimeLineMas[i].date_str;
                if (!TimeLineMas[i].spec_color)
                {
                    for (int k = 1; k < ColumnsCount + 1; k++)
                    {
                        int j = k - 1;
                        if (TimeLineMas[i].bool_mas[j])
                        {
                            Rows[i].Cells[k].Value = "";
                            Rows[i].Cells[k].Style.BackColor = Color.Green;
                        }
                        else
                        {
                            Rows[i].Cells[k].Value = "";
                            Rows[i].Cells[k].Style.BackColor = Color.Red;
                        }

                        if (TimeLineMas[i].length_mas[j])
                        {
                            Rows[i].Cells[k].Value = "";
                            Rows[i].Cells[k].Style.BackColor = Color.Tomato;
                        }
                    }


                }


                else
                {
                    for (int k = 1; k < ColumnsCount + 1; k++)
                    {
                        int j = k - 1;
                        if (TimeLineMas[i].bool_mas[j])
                        {
                            Rows[i].Cells[k].Value = TimeLineMas[i].char_mas[j];
                            Rows[i].Cells[k].Style.BackColor = TimeLineMas[i].color_mas[j];
                        }
                       
                    }
                }
            }
            if (HideColumns)
                for (int k = 1; k < ColumnsCount + 1; k++)
                {
                    int j = k - 1;
                    bool hide = true;
                    for (int i = 0; i < TimeLineMas.Count; i++)
                    {
                        bool a = !TimeLineMas[i].bool_mas[j];
                        bool b = TimeLineMas[i].length_mas[j];
                        hide = hide && (a || b);
                    }
                    
                    if (!hide)
                    {
                       
                    }
                    else
                    {
                        Columns[k].Visible = false;
                    }
                }
        }

        public void build_columns()
        {

            const int col = 288;
            Rows.Clear();
            Columns.Clear();

            int size = 8;
            DateTime tm = new DateTime(1970, 1, 1, 0, 0, 0);

            DataGridViewColumn column = new DataGridViewColumn(new DataGridViewTextBoxCell());
            column.HeaderText = "date";
            column.DefaultCellStyle.Font = new Font(FontFamily.GenericSansSerif, size);
            column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;
            column.Frozen = true;

            Columns.Add(column);

            for (int i = 1; i < col + 1; i++)
            {

                column = new DataGridViewColumn(new DataGridViewTextBoxCell());

                if ((i - 1)%12 != 0)
                {
                    column.HeaderCell.Style.Font = new Font(FontFamily.GenericSansSerif, HeaderCharSizeSmall);
                }
                else
                {
                    column.HeaderCell.Style.Font = new Font(FontFamily.GenericSansSerif, HeaderCharSizeBig);
                }
                column.HeaderText = tm.Hour + "\n-\n" + tm.ToString("mm") + "\n-\n"+(i-1).ToString();
                column.AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                column.HeaderCell.Style.Alignment = DataGridViewContentAlignment.BottomCenter;

                Columns.Add(column);
                tm = tm.AddMinutes(5);
            }
        }
    }


    public class TimeLineDay
    {
        public TimeLineDay(DateTime fullDate)
        {
            full_date = fullDate;
            date_str = fullDate.ToString("dd-MM");
        }

        public DateTime full_date;
        public string date_str;
        public bool[] bool_mas;
        public char[] char_mas;
        public bool[] length_mas;
        public Color[] color_mas;
        public bool spec_color = false;
        public int[] oper_mas;
    }
}
