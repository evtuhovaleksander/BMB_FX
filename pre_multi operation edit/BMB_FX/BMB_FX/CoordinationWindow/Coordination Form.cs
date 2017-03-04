using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BMB_FX;
namespace BMB_FX.CoordinationWindow
{
    public partial class Coordination_Form : Form
    {
        private Client_Coordination_Form client_form;
        private RateForm request_form;
        private Window_Search window_form;

        public int h;
        public int w=900;
        public Coordination_Form()
        {
            InitializeComponent();
            w = 1500;
            h = 500;
            this.IsMdiContainer = true;

            client_form=new Client_Coordination_Form();
            client_form.TopLevel = false;
            //Client_Panel.Controls.Add(client_form);
            client_form.Parent = Client_Panel;
            client_form.AutoSize = true;
            client_form.Dock = DockStyle.Fill;
            client_form.Show();



            request_form =new RateForm();
            request_form.TopLevel = false;
            request_form.Parent = Request_Panel;

            window_form=new Window_Search();
            window_form.TopLevel = false;
            window_form.Parent = Window_Panel;
        }

        private void Coordination_Form_Load(object sender, EventArgs e)
        {

        }

        private void Client_But_Click(object sender, EventArgs e)
        {
            Window_Panel.Location = new Point(0, h - 30);
            Window_Panel.Size = new Size(w, 30);
            Client_Panel.Location = new Point(0, 0);
            Client_Panel.Size = new Size(w, h - 60);
            Request_Panel.Location = new Point(0, h - 60);
            Request_Panel.Size = new Size(w, 30);

        }

        private void Request_But_Click(object sender, EventArgs e)
        {
            Window_Panel.Location = new Point(0, h - 30);
            Window_Panel.Size = new Size(w, 30);
            Client_Panel.Location = new Point(0, 0);
            Client_Panel.Size = new Size(w, 30);
            Request_Panel.Location = new Point(0, 30);
            Request_Panel.Size = new Size(w, h-60);
        }

        private void Window_But_Click(object sender, EventArgs e)
        {
            Window_Panel.Location = new Point(0, 60);
            Window_Panel.Size = new Size(w, h-60);
            Client_Panel.Location = new Point(0, 0);
            Client_Panel.Size = new Size(w, 30);
            Request_Panel.Location = new Point(0, 30);
            Request_Panel.Size = new Size(w, 30);
        }
    }
}
