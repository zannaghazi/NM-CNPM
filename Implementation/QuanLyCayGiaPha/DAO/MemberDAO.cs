using MySql.Data.MySqlClient;
using DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.Common;
using System.Security.Cryptography;

namespace DAO
{
    public class MemberDAO
    {
        private MySqlCommand command;
        
        public MemberDAO(MySqlCommand command)
        {
            this.command = command;
        }

        public List<DTO.MemberDTO> getAllMember()
        {
            List<MemberDTO> result = new List<MemberDTO>();

            string queryString = "SELECT * FROM THANHVIEN";
            this.command.CommandText = queryString;

            using (DbDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MemberDTO temp = new MemberDTO(
                            reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetInt32(2),
                            reader.GetInt32(3),
                            reader.GetString(4),
                            reader.GetString(5),
                            reader.GetDateTime(6),
                            reader.GetBoolean(7),
                            reader.GetString(8),
                            reader.GetDateTime(9),
                            reader.GetBoolean(10),
                            reader.GetInt32(11));
                        result.Add(temp);
                    }
                }else
                {
                    return result;
                }
            }

            return result;
        }

        public bool AddMember(MemberDTO member)
        {
            string maQueQuan = member.getMaQueQuan().ToString();
            string maLoaiQuanHe = member.getMaQuanHe().ToString();
            string maNgheNghiep = member.getMaNgheNghiep().ToString();


            string queryString = "INSERT INTO THANHVIEN(MAQUEQUAN, MALOAIQUANHE, MANGHENGHIEP, TENTHANHVIEN, THANHVIENCU, NGAYPHATSINH, GIOITINH, DIACHI, NGAYGIOSINH, TRANGTHAIMAT, DOI)" +
                "VALUES(" +
                maQueQuan + "," +
                maLoaiQuanHe + "," +
                maNgheNghiep + "," +
                "'" + member.getTenThanhVien() + "'," +
                "'" + member.getThanhVienCu() + "'," +
                "'" + DateTime.Now.ToString("yyyy/MM/dd") + "'," +
                member.getGioiTinh().ToString() + "," +
                "'" + member.getDiaChi().ToString() + "'," +
                "'" + member.getNgaySinh().ToString("yyyy/MM/dd") + "'," +
                member.getTrangThaiMat().ToString() + "," +
                member.getDoi().ToString() +
                ");";
            Console.WriteLine(queryString);
            this.command.CommandText = queryString;
            try
            {
                this.command.ExecuteNonQuery();
            }catch(Exception e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }

            return true;
        }

        public List<MemberDTO> findMember(string keyword)
        {
            List<MemberDTO> result = new List<MemberDTO>();

            string queryString = "SELECT * FROM THANHVIEN WHERE TENTHANHVIEN LIKE '%" + keyword +"%'";
            this.command.CommandText = queryString;

            using (DbDataReader reader = command.ExecuteReader())
            {
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        MemberDTO temp = new MemberDTO(
                            reader.GetInt32(0),
                            reader.GetInt32(1),
                            reader.GetInt32(2),
                            reader.GetInt32(3),
                            reader.GetString(4),
                            reader.GetString(5),
                            reader.GetDateTime(6),
                            reader.GetBoolean(7),
                            reader.GetString(8),
                            reader.GetDateTime(9),
                            reader.GetBoolean(10),
                            reader.GetInt32(11));
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

        public bool AdjustMemberStatus(MemberDTO member)
        {
            string queryString = "UPDATE THANHVIEN SET TRANGTHAIMAT = TRUE " +
                "WHERE MATHANHVIEN = " + member.getMaThanhVien().ToString();

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
