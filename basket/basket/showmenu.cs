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
    public partial class showmenu : Form
    {
        string z,v;
        int c,b;
        public int num;
       
        public showmenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void showmenu_Load(object sender, EventArgs e)
        {
            
        }
     //   Bitmap bitmap;
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            /* int height = dataGridView1.Height;
             dataGridView1.Height = dataGridView1.RowCount * dataGridView1.RowTemplate.Height * 2;
             bitmap = new Bitmap(dataGridView1.Width, dataGridView1.Height);

             dataGridView1.DrawToBitmap(bitmap, new Rectangle(0, 0, dataGridView1.Width, dataGridView1.Height));
             printPreviewDialog1.PrintPreviewControl.Zoom = 1;
             printPreviewDialog1.ShowDialog();
             dataGridView1.Height = height;*/
            while (gir.RowCount > 0)
            {
                gir.RowCount = num;
            }
            Program.b.Show();
        }

        private void showmenu_Load_1(object sender, EventArgs e)
        {
            para.Visible = false;
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
          //  e.Graphics.DrawImage(bitmap, 0, 0);
        }

        private void gir_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void topla_Click(object sender, EventArgs e)
        {

        }

        private void dell_Click(object sender, EventArgs e)
        {
            if(gir.SelectedRows != null)
            {
                    z = gir.CurrentRow.Cells[2].Value.ToString();
                    c = Int32.Parse(topla.Text);
                    c -= Int32.Parse(z);
                        topla.Text = Convert.ToString(c);
                     v = gir.CurrentRow.Cells[1].Value.ToString();
                     b = Int32.Parse(Program.form1.toplam.Text);
                     b -= Int32.Parse(v);
                        Program.form1.toplam.Text = Convert.ToString(b);
                        gir.Rows.Remove(gir.CurrentRow);
            }
        }
    }
}
