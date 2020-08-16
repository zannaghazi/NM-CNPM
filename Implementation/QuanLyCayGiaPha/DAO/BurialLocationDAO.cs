using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
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
        public List<BurialLocationDTO> getAll()
        {
            List<BurialLocationDTO> result = new List<BurialLocationDTO>();

            string queryString = "SELECT * FROM DIADIEMMAITANG";
            this.command.CommandText = queryString;

            using (DbDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        BurialLocationDTO temp = new BurialLocationDTO(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetBoolean(2));
                        result.Add(temp);
                    }
                }
                else
                {
                    return result;
                }
            }

            return result;
        }
    }
}
