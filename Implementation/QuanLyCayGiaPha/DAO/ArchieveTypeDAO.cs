using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public class ArchieveTypeDAO
    {
        private MySqlCommand command;

        public ArchieveTypeDAO(MySqlCommand command)
        {
            this.command = command;
        }
    }
}
