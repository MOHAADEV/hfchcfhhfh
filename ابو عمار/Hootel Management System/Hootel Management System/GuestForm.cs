using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Hootel_Management_System
{
    public partial class GuestForm : Form
    {
        GuestClass guest = new GuestClass();
        rezervasyonClass rez = new rezervasyonClass();
        public GuestForm()
        {
            InitializeComponent();
        }
        private void temiz()
        {
            DtextBox2_adi.Clear();
            DtextBox3_telfon.Clear();
            DtextBox_tc.Clear();
            DtextBox4_ode.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            temiz();
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            string tc = DtextBox_tc.Text;
            string name = DtextBox2_adi.Text;
            string tele = DtextBox3_telfon.Text;
            string pay = DtextBox4_ode.Text;
            string date = DdateTimePicker1.Text;
            string room = DcomboBox1.Text;
            string meth = METHODcomboBox1.Text;
            string nas = NASHBOX.Text;

            Boolean insertGuest = guest.insertGuest(tc, name, tele, pay,date , room, meth,nas);
            if (DtextBox2_adi.Text == "" || DtextBox_tc.Text == "")
            {
                MessageBox.Show("يجب ادخال المعلومات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {

                try
                {


                    if (insertGuest)
                    {
                        MessageBox.Show("تم حفظ البيانات بنجاح", "حفظ البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gettable();
                        temiz();
                    }
                    else
                    {
                        MessageBox.Show("لم يتم حفظ البيانات", "حفظ البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void GuestForm_Load(object sender, EventArgs e)
        {
            gettable();
            
            DcomboBox1.DataSource = rez.roomByType2();
            DcomboBox1.DisplayMember = "ROOMTYPE";
        }
        private void  gettable()
        {
            dataGridView1.DataSource = guest.getGuest();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            if (DtextBox2_adi.Text == "" || DtextBox_tc.Text == "")
            {
                MessageBox.Show("يجب ادخال البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string tc = DtextBox_tc.Text;
                    string name = DtextBox2_adi.Text;
                    string tele = DtextBox3_telfon.Text;
                    string pay = DtextBox4_ode.Text;
                    string date = DdateTimePicker1.Text;
                    string room = DcomboBox1.Text;

                    Boolean editGuest = guest.editGuest(tc, name, tele, pay, date, room);
                    if (editGuest)
                    {
                        MessageBox.Show("تم تحديث البيانات", "حفظ البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gettable();
                        temiz();
                    }
                    else
                    {
                        MessageBox.Show("رقم الهوية غير موجود", "لم يتم الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void SILMEBUT_Click(object sender, EventArgs e)
        {
            if ( DtextBox_tc.Text == "")
            {
                MessageBox.Show("يجب إدخال المعلومات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string tc = DtextBox_tc.Text;
                    Boolean deleteGuest = guest.deleteGuest(tc);
                    if (deleteGuest)
                    {
                        MessageBox.Show("تم الحذف بنجاح ", "حفظ البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gettable();
                    }
                    else
                    {
                        MessageBox.Show("رقم الهوية غير متوفر", "لم يتم حفظ البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            DtextBox_tc.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            DtextBox2_adi.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            DtextBox3_telfon.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            DtextBox4_ode.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            DcomboBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
        }
    }
}
