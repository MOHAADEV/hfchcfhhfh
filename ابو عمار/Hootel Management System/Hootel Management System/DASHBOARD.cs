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
    public partial class DASHBOARD : Form
    {
        dbconnect con = new dbconnect();
        
        public DASHBOARD()
        {
            InitializeComponent();
            countroos();
            CountTotal();
            getRoom();
            
        }
        private void countroos()
        {
            con.opencon();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT COUNT(*) FROM ROOMDB WHERE STATUSROOM = 'free';", con.GetConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            roomcount.Text = table.Rows[0][0].ToString();
            con.closecon();
        }
        private void CountTotal()
        {
            con.opencon();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT sum(paydb) from guestdb;", con.GetConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            amount.Text = table.Rows[0][0].ToString() + "    TL";
            con.closecon();
        }
        private void SumDay()
        {
            con.opencon();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT sum(paydb) from guestdb WHERE JOIN_DATE = '"+ dateinguna2DateTimePicker1.Text+"'", con.GetConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            day.Text= table.Rows[0][0].ToString() + "  TL";
            con.closecon();
        }

        private void dateinguna2DateTimePicker1_ValueChanged_1(object sender, EventArgs e)
        {
            SumDay();
        }
        private void getRoom()
        {
            con.opencon();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT `ROOMTYPE` FROM `hoteldb`.`roomdb`;", con.GetConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            guna2ComboBox1.DataSource = table;
            guna2ComboBox1.DisplayMember = "ROOMTYPE";
            con.closecon();
        }
        private void SumCoustmer()
        {
            con.opencon();
            MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT sum(paydb) from guestdb WHERE ROOM = '" + guna2ComboBox1.Text + "'", con.GetConnection());
            DataTable table = new DataTable();
            adapter.Fill(table);
            daycous.Text = table.Rows[0][0].ToString() + "  TL";
            con.closecon();
        }

        private void guna2ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            SumCoustmer();
        }
    }
}
