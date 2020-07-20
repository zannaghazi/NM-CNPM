using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public class ArchieveDetailDAO
    {

        private MySqlCommand command;

        public ArchieveDetailDAO(MySqlCommand command)
        {
            this.command = command;
        }
    }
}
