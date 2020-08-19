using System;
using System.Collections.Generic;
using System.Text;

namespace DTO
{
    public class ArchieveDetailDTO
    {
        private int maChiTiet;
        private int maThanhVien;
        private int maLoaiThanhTich;
        private DateTime ngayPhatSinh;
        private string tenThanhTich;

        public ArchieveDetailDTO(int maChiTiet, int maThanhVien, int maLoaiThanhTich, DateTime ngayPhatSinh, string tenThanhTich)
        {
            this.maChiTiet = maChiTiet;
            this.maThanhVien = maThanhVien;
            this.maLoaiThanhTich = maLoaiThanhTich;
            this.ngayPhatSinh = ngayPhatSinh;
            this.tenThanhTich = tenThanhTich;
        }

        public int getMaChiTiet()
        {
            return this.maChiTiet;
        }

        public int getMaThanhVien()
        {
            return this.maThanhVien;
        }
        
        public int getMaLoaiThanhTich()
        {
            return this.maLoaiThanhTich;
        }

        public string getTenThanhTich()
        {
            return this.tenThanhTich;
        }
        public DateTime getNgayPhatSinh()
        {
            return this.ngayPhatSinh;
        }
    }
}
