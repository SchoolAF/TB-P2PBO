using MySql.Data.MySqlClient;
using System.Data;

namespace TB_P2PBO.controller
{
    internal class Koneksi
    {
        string connectionstring = "Server=c.eclipse.herobuxx.me;Database=pbo_db;Uid=buxx;Pwd=@L!ffathur5;";
        public MySqlConnection kon;

        public void OpenConnection()
        {
            kon = new MySqlConnection(connectionstring);
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

        public DataTable ShowData(string query)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(query, connectionstring);
            DataTable dataTable = new DataTable();

            adapter.Fill(dataTable);

            return dataTable;
        }
    }
}
