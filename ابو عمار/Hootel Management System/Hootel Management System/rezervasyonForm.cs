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
using CrystalDecisions.CrystalReports.Engine;

namespace Hootel_Management_System
{
    public partial class rezervasyonForm : Form
    {
        rezervasyonClass rez = new rezervasyonClass();
        dbconnect con = new dbconnect();
        public rezervasyonForm()
        {
            
            InitializeComponent();
        }

        private void rezervasyonForm_Load(object sender, EventArgs e)
        {
            roomcombobox.DataSource = rez.roomByType();
            roomcombobox.DisplayMember = "ROOMTYPE";
            gettable();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
        }

        private void button_dashboard_Click(object sender, EventArgs e)
        {
                try
                {
                string tc = tccomboBox1.Text;
                string room = roomcombobox.Text;
                DateTime ddatein = dateinguna2DateTimePicker1.Value;
                DateTime ddateout = dateoutguna2DateTimePicker2.Value;
                if (rez.insertRez(tc, room, ddatein, ddateout) && rez.revUpdate(room, "busy"))
                    {
                       // MessageBox.Show("Veri başarıyla kaydedildi", "bilgi kaydetme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        gettable();
                        CrystalReport3 crs = new CrystalReport3();
                        TextObject rooom = (TextObject)crs.ReportDefinition.Sections["Section2"].ReportObjects["Text42"];
                        TextObject tcc = (TextObject)crs.ReportDefinition.Sections["Section2"].ReportObjects["tctext"];
                        TextObject tele = (TextObject)crs.ReportDefinition.Sections["Section2"].ReportObjects["teletext"];
                        TextObject name = (TextObject)crs.ReportDefinition.Sections["Section1"].ReportObjects["NAME"];
                        TextObject ode = (TextObject)crs.ReportDefinition.Sections["Section2"].ReportObjects["Odetext"];
                        TextObject namee = (TextObject)crs.ReportDefinition.Sections["Section2"].ReportObjects["namee"];
                        TextObject nash = (TextObject)crs.ReportDefinition.Sections["Section2"].ReportObjects["Text43"];
                        DataTable dt = new DataTable();
                        string query = "SELECT *FROM GUESTDB WHERE TC = '" + tccomboBox1.Text + "'";
                        MySqlCommand cmd = new MySqlCommand(query, con.GetConnection());
                        MySqlDataAdapter adb = new MySqlDataAdapter(cmd);
                        adb.Fill(dt);
                        tcc.Text = dt.Rows[0][1].ToString();
                        name.Text = dt.Rows[0][2].ToString();
                        namee.Text = dt.Rows[0][2].ToString();
                        tele.Text = dt.Rows[0][3].ToString();
                        ode.Text = dt.Rows[0][4].ToString();
                        rooom.Text = dt.Rows[0][6].ToString();
                        nash.Text = dt.Rows[0][8].ToString();
                        Bill bi = new Bill();
                        bi.crystalReportViewer1.ReportSource = crs;
                        this.Hide();
                        bi.Show();
                    }
                    else
                    {
                        MessageBox.Show("لم يتم حفظ البيانات بنجاح", "حفظ البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            
        }
        private void gettable()
        {
            dataGridView1.DataSource = rez.getRez();
        }

        private void SILMEBUT_Click(object sender, EventArgs e)
        {
            try
            {
                string tc = tccomboBox1.Text;
                string room = roomcombobox.Text;

                if (rez.deleterez(tc) && rez.revUpdate(room, "free"))
                {
                    MessageBox.Show("تم حذف الحجز  ", "حذف الحجز", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    gettable();


                }
                else
                {
                    MessageBox.Show("لم يتم حفظ البيانات بنجاح", "حفظ البيانات", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void roomcombobox_SelectedValueChanged(object sender, EventArgs e)
        {
            string room = roomcombobox.Text.ToString();

            tccomboBox1.DataSource = rez.CoustmerByRoom(room);
            tccomboBox1.DisplayMember = "TC";
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            tccomboBox1.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            roomcombobox.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }

        private void tccomboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != '\b')
            {
                e.Handled = true;

            }
        }
    }
}
