using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basket
{
    public partial class pippop : Form

    {
        
        int x=1 ,z=0;
        int toplae;
        int toplam =0;
        public string w;
        public pippop()
        {
            InitializeComponent();
            

        }
           
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
            x = 1;
        }

      

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pippop_Load(object sender, EventArgs e)
        {
            
          
            
         
        }


        public string[] date = new string[3];
        private void button1_Click(object sender, EventArgs e)
        {
            
            this.Close();
            z += Int32.Parse(label2.Text);
            if (Program.form1.toplam.Text == "0")
            {
                z = 0;
                z += Int32.Parse(label2.Text);
            }
            Program.form1.toplam.Text = Convert.ToString(z) ;
           
            //ok
           
            date[0] = burger.Text;
            date[1] = label3.Text;
            date[2] = label2.Text;
            
            Program.menu.gir.Rows.Add(date[0], date[1], date[2]);

            // حساب المجموع للدفع 
            
            toplae += Int32.Parse(label3.Text);
            if(Program.menu.topla.Text == "0")
            {
                toplae = 0;
                toplae += Int32.Parse(label3.Text);
            }
            Program.menu.topla.Text = Convert.ToString(toplae);


            //
            x = 1;
            label2.Text = x.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {
       
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ++x;
            toplam = x*Int32.Parse(label3.Text);
            label3.Text = Convert.ToString(toplam);
            label2.Text = x.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(x>1)
            {
                --x;
                toplam = x * Int32.Parse(w);
                label3.Text = Convert.ToString(toplam);
                label2.Text = x.ToString();
            }
        }
    }
}
