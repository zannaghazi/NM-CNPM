using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace DAO
{
    public class DeathMemberDAO
    {
        private MySqlCommand command;

        public DeathMemberDAO(MySqlCommand command)
        {
            this.command = command;
        }

        public bool AddNewDeathMemberDAO(DeathMemberDTO data)
        {
            string sqlQuery = "INSERT INTO THANHVIENMAT(MATHANHVIEN, MANGUYENNHANMAT, MADIADIEM, NGAYGIOMAT) " +
                "VALUES (" + data.getMaThanhVien() + ", " + 
                data.getMaNguyenNhan() + ", " +
                data.getMaDiaDiem() + ", '" +
                data.getNgayMat().ToString("yyyy/MM/dd") +
                "') ";
           
            this.command.CommandText = sqlQuery;
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
