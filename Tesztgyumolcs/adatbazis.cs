using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;

namespace Tesztgyumolcs
{
    internal class adatbazis
    {
        private MySqlConnection connection;
        private MySqlCommand command;
        private string errormessage=null;
        public adatbazis(string host,string user,string password,string db)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server=host;
            builder.UserID=user;
            builder.Password=password;
            builder.Database=db;
            connection = new MySqlConnection(builder.ConnectionString);
            command = connection.CreateCommand();
        }
        private bool dbopen()
        {
            try
            {
                if (connection.State!=System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (MySqlException ex)
            {
                errormessage=ex.Message;
                return false;
            }
            return true;
        }
        private bool dbclose()
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            catch (MySqlException ex)
            {
                errormessage = ex.Message;
                return false;                                        
            }
            return true;
        }
        public List<gyumolcs> getAllGyumolcs()
        {
            List<gyumolcs> gyumolcslist = new List<gyumolcs>();
            command.CommandText = "SELECT `id`,`nev`,`egysegar`,`mennyiseg` FROM `gyumolcsok` WHERE 1";
            if (dbopen())
            {
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        gyumolcs uj = new gyumolcs(dr.GetInt32("id"),dr.GetString("nev"),dr.GetDouble("egysegar"),dr.GetDouble("mennyiseg"));
                        gyumolcslist.Add(uj);
                    }
                }
            }
            else
            {
                MessageBox.Show(errormessage);
            }
            dbclose();
            return gyumolcslist;
        }
    }
}
