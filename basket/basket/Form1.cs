using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basket
{
    public partial class Form1 : Form
    {


       
        public Form1()
        {
            InitializeComponent(); 
    }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
          

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Program.pip.burger.Text = lbbrger.Text;
            Program.pip.label3.Text = lbprice.Text;
            Program.pip.w = lbprice.Text;
            Program.pip.pictureBox1.BackgroundImage = lbpanel.BackgroundImage;
            Program.pip.ShowDialog();
            
        }
        

            private void button2_Click(object sender, EventArgs e)
        {
            Program.pip.burger.Text = pz1.Text;
            Program.pip.label3.Text = label1.Text;
            Program.pip.w = label1.Text;
            Program.pip.pictureBox1.BackgroundImage = panel4.BackgroundImage;
            Program.pip.ShowDialog();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void label2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            Program.pip.burger.Text = label4.Text;
            Program.pip.label3.Text = label3.Text;
            Program.pip.w = label3.Text;
            Program.pip.pictureBox1.BackgroundImage = panel5.BackgroundImage;
            Program.pip.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Program.menu.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Program.pip.burger.Text = namelb.Text;
            Program.pip.label3.Text = pricelb.Text.Replace("TL"," ");
            Program.pip.w = pricelb.Text;
            Program.pip.pictureBox1.BackgroundImage = panellb.BackgroundImage;
            Program.pip.ShowDialog();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            Int32.Parse(read.Text.Replace("TL", ""));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Program.pip.Show();
            
            
        }
    }
}
