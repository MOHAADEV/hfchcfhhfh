using lokanta._1.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lokanta._1
{
    public partial class menu : Form
    {
        private bool iscallapsed;
        public menu()
        {
            InitializeComponent();

        }

        private void menu_Load(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panelslide1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pictureBoxslide1.Visible == true)
            {
                pictureBoxslide1.Visible = false;
                pictureBoxslide2.Visible = true;
            }
            else

            if (pictureBoxslide2.Visible == true)
            {  
                pictureBoxslide2.Visible = false;
                pictureBoxslide3.Visible = true;
            }
            else

            if (pictureBoxslide3.Visible == true) 
            {
                pictureBoxslide3.Visible = false;
                pictureBoxslide1.Visible = true;
            }
        }

       

        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {

        }
    }
}
