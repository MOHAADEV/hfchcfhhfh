using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace Hootel_Management_System
{
    class GuestClass
    {
        dbconnect con = new dbconnect();

        // insert Command
        public bool insertGuest(string tc, string name, string tel, string pay, string date, string room , string method,string nas)
        {
            string insertQuerry = "INSERT INTO GUESTDB (TC , NAME_LAST , TELE ,PAYDB , JOIN_DATE , ROOM ,METHOD,NASH) values(@TC ,@NMLS ,@TELE ,@PAY ,@DATE ,@ROOM,@METH,@NASH);";
            MySqlCommand command = new MySqlCommand(insertQuerry, con.GetConnection());
            command.Parameters.Add("@TC", MySqlDbType.VarChar).Value = tc;
            command.Parameters.Add("@NMLS", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@TELE", MySqlDbType.VarChar).Value = tel;
            command.Parameters.Add("@PAY", MySqlDbType.VarChar).Value = pay;
            command.Parameters.Add("@DATE", MySqlDbType.VarChar).Value = date;
            command.Parameters.Add("@ROOM", MySqlDbType.VarChar).Value = room;
            command.Parameters.Add("@METH", MySqlDbType.VarChar).Value = method;
            command.Parameters.Add("@NASH", MySqlDbType.VarChar).Value = nas;
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

        //load table from database;
        public DataTable getGuest()
        {
            string SelectQuery = "SELECT * FROM GUESTDB";
            MySqlCommand command = new MySqlCommand(SelectQuery, con.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;

        }

        // to edit info in database
        public bool editGuest(string tc, string name, string tel, string pay, string date, string room)
        {
            string editQuerry = "UPDATE `guestdb` SET  `TC` = @TC, `NAME_LAST` = @NMLS ,`TELE` = @TELE , `PAYDB`= @PAY , `JOIN_DATE` = @DATE, `ROOM` = @ROOM WHERE `TC` = @TC;";
            MySqlCommand command = new MySqlCommand(editQuerry, con.GetConnection());
            command.Parameters.Add("@TC", MySqlDbType.VarChar).Value = tc;
            command.Parameters.Add("@NMLS", MySqlDbType.VarChar).Value = name;
            command.Parameters.Add("@TELE", MySqlDbType.VarChar).Value = tel;
            command.Parameters.Add("@PAY", MySqlDbType.VarChar).Value = pay;
            command.Parameters.Add("@DATE", MySqlDbType.VarChar).Value = date;
            command.Parameters.Add("@ROOM", MySqlDbType.VarChar).Value = room;
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

        //to delete info from database
        public bool deleteGuest(string tc)
        {
            string deleteGuest = "DELETE FROM `hoteldb`.`guestdb` WHERE `TC` = @TC";
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
