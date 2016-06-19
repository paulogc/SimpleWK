using System;
using MySql.Data.MySqlClient;


namespace DAO
{
    public class Database
    {
        private static MySqlConnection connection;
        private static Database instance; 
        private const string URL= "Server=localhost; Database=simplewk; Uid=root; Pwd=;";

        private Database() {
            connection = new MySqlConnection(URL);
        }
         
        public static Database GetInstance() {
            if (instance == null)
                instance = new Database();
            return instance;
        }

        public MySqlConnection GetConnection() {
            return connection;
        }

        public int GetId() {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open();

            string sql = "select last_insert_id();";
            MySqlCommand cmd = new MySqlCommand(sql, connection);
            int idRetorno = Convert.ToInt32(cmd.ExecuteScalar().ToString());
            connection.Close();

            return idRetorno;
        }

        public void ExecuteSQL(string qry) {
            if (connection.State != System.Data.ConnectionState.Open)
                connection.Open(); MySqlCommand comm = new MySqlCommand(qry, connection);
            comm.ExecuteNonQuery();

            connection.Close();
        }
    }
}
