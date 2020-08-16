using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using DTO;
using System.Data.Common;

namespace DAO
{
    public class DeathReasonDAO
    {
        private MySqlCommand command;

        public DeathReasonDAO(MySqlCommand command)
        {
            this.command = command;
        }

        public List<DeathReasonDTO> getAllDeathReason()
        {
            List<DeathReasonDTO> result = new List<DeathReasonDTO>();

            string queryString = "SELECT * FROM NGUYENNHANMAT";
            this.command.CommandText = queryString;

            using (DbDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        DeathReasonDTO temp = new DeathReasonDTO(
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
        public bool AddDeathReason(DeathReasonDTO deathReasonDTO)
        {
            string tennguyendochet = deathReasonDTO.getTenNguyenNhan();

            string queryString = "INSERT INTO NGUYENNHANMAT(TENNGUYENNHANMAT, DAXOA)" +
                "VALUES('" +
                tennguyendochet +
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
