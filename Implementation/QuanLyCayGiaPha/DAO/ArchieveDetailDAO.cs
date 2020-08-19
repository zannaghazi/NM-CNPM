using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using DTO;

namespace DAO
{
    public class ArchieveDetailDAO
    {

        private MySqlCommand command;

        public ArchieveDetailDAO(MySqlCommand command)
        {
            this.command = command;
        }

        public bool AddNewArchieveDetail(ArchieveDetailDTO data)
        {
            string sql = "INSERT INTO CHITIETTHANHTICH(MATHANHVIEN, MALOAITHANHTICH, NGAYPHATSINH, TENTHANHTICH) " +
                "VALUES (" + data.getMaThanhVien() +"," +
                data.getMaLoaiThanhTich() + ", '" +
                data.getNgayPhatSinh().ToString("yyyy/MM/dd") +"', '" +
                data.getTenThanhTich() + "')";
            Console.WriteLine(sql);
            this.command.CommandText = sql;
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
