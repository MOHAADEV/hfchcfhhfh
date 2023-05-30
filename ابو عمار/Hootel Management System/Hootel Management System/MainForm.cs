using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Hootel_Management_System
{
    public partial class MainForm : Form
    {
        dbconnect con = new dbconnect();
        public MainForm()
        {
            InitializeComponent();
           
        }
        public void Loadform(object Form)
        {
            if (this.mainpanel.Controls.Count > 0)
                this.mainpanel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.mainpanel.Controls.Add(f);
            this.mainpanel.Tag = f;
            f.Show();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_dashboard_Click_1(object sender, EventArgs e)
        {
            panel_slide.Height = button_dashboard.Height;
            panel_slide.Top = button_dashboard.Top;
            Loadform(new RoomForm());
        }

        private void button_guest_Click_1(object sender, EventArgs e)
        {
            panel_slide.Height = button_guest.Height;
            panel_slide.Top = button_guest.Top;
            Loadform(new GuestForm());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Loadform(new GuestForm());
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            panel_slide.Height = rez.Height;
            panel_slide.Top = rez.Top;
            Loadform(new rezervasyonForm());
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            panel_slide.Height = guna2Button1.Height;
            panel_slide.Top = guna2Button1.Top;
            Loadform(new DASHBOARD());
        }

        private void mainpanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
