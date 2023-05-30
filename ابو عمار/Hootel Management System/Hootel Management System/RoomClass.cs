using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Hootel_Management_System
{
    class RoomClass
    {
        dbconnect con = new dbconnect();

        // insert Command
        public bool insertRoom(string ROOMtype, string ROOMstatus)
        {
            string insertQuerry = "INSERT INTO ROOMDB (ROOMTYPE ,STATUSROOM) values(@ROOMT ,@ROOMS );";
            MySqlCommand command = new MySqlCommand(insertQuerry, con.GetConnection());
            command.Parameters.Add("@ROOMT", MySqlDbType.VarChar).Value = ROOMtype;
            command.Parameters.Add("@ROOMS", MySqlDbType.VarChar).Value = ROOMstatus;
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

        public DataTable getRoom()
        {
            string SelectQuery = "SELECT * FROM ROOMDB";
            MySqlCommand command = new MySqlCommand(SelectQuery, con.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;

        }
        public bool deleteRoom(string ROOMtype)
        {
            string deleteRoom = "DELETE FROM `hoteldb`.`ROOMDB` WHERE `ROOMTYPE` = @ROOMT";
            MySqlCommand command = new MySqlCommand(deleteRoom, con.GetConnection());
            command.Parameters.Add("@ROOMT", MySqlDbType.VarChar).Value = ROOMtype;
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

        public bool editroom(string status, string roomnum)
        {
            string editQuerry = "UPDATE `roomdb` SET  `STATUSROOM` = @stu WHERE `ROOMTYPE` = @id;";
            MySqlCommand command = new MySqlCommand(editQuerry, con.GetConnection());
            command.Parameters.Add("@stu", MySqlDbType.VarChar).Value = status;
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = roomnum;
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
