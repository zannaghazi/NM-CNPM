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
        public bool AddHomeTown(HometownDTO homeTownDTO)
        {
            string tenquequan = homeTownDTO.getTenQueQuan();

            string queryString = "INSERT INTO QUEQUAN(TENQUEQUAN, DAXOA)" +
                "VALUES('" +
                tenquequan +
                "', false" +
                ")";

            Console.WriteLine(queryString);
            this.command.CommandText = queryString;
            try
            {
                this.command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }

            return true;
        }
    }
}
