using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace DAO
{
    public class SystemContrantDAO
    {
        private MySqlCommand command;
        
        public SystemContrantDAO(MySqlCommand command)
        {
            this.command = command;
        }

        public JobDTO getJobByID(int id)
        {
            JobDTO result = null;

            string queryString = "SELECT* FROM NGHENGHIEP WHERE MANGHENGHIEP=" + id;
            this.command.CommandText = queryString;

            using (DbDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        result = new JobDTO(
                            reader.GetInt32(0),
                            reader.GetString(1),
                            reader.GetBoolean(2));
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
