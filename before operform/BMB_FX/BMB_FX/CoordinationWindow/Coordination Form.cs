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
using BMB_FX.Request_Form_Package;


namespace BMB_FX.CoordinationWindow
{
    public partial class Coordination_Form : Form
    {
        private ClientCoordinationForm client_form;
        private Request_Form request_form;
        private Window_Search window_form;

        public int h=1080;
        public int w=1920;
        public Coordination_Form()
        {
            InitializeComponent();
            w = 1920;
            h = 800;
            this.IsMdiContainer = true;

            client_form=new ClientCoordinationForm(this);
            client_form.TopLevel = false;
            client_form.Parent = Client_Panel;
            client_form.AutoSize = true;
            client_form.Dock = DockStyle.Fill;
            client_form.Show();



            request_form =new Request_Form();
            request_form.parent = this;
            request_form.TopLevel = false;
            request_form.Parent = Request_Panel;
            request_form.AutoSize = true;
            request_form.Dock=DockStyle.Fill;
            request_form.Show();


            window_form=new Window_Search();
            window_form.TopLevel = false;
            window_form.Parent = Window_Panel;
            window_form.AutoSize = true;
            window_form.Dock = DockStyle.Fill;
            window_form.Show();
        }

        private void Coordination_Form_Load(object sender, EventArgs e)
        {
            Client_But_Click(null,null);
        }

        public void load_client_to_request_form(int client_id)
        {
            Request_But_Click(null,null);
            request_form.load_Data(client_id);
        }
        public void load_request_to_winsearch_form(int client_id,int gr_service_id,int request_id)
        {
            window_form.Gr_Service_ID = gr_service_id;
            window_form.Request_ID = request_id;
            window_form.Client_ID = client_id;
            window_form.Load_Form();
            Window_But_Click(null, null);
            
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
