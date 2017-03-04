using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMB_FX.CoordinationWindow;

namespace BMB_FX
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void gapdurationДлительностьОкнаНаРаботуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Simple_Table_Editor.Form_Lauch("Select id,date,duration from gap_duration");
        }

        private void serviceУслугаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Table_Editor_Multi_Table.Initializer initer=new Table_Editor_Multi_Table.Initializer();
            initer.queue = "SELECT id,name,check_id,gap_duration_id from service";
            initer.tables = new[]
            {
                "gap_duration",
                "service_check"
            };
            initer.queues = new[]
            {
                "Select id,date,duration from gap_duration",
                "Select id,date,prise from service_check"
            };

            Table_Editor_Multi_Table.get_Form(initer).Show();
        }

        private void servicecheckЦенаУслугиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Simple_Table_Editor.Form_Lauch("Select id,date,prise from service_check");
        }

        private void winToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Window_Search().Show();
        }

        private void workFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Work_Form(1,1).ShowDialog();
        }

        private void coordFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Coordination_Form().ShowDialog();
        }
    }
}
