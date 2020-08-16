using DTO;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Text;

namespace DAO
{
    public class RelationshipDAO
    {
        private MySqlCommand command;

        public RelationshipDAO(MySqlCommand command)
        {
            this.command = command;
        }

        public List<RelationshipDTO> getAllRelation()
        {
            List<RelationshipDTO> result = new List<RelationshipDTO>();

            string queryString = "SELECT * FROM LOAIQUANHE";
            this.command.CommandText = queryString;

            using (DbDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        RelationshipDTO temp = new RelationshipDTO(
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
        public bool AddRelationship(RelationshipDTO relationshipDTO)
        {
            string tenQuanHe = relationshipDTO.getTenQuanHe();

            string queryString = "INSERT INTO LOAIQUANHE(TENLOAIQUANHE, DAXOA)" +
                "VALUES('" +
                tenQuanHe +
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
