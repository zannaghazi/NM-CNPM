using System;
using System.Collections.Generic;
using System.Text;
using DAO;
using MySql.Data.MySqlClient;

namespace BUS
{
    public class MainBUS
    {
        private MySqlCommand command;
        public MainBUS()
        {
            Connection conn = new DAO.Connection();
            this.command = conn.getCommand();
        }

        public MySqlCommand GetCommand()
        {
            return this.command;
        }
    }
}
