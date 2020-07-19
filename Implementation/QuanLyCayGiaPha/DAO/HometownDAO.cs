using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.Common;

namespace DAO
{
    public class HometownDAO
    {
        private MySqlCommand command;

        public HometownDAO(MySqlCommand command)
        {
            this.command = command;
        }

        public List<HometownDTO> getAllHomeTown()
        {
            List<HometownDTO> result = new List<HometownDTO>();

            string queryString = "SELECT * FROM QUEQUAN";
            this.command.CommandText = queryString;

            using (DbDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        HometownDTO temp = new HometownDTO(
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
