using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAO
{
    public class DeathMemberDAO
    {
        private MySqlCommand command;

        public DeathMemberDAO(MySqlCommand command)
        {
            this.command = command;
        }
    }
}
