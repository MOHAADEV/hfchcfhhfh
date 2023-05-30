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
    public partial class RoomForm : Form
    {
        RoomClass rooms = new RoomClass();
        public RoomForm()
        {
            
            InitializeComponent();
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
            string ROOMtype = DtextBox_type.Text;

            string ROOMstatus = free.Checked ? "free" : "busy";
            Boolean insertRoom = rooms.insertRoom(ROOMtype, ROOMstatus);
            if ( DtextBox_type.Text == "")
            {
                MessageBox.Show("يجب ادخال البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (insertRoom)
                    {
                        MessageBox.Show("تم حفظ البيانات بنجاح", "حفظ البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gettable();
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

        private void gettable()
        {
            dataGridView1.DataSource = rooms.getRoom();
        }
        private void RoomForm_Load(object sender, EventArgs e)
        {
            gettable();
        }

        private void SILMEBUT_Click(object sender, EventArgs e)
        {
            if (DtextBox_type.Text == "")
            {
                MessageBox.Show(" يجب ادخال المعلومات", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    string ROOMtype = DtextBox_type.Text;
                    Boolean deleteGuest = rooms.deleteRoom(ROOMtype);
                    if (deleteGuest)
                    {
                        MessageBox.Show("تم الحذف بنجاح ", "حفظ البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gettable();
                    }
                    else
                    {
                        MessageBox.Show("خطأ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string roomnum = DtextBox_type.Text;
                string status = free.Checked ? "free" : "busy";


                Boolean editGuest = rooms.editroom(status, roomnum);
                if (editGuest)
                {
                    MessageBox.Show("تم تحديث البيانات بنجاح", "حفظ البيانات", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gettable();
                    
                }
                else
                {
                    MessageBox.Show("رقم الهوية غير متوفر", "حفظ البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
    }

