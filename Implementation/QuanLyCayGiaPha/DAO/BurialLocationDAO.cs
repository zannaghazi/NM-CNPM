using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public class BurialLocationDAO
    {
        private MySqlCommand command;

        public BurialLocationDAO(MySqlCommand command)
        {
            this.command = command;
        }
    }
}
