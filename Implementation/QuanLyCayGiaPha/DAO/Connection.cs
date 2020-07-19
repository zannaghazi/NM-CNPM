using MySql.Data.MySqlClient;
using System;

namespace DAO
{
    public class Connection
    {
        private MySqlConnection connection;
        private MySqlCommand command;

        public Connection() 
        {
            try
            {
                string connectionString = System.IO.File.ReadAllText("DBconfig.txt");
                // Console.WriteLine(connectionString);

                this.connection = new MySqlConnection(connectionString);
                this.connection.Open();
                this.command = this.connection.CreateCommand();
            }catch (Exception e)
            {
                throw e;
            }
        }

        public MySqlCommand getCommand()
        {
            return this.command;
        }
    }
}
