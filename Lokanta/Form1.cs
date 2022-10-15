using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lokanta
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bunifuButton4_Click(object sender, EventArgs e)
        {
            Application.Exit();    
        }

        private void bunifuButton3_Click(object sender, EventArgs e)
        {
            Form2 git = new Form2();
            git.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            Form3 mhg = new Form3();
            mhg.Show();
            this.Hide();
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
