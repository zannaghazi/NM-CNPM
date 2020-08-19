using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.Common;

namespace DAO
{
    public class ArchieveTypeDAO
    {
        private MySqlCommand command;

        public ArchieveTypeDAO(MySqlCommand command)
        {
            this.command = command;
        }

        public List<ArchieveTypeDTO> getAllArchieveType()
        {
            List<ArchieveTypeDTO> result = new List<ArchieveTypeDTO>();

            string sql = "select * from loaithanhtich where daxoa = false";
            this.command.CommandText = sql;

            using (DbDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        ArchieveTypeDTO temp = new ArchieveTypeDTO(
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
