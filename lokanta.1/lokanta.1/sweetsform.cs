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
    public partial class sweetsform : Form
    {
        public sweetsform()
        {
            InitializeComponent();
            label20.Visible = false;
            label23.Visible = false;
            label22.Visible = false;
            label24.Visible = false;
            label26.Visible = false;
            label25.Visible = false;
            label19.Visible = false;
            label21.Visible = false;
            label27.Visible = false;

        }

        private void label20_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (label20.Visible == false)
            {
                label20.Visible = true;
            }
            else
            {
                label20.Visible = false;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (label23.Visible == false)
            {
                label23.Visible = true;
            }
            else
            {
                label23.Visible = false;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (label22.Visible == false)
            {
                label22.Visible = true;
            }
            else
            {
                label22.Visible = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (label24.Visible == false)
            {
                label24.Visible = true;
            }
            else
            {
                label24.Visible = false;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (label26.Visible == false)
            {
                label26.Visible = true;
            }
            else
            {
                label26.Visible = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (label25.Visible == false)
            {
                label25.Visible = true;
            }
            else
            {
                label25.Visible = false;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (label19.Visible == false)
            {
                label19.Visible = true;
            }
            else
            {
                label19.Visible = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (label21.Visible == false)
            {
                label21.Visible = true;
            }
            else
            {
                label21.Visible = false;
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (label27.Visible == false)
            {
                label27.Visible = true;
            }
            else
            {
                label27.Visible = false;
            }
        }
    }
}
