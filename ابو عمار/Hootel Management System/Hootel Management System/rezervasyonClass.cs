using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Hootel_Management_System
{
    class rezervasyonClass
    {
        dbconnect con = new dbconnect();

        public DataTable roomByType()
        {
           string SelectQuery = "SELECT `ROOMTYPE` FROM `hoteldb`.`roomdb`;";
            MySqlCommand command = new MySqlCommand(SelectQuery, con.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
        public DataTable roomByType2()
        {
            string SelectQuery = "SELECT `ROOMTYPE` FROM `hoteldb`.`roomdb` WHERE STATUSROOM = 'free';";
            MySqlCommand command = new MySqlCommand(SelectQuery, con.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public DataTable CoustmerByRoom(string room)
        { 
            string SelectQuery = "SELECT *FROM `hoteldb`.`guestdb` WHERE ROOM = @room;";
            MySqlCommand command = new MySqlCommand(SelectQuery, con.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            command.Parameters.Add("@room", MySqlDbType.VarChar).Value = room;
            adapter.Fill(table);
            return table;
        }
        public bool revUpdate (string rom,string stu)
        {
            string UpdateQuery = "UPDATE `roomdb` SET `STATUSROOM` = @sts WHERE `ROOMTYPE` = @rno;";
            MySqlCommand command = new MySqlCommand(UpdateQuery, con.GetConnection());
            command.Parameters.Add("@sts", MySqlDbType.VarChar).Value = stu;
            command.Parameters.Add("@rno", MySqlDbType.VarChar).Value = rom;
            con.opencon();
            if (command.ExecuteNonQuery() == 1)
            {
                con.closecon();
                return true;
            }
            else
            {
                con.closecon();
                return false;
            }
        }
        public DataTable getRez()
        {
            string SelectQuery = "SELECT  *FROM `rezdb`;";
            MySqlCommand command = new MySqlCommand(SelectQuery, con.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;

        }

        public bool insertRez(string tc, string romm, DateTime Datein, DateTime dateout)
        {
            string insertQuerry = "INSERT INTO REZDB (TC , ROOOM , DateIn ,DateOut) values(@TC ,@room ,@dain ,@daout);";
            MySqlCommand command = new MySqlCommand(insertQuerry, con.GetConnection());
          
            command.Parameters.Add("@TC", MySqlDbType.VarChar).Value = tc;
            command.Parameters.Add("@room", MySqlDbType.VarChar).Value = romm;
            command.Parameters.Add("@dain", MySqlDbType.Date).Value = Datein;
            command.Parameters.Add("@daout", MySqlDbType.Date).Value = dateout;
            con.opencon();
            if (command.ExecuteNonQuery() == 1)
            {
                con.closecon();
                return true;
            }
            else
            {
                con.closecon();
                return false;
            }

        }

        public bool deleterez(string tc)
        {
            string deleteGuest = "DELETE FROM `hoteldb`.`rezdb` WHERE `TC` = @TC";
            MySqlCommand command = new MySqlCommand(deleteGuest, con.GetConnection());
            command.Parameters.Add("@TC", MySqlDbType.VarChar).Value = tc;
            con.opencon();
            if (command.ExecuteNonQuery() == 1)
            {
                con.closecon();
                return true;
            }
            else
            {
                con.closecon();
                return false;
            }
        }

    }
}
