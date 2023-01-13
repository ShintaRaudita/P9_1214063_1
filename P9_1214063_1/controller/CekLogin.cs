using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P9_1214063_1.controller
{
    internal class CekLogin
    {
        Koneksi koneksi = new Koneksi();

        public bool Cek_Login(string username, string password)
        {
            try
            {
                koneksi.OpenConnection();
                MySqlDataReader reader = koneksi.reader("SELECT * FROM t_users WHERE username = '" + username + "' AND password = '" + password + "' ");
                //MySqlDataReader reader = koneksi.reader("SELECT * FROM t_admin WHERE username='" +
                    //username + "' AND password='" + password + "'");
                if (reader.Read())
                {
                    koneksi.CloseConnection();
                    return true;
                }
                else
                {
                    koneksi.CloseConnection();
                    return false;
                }
            }
            catch (Exception e)
            {
                koneksi.CloseConnection();
                MessageBox.Show(e.Message, "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            koneksi.CloseConnection();
            return false;
        }
    }//end internal class CekLogin
}
