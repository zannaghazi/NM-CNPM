using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace DAO
{
    public class JobDAO
    {
        private MySqlCommand command;

        public JobDAO(MySqlCommand command)
        {
            this.command = command;
        }

        public List<JobDTO> getAllJob()
        {
            List<JobDTO> result = new List<JobDTO>();

            string queryString = "SELECT * FROM NGHENGHIEP";
            this.command.CommandText = queryString;

            using (DbDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        JobDTO temp = new JobDTO(
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
