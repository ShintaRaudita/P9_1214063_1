using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P9_1214063_1
{
    internal class Koneksi
    {
        string conectionstring = "Server=localhost;Database=ulbii;Uid=root;Pwd=;";
        MySqlConnection kon;

        public void OpenConnection()
        {
            kon = new MySqlConnection(conectionstring);
            kon.Open();
        }

        public void CloseConnection()
        {
            kon.Close();
        }

        public void ExecuteQuery(string query)
        {
            MySqlCommand command = new MySqlCommand(query, kon);
            command.ExecuteNonQuery();
        }

        public object ShowData(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, conectionstring);
            DataSet data = new DataSet();

            adapter.Fill(data);
            object datatable = data.Tables[0];
            return datatable;
        }

        internal MySql.Data.MySqlClient.MySqlDataReader reader(string v)
        {
            throw new NotImplementedException();
        }
    }// end internal class koneksi
}
